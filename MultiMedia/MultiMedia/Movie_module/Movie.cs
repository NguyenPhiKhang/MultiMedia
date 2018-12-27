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
        List<item_movie> itemMovies = new List<item_movie>();
        item_movie item_Movie;
        public Movie()
        {
            InitializeComponent();
            //btn_back.Enabled = false;
            //btn_forward.Enabled = false;
            ActiveTaskBarFilm();
            dropdown_theloai.NomalColor = Color.FromArgb(36, 129, 77);
            dropdown_theloai.ForeColor = Color.White;
            url_origin = "http://phimvietsubhd.com/the-loai/co-trang-than-thoai-6.html?page=";
            LoadFilm(url_origin+"1");
        }


        public void LoadFilm(string url)
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
                HtmlNode Sotrangphim = document.DocumentNode.SelectSingleNode("//div[@class='pagination']/ul");
                try
                {
                    currentPage = Convert.ToInt32(Sotrangphim.SelectSingleNode(".//a[@class='current']").InnerText);
                    MaxPage = Convert.ToInt32(Sotrangphim.SelectSingleNode(".//li[last()-1]").InnerText);
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
                var listfilm_collection = document.DocumentNode.SelectNodes("//div[@class='block-film']/ul[@class='list-film']/li").ToList();
                //HtmlNodeCollection listfilm_collection = list_film.SelectNodes(@"li");

                for (int i = 0; i < listfilm_collection.Count; i++)
                {
                    item_Movie = new item_movie();
                    item_Movie.lbl_name.Text = listfilm_collection[i].SelectSingleNode(".//div[@class='title']/p[@class='name']").InnerText.ToString();
                    item_Movie.lbl_status.Text = listfilm_collection[i].SelectSingleNode(".//label").InnerText.ToString();
                    item_Movie.btn_avatar.ImageLocation = listfilm_collection[i].SelectSingleNode(".//a/img").Attributes["src"].Value;
                    item_Movie.lbl_realname.Text = listfilm_collection[i].SelectSingleNode(".//div[@class='title']/p[@class='real-name']").InnerText.ToString();
                    item_Movie.lbl_url.Text = "http://phimvietsubhd.com"+listfilm_collection[i].SelectSingleNode(".//a").Attributes["href"].Value.ToString();
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
            btn_phimkhac.Normalcolor = Color.FromArgb(250, 204, 46);
            btn_chieurap.Normalcolor = Color.FromArgb(250, 204, 46);
            dropdown_theloai.ForeColor = Color.Black;
            btn_phimle.Textcolor = Color.Black;
            btn_phimkhac.Textcolor = Color.Black;
            btn_chieurap.Textcolor = Color.Black;
        }
        
        int tag;
        void btnAvatar_Click(object sender, EventArgs e)
        {
            //Lấy vị trí film trong list            
            Bunifu.Framework.UI.BunifuImageButton imageButton = sender as Bunifu.Framework.UI.BunifuImageButton;
            tag = Convert.ToInt32(imageButton.Tag.ToString());
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerAsync();
        }
        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
            };
            htmlWeb.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.110 Safari/537.36";
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(itemMovies[tag].lbl_url.Text.ToString());
            var chromedriverServer = ChromeDriverService.CreateDefaultService();
            chromedriverServer.HideCommandPromptWindow = true;
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            IWebDriver driver = new ChromeDriver(chromedriverServer, option);
            try
            {
                string b = "http://phimvietsubhd.com" + document.DocumentNode.SelectSingleNode("//a[@class='btn-see btn btn-danger']").Attributes["href"].Value.ToString();
                driver.Url = b;
                Thread.Sleep(500);
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
                url_origin = "http://phimvietsubhd.com/the-loai/co-trang-than-thoai-6.html?page=";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 1)
            {
                url_origin = "http://phimvietsubhd.com/the-loai/phim-hoat-hinh-55.html?page=";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 2)
            {
                url_origin = "http://phimvietsubhd.com/the-loai/van-hoa-tam-linh-53.html?page=";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 3)
            {
                url_origin = "http://phimvietsubhd.com/the-loai/gia-dinh-hoc-duong-58.html?page=";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 4)
            {
                url_origin = "http://phimvietsubhd.com/the-loai/phim-thuyet-minh-59.html?page=";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 5)
            {
                url_origin = "http://phimvietsubhd.com/the-loai/vo-thuat-kiem-hiep-4.html?page=";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 6)
            {
                url_origin = "http://phimvietsubhd.com/the-loai/khoa-hoc-vien-tuong-2.html?page=";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 7)
            {
                url_origin = "http://phimvietsubhd.com/the-loai/hai-huoc-52.html?page=";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 8)
            {
                url_origin = "http://phimvietsubhd.com/the-loai/phieu-luu-hanh-dong-1.html?page=";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 9)
            {
                url_origin = "http://phimvietsubhd.com/the-loai/hinh-su-chien-tranh-7.html?page=";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 10)
            {
                url_origin = "http://phimvietsubhd.com/the-loai/tam-ly-tinh-cam-51.html?page=";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 11)
            {
                url_origin = "http://phimvietsubhd.com/the-loai/tai-lieu-kham-pha-3.html?page=";
                _url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 12)
            {
                url_origin = "http://phimvietsubhd.com/the-loai/kinh-di-ma-5.html?page=";
                _url = url_origin + numberPage;
            }
            LoadFilm(_url);
        }

        private void btn_phimle_Click(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            btn_phimle.Textcolor = Color.White;
            btn_phimle.Normalcolor = Color.FromArgb(36, 129, 77);
            url_origin = "http://phimvietsubhd.com/danh-sach/phim-le.html?page=";
            _url = url_origin + numberPage;
            LoadFilm(_url);
        }
        private void btn_phimkhac_Click(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            btn_phimkhac.Textcolor = Color.White;
            btn_phimkhac.Normalcolor = Color.FromArgb(36, 129, 77);
            url_origin = "http://phimvietsubhd.com/quoc-gia/quoc-gia-khac-9.html?page=";
            _url = url_origin + numberPage;
            LoadFilm(_url);
        }

        private void btn_chieurap_Click(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            btn_chieurap.Textcolor = Color.White;
            btn_chieurap.Normalcolor = Color.FromArgb(36, 129, 77);
            url_origin = "http://phimvietsubhd.com/phim-chieu-rap?page=";
            _url = url_origin + numberPage;
            LoadFilm(_url);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //if (_url.IndexOf("tim-kiem.html") != -1)
            //{
            //    _url = "http://www1.xemvtv.net/tim-kiem/" + search2 + "/page-" + (currentPage - 1);

            //    LoadFilm(_url);
            //}
            //else
            //if (currentPage < 1)
            //{

            //    return;
            //}
            //else
            //{
            string nextPage_url = url_origin + (currentPage - 1);
            LoadFilm(nextPage_url);
            //}
        }

        private void tb_timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                btn_timkiem_Click_1(sender, e);
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            //if (_url.IndexOf("/tim-kiem/") != -1)
            //{
            //    _url = "http://www1.xemvtv.net/tim-kiem/" + search2 + "/page-" + (currentPage + 1);

            //    LoadFilm(_url);
            //}
            //else if (currentPage > MaxPage)
            //{
            //    return;
            //}
            //else
            //{
            string nextPage_url = url_origin + (currentPage + 1);
            LoadFilm(nextPage_url);
            //}
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_timkiem_Click_1(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            dropdown_theloai.selectedIndex = -1;
            string search = tb_timkiem.Text.Trim().ToString();
            if (search != null)
            {
                search2 = search.Replace(" ", "+");

               _url = "http://phimvietsubhd.com/tim-kiem.html?q=" + search2;

                LoadFilm(_url);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên phim muốn tìm !!");
            }
        }
    }
}