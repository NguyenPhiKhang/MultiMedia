using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace MultiMedia.Movie_module
{
    public partial class Movie : UserControl
    {
        public static string _url, url_origin, search2;
        public static int currentPage, MaxPage;
        //public static bool isPlay = false;
        public int numberPage = 1;
        //public int numberFilm;
        //public String keyword = "keyword";
        item_movie item_Movie;
        List<item_movie> itemMovies = new List<item_movie>();
        public Movie()
        {
            InitializeComponent();
            btn_back.Enabled = false;
            btn_forward.Enabled = false;
        }


        public void LoadFilm(String url)
        {
            while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);
            try
            {
                itemMovies.Clear();
                HtmlWeb htmlWeb = new HtmlWeb()
                {
                    AutoDetectEncoding = false,
                    OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
                };
                htmlWeb.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.110 Safari/537.36";
                HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(url);
                //Lay so luong trang phim
                HtmlNode Sotrangphim = document.DocumentNode.SelectSingleNode("//span[@class='page_nav']");
                try
                {
                    currentPage = Convert.ToInt32(Sotrangphim.SelectSingleNode(".//span[@class='current']").InnerText);
                    MaxPage = Convert.ToInt32(Sotrangphim.SelectSingleNode(".//span[last()-1]").InnerText);
                }
                catch
                {
                    currentPage = MaxPage = 1;
                }


                lbl_sotrang.Text = currentPage + " / " + MaxPage;
                if (currentPage <= 1)
                {
                    btn_back.Enabled = false;
                    btn_forward.Enabled = (currentPage == MaxPage) ? false : true;
                }
                else if (currentPage >= MaxPage)
                {
                    btn_back.Enabled = true;
                    btn_forward.Enabled = false;
                }
                else
                {
                    btn_back.Enabled = true;
                    btn_forward.Enabled = true;
                }

                //Lay so luong phim trong trang dau tien
                var listfilm_collection = document.DocumentNode.SelectNodes("//ul[@class='list-film']/li").ToList();
                //HtmlNodeCollection listfilm_collection = list_film.SelectNodes(@"li");

                for (int i = 0; i < listfilm_collection.Count; i++)
                {
                    item_Movie = new item_movie();
                    item_Movie.lbl_name.Text = listfilm_collection[i].SelectSingleNode(".//div[@class='name']/a").InnerText.ToString();
                    try
                    {
                        item_Movie.lbl_status.Text = listfilm_collection[i].SelectSingleNode(".//div[@class='status']").InnerText.ToString();
                    }
                    catch { item_Movie.lbl_status.Text = null; }

                    item_Movie.btn_avatar.ImageLocation = listfilm_collection[i].SelectSingleNode(".//div[@class='inner']/a/img").Attributes["src"].Value;
                    item_Movie.lbl_realname.Text = listfilm_collection[i].SelectSingleNode(".//div[@class='name2']").InnerText.ToString();
                    String url_film = "/" + listfilm_collection[i].SelectSingleNode(".//div[@class='inner']/a").Attributes["href"].Value.ToString();
                    item_Movie.lbl_url.Text = "http://woohay.com" + url_film.Replace("/phim/", "/xem-phim/");

                    item_Movie.Name = "movie" + i;
                    item_Movie.Tag = i.ToString();
                    item_Movie.btn_avatar.Tag = i.ToString();
                    item_Movie.btn_avatar.Click += btnAvatar_Click;
                    flowLayoutPanel1.Controls.Add(item_Movie);

                    itemMovies.Add(item_Movie);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không có phim !!");
            }
        }
        //BackgroundWorker bw;
        void ActiveTaskBarFilm()
        {
            dropdown_theloai.NomalColor = Color.FromArgb(250, 204, 46);
            btn_phimle.Normalcolor = Color.FromArgb(250, 204, 46);
            btn_phimmoi.Normalcolor = Color.FromArgb(250, 204, 46);
            btn_chieurap.Normalcolor = Color.FromArgb(250, 204, 46);
            dropdown_theloai.ForeColor = Color.Black;
            btn_phimle.Textcolor = Color.Black;
            btn_phimmoi.Textcolor = Color.Black;
            btn_chieurap.Textcolor = Color.Black;
        }
        
        int tag;
        void btnAvatar_Click(object sender, EventArgs e)
        {
            //Lấy vị trí film trong list            
            Bunifu.Framework.UI.BunifuImageButton imageButton = sender as Bunifu.Framework.UI.BunifuImageButton;
            tag = Convert.ToInt32(imageButton.Tag.ToString());
            //ShowFilm(itemMovies[tag]);
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerAsync();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            var chromedriverServer = ChromeDriverService.CreateDefaultService();
            chromedriverServer.HideCommandPromptWindow = true;
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            IWebDriver driver = new ChromeDriver(chromedriverServer, option);
            try
            {
                driver.Url = itemMovies[tag].lbl_url.Text.ToString();
                Thread.Sleep(3000);
                IWebElement link_element = driver.FindElement(By.XPath("//div[@class='jw-media jw-reset']/video"));
                String linkvideofilm = link_element.GetAttribute("src").Trim();
                Invoke(new Action(() =>
                {
                    Movie_module.FrmVLC frmVLC = new Movie_module.FrmVLC(linkvideofilm);
                    frmVLC.lbl_name_video.Text = itemMovies[tag].lbl_name.Text.ToString();
                    frmVLC.axVLCPlugin21.playlist.stop();
                    frmVLC.Show();
                }));

            }
            catch
            {
                //MessageBox.Show("Xin Lỗi! Server đang bận!\r\n Không thể phát được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                Invoke(new Action(()=>
                {
                    Movie_module.ThongBao tb = new Movie_module.ThongBao();
                    tb.Show();
                }));
            }
            driver.Quit();
            driver.Dispose();
        }

        private void dropdown_theloai_onItemSelected(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            dropdown_theloai.NomalColor = Color.FromArgb(36, 129, 77);
            dropdown_theloai.ForeColor = Color.White;
            if (dropdown_theloai.selectedIndex == 0)
            {
                url_origin = "https://woohay.com/the-loai/phim-hanh-dong/page-";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 1)
            {
                url_origin = "https://woohay.com/the-loai/phim-hoat-hinh/page-";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 2)
            {
                url_origin = "https://woohay.com/the-loai/phim-vien-tuong/page-";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 3)
            {
                url_origin = "https://woohay.com/the-loai/phim-phieu-luu/page-";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 4)
            {
                url_origin = "https://woohay.com/the-loai/phim-vo-thuat/page-";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 5)
            {
                url_origin = "https://woohay.com/the-loai/phim-than-thoai/page-";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 6)
            {
                url_origin = "https://woohay.com/the-loai/phim-kinh-di/page-";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 7)
            {
                url_origin = "https://woohay.com/the-loai/phim-hai-huoc/page-";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 8)
            {
                url_origin = "https://woohay.com/the-loai/phim-co-trang/page-";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 9)
            {
                url_origin = "https://woohay.com/the-loai/phim-chien-tranh/page-";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 10)
            {
                url_origin = "https://woohay.com/the-loai/phim-hai-viet/page-";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 11)
            {
                url_origin = "https://woohay.com/the-loai/phim-tam-ly/page-";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 12)
            {
                url_origin = "https://woohay.com/the-loai/phim-thieu-nhi/page-";
                _url = url_origin + numberPage;
            }
            LoadFilm(_url);
        }

        private void btn_phimle_Click(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            btn_phimle.Textcolor = Color.White;
            btn_phimle.Normalcolor = Color.FromArgb(36, 129, 77);
            url_origin = "https://woohay.com/danh-sach/phim-le/page-";
            _url = url_origin + numberPage;
            LoadFilm(_url);
        }

        private void btn_phimmoi_Click(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            btn_phimmoi.Textcolor = Color.White;
            btn_phimmoi.Normalcolor = Color.FromArgb(36, 129, 77);
            url_origin = "https://woohay.com/danh-sach/phim-moi/page-";
            _url = url_origin + numberPage;
            LoadFilm(_url);
        }

        private void btn_chieurap_Click(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            btn_chieurap.Textcolor = Color.White;
            btn_chieurap.Normalcolor = Color.FromArgb(36, 129, 77);
            url_origin = "https://woohay.com/danh-sach/phim-chieu-rap/page-";
            _url = url_origin + numberPage;
            LoadFilm(_url);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (_url.IndexOf("/search/") != -1)
            {
                _url = "https://woohay.com/search/" + search2 + "/page-" + (currentPage - 1);

                LoadFilm(_url);
            }
            else if (currentPage < 1)
            {

                return;
            }
            else
            {
                String nextPage_url = url_origin + (currentPage - 1);
                LoadFilm(nextPage_url);
            }
        }

        private void tb_timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                btn_timkiem_Click_1(sender, e);
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if (_url.IndexOf("/search/") != -1)
            {
                _url = "https://woohay.com/search/" + search2 + "/page-" + (currentPage + 1);

                LoadFilm(_url);
            }
            else if (currentPage > MaxPage)
            {
                return;
            }
            else
            {
                String nextPage_url = url_origin + (currentPage + 1);
                LoadFilm(nextPage_url);
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_timkiem_Click_1(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            dropdown_theloai.selectedIndex = -1;
            String search = tb_timkiem.Text.ToString();
            if (search != null)
            {
                search2 = search.Replace(" ", "-");

               _url = "https://woohay.com/search/" + search2;

                LoadFilm(_url);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên phim muốn tìm !!");
            }
        }
    }
}