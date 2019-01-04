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
        HtmlWeb htmlWeb;
        public Movie()
        {
            InitializeComponent();
            htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
            };
            htmlWeb.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.110 Safari/537.36";
            //btn_back.Enabled = false;
            //btn_forward.Enabled = false;
            ActiveTaskBarFilm();
            dropdown_theloai.NomalColor = Color.FromArgb(36, 129, 77);
            dropdown_theloai.ForeColor = Color.White;
            url_origin = "http://www.hdvnn.net/the-loai/hanh-dong/trang-";
            _url = url_origin + "1.html";
            LoadFilm(_url);
        }


        public void LoadFilm(string url)
        {
            while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);
            try
            {
                itemMovies.Clear();
                HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(url);
                //Lay so luong trang phim
                HtmlNode Sotrangphim = document.DocumentNode.SelectSingleNode("//span[@class='page_nav']");
                try
                {
                    currentPage = Convert.ToInt32(Sotrangphim.SelectSingleNode(".//span[@class='current']").InnerText);
                    string a = Sotrangphim.SelectSingleNode(".//span[last()]/a").Attributes["href"].Value.ToString();
                    string[] b = a.Split(new string[] { "trang-" }, StringSplitOptions.None);
                    string[] c = b[1].Split('.' );
                    MaxPage = Convert.ToInt32(c[0]);
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
                var listfilm_collection = document.DocumentNode.SelectNodes("//div[@class='list-film row']/div[@class='item col-lg-3 col-md-3 col-sm-6 col-xs-6']").ToList();
                //HtmlNodeCollection listfilm_collection = list_film.SelectNodes(@"li");

                for (int i = 0; i < listfilm_collection.Count; i++)
                {
                    item_Movie = new item_movie();
                    item_Movie.lbl_name.Text = listfilm_collection[i].SelectSingleNode(".//div[@class='inner']/a[2]").InnerText.ToString();
                    item_Movie.lbl_status.Text = listfilm_collection[i].SelectSingleNode(".//div[@class='inner']/span").InnerText.ToString();
                    item_Movie.btn_avatar.ImageLocation = listfilm_collection[i].SelectSingleNode(".//div[@class='inner']/a/img").Attributes["src"].Value;
                    item_Movie.lbl_realname.Text = listfilm_collection[i].SelectSingleNode(".//div[@class='inner']/dfn[1]").InnerText.ToString();
                    item_Movie.lbl_year.Text = listfilm_collection[i].SelectSingleNode(".//div[@class='inner']/dfn[2]").InnerText.ToString();
                    item_Movie.lbl_url.Text = listfilm_collection[i].SelectSingleNode(".//div[@class='inner']/a[@class='poster']").Attributes["href"].Value.ToString()+"/xem-phim.html";
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
        List<string> links_server = new List<string>();
        void btnAvatar_Click(object sender, EventArgs e)
        {
            links_server.Clear();
            //Lấy vị trí film trong list            
            Bunifu.Framework.UI.BunifuImageButton imageButton = sender as Bunifu.Framework.UI.BunifuImageButton;
            tag = Convert.ToInt32(imageButton.Tag.ToString());
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerAsync();
        }
        void ShowVLC(string url)
        {
            Invoke(new Action(() =>
            {
                Movie_module.FrmVLC frmVLC = new Movie_module.FrmVLC(url);
                frmVLC.lbl_name_video.Text = itemMovies[tag].lbl_name.Text.ToString();
                frmVLC.axVLCPlugin21.playlist.stop();
                frmVLC.Show();
            }));
        }
        void ShowThongBao()
        {
            Invoke(new Action(() =>
            {
                Movie_module.ThongBao tb = new Movie_module.ThongBao();
                tb.Show();
            }));
        }
        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            HtmlAgilityPack.HtmlDocument document1 = htmlWeb.Load(itemMovies[tag].lbl_url.Text.ToString());
            try
            {
                var list_server = document1.DocumentNode.SelectNodes("//div[@class='server']/div[2]/ul/li").ToList();
                foreach (var item in list_server)
                {
                    links_server.Add(item.SelectSingleNode(".//a").Attributes["href"].Value.ToString());
                }
            }
            catch { }

            var chromedriverServer = ChromeDriverService.CreateDefaultService();
            chromedriverServer.HideCommandPromptWindow = true;
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            IWebDriver driver = new ChromeDriver(chromedriverServer, option);
            for (int i=links_server.Count-1;i>=0;i--)
            {
                driver.Url = links_server[i];
                Thread.Sleep(500);
                IWebElement link_element;
                string linkvideofilm;
                try
                {
                    link_element = driver.FindElement(By.XPath("//div[@class='jw-media jw-reset']/video"));
                    linkvideofilm = link_element.GetAttribute("src").Trim();
                    if (linkvideofilm == null || linkvideofilm == "")
                        goto _next;
                    ShowVLC(linkvideofilm);
                    driver.Quit();
                    driver.Dispose();
                    return;
                }
                catch
                {
                    //MessageBox.Show("Xin Lỗi! Server đang bận!\r\n Không thể phát được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    try
                    {
                        link_element = driver.FindElement(By.XPath("//div[@id='player-area']/iframe"));
                        driver.Url = link_element.GetAttribute("src").Trim().ToString();
                        link_element = driver.FindElement(By.XPath("//div[@class='jw-media jw-reset']/video"));
                        linkvideofilm = link_element.GetAttribute("src").Trim();
                        if (linkvideofilm == null || linkvideofilm == "")
                            goto _next;
                        ShowVLC(linkvideofilm);
                        driver.Quit();
                        driver.Dispose();
                        return;
                    }
                    catch { }
                }
                _next:;
            }
            driver.Quit();
            driver.Dispose();
            ShowThongBao();
        }

        private void dropdown_theloai_onItemSelected(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            dropdown_theloai.NomalColor = Color.FromArgb(36, 129, 77);
            dropdown_theloai.ForeColor = Color.White;
            if (dropdown_theloai.selectedIndex == 0)
            {
                url_origin = "http://www.hdvnn.net/the-loai/hanh-dong/trang-";
                _url = url_origin + numberPage+".html";
            }
            else if (dropdown_theloai.selectedIndex == 1)
            {
                url_origin = "http://www.hdvnn.net/the-loai/hoat-hinh/trang-";
                _url = url_origin + numberPage +".html";
            }
            else if (dropdown_theloai.selectedIndex == 2)
            {
                url_origin = "http://www.hdvnn.net/the-loai/than-thoai/trang-";
                _url = url_origin + numberPage + ".html";
            }
            else if (dropdown_theloai.selectedIndex == 3)
            {
                url_origin = "http://www.hdvnn.net/the-loai/hinh-su/trang-";
                _url = url_origin + numberPage + ".html";
            }
            else if (dropdown_theloai.selectedIndex == 4)
            {
                url_origin = "http://www.hdvnn.net/the-loai/anime/trang-";
                _url = url_origin + numberPage +".html";
            }
            else if (dropdown_theloai.selectedIndex == 5)
            {
                url_origin = "http://www.hdvnn.net/the-loai/phieu-luu/trang-";
                _url = url_origin + numberPage + ".html";
            }
            else if (dropdown_theloai.selectedIndex == 6)
            {
                url_origin = "http://www.hdvnn.net/the-loai/truyen-hinh/trang-";
                _url = url_origin + numberPage + ".html";
            }
            else if (dropdown_theloai.selectedIndex == 7)
            {
                url_origin = "http://www.hdvnn.net/the-loai/hai-huoc/trang-";
                _url = url_origin + numberPage + ".html";
            }
            else if (dropdown_theloai.selectedIndex == 8)
            {
                url_origin = "http://www.hdvnn.net/the-loai/tai-lieu/trang-";
                _url = url_origin + numberPage + ".html";
            }
            else if (dropdown_theloai.selectedIndex == 9)
            {
                url_origin = "http://www.hdvnn.net/the-loai/vien-tuong/trang-";
                _url = url_origin + numberPage + ".html";
            }
            else if (dropdown_theloai.selectedIndex == 10)
            {
                url_origin = "http://www.hdvnn.net/the-loai/chien-tranh/trang-";
                _url = url_origin + numberPage + ".html";
            }
            else if (dropdown_theloai.selectedIndex == 11)
            {
                url_origin = "http://www.hdvnn.net/the-loai/vo-thuat/trang-";
                _url = url_origin + numberPage + ".html";
            }
            else if (dropdown_theloai.selectedIndex == 12)
            {
                url_origin = "http://www.hdvnn.net/the-loai/tinh-cam/trang-";
                _url = url_origin + numberPage + ".html";
            }
            else if (dropdown_theloai.selectedIndex == 13)
            {
                url_origin = "http://www.hdvnn.net/the-loai/kinh-di/trang-";
                _url = url_origin + numberPage + ".html";
            }
            else if (dropdown_theloai.selectedIndex == 14)
            {
                url_origin = "http://www.hdvnn.net/the-loai/co-trang/trang-";
                _url = url_origin + numberPage + ".html";
            }
            LoadFilm(_url);
        }

        private void btn_phimle_Click(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            btn_phimle.Textcolor = Color.White;
            btn_phimle.Normalcolor = Color.FromArgb(36, 129, 77);
            url_origin = "http://www.hdvnn.net/phim-le/trang-";
            _url = url_origin + numberPage+".html";
            LoadFilm(_url);
        }
        private void btn_phimkhac_Click(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            btn_phimkhac.Textcolor = Color.White;
            btn_phimkhac.Normalcolor = Color.FromArgb(36, 129, 77);
            url_origin = "http://www.hdvnn.net/phim-moi/trang-";
            _url = url_origin + numberPage+".html";
            LoadFilm(_url);
        }

        private void btn_chieurap_Click(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            btn_chieurap.Textcolor = Color.White;
            btn_chieurap.Normalcolor = Color.FromArgb(36, 129, 77);
            url_origin = "http://www.hdvnn.net/phim-chieu-rap/trang-";
            _url = url_origin + numberPage+".html";
            LoadFilm(_url);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (_url.IndexOf("/tim-kiem/") != -1)
            {
                _url = "http://www.hdvnn.net/tim-kiem/" + search2 + "/trang-" + (currentPage - 1) + ".html";

                LoadFilm(_url);
            }
            else
            {
                string nextPage_url = url_origin + (currentPage - 1) + ".html" ;
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
            if (_url.IndexOf("/tim-kiem/") != -1)
            {
                _url = "http://www.hdvnn.net/tim-kiem/" + search2 + "/trang-" + (currentPage + 1) + ".html";

                LoadFilm(_url);
            }
            else
            {
                string nextPage_url = url_origin + (currentPage + 1)+".html";
                LoadFilm(nextPage_url);
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_timkiem_Click_1(object sender, EventArgs e)
        {
            ActiveTaskBarFilm();
            string search = tb_timkiem.Text.Trim().ToString();
            if (search != null)
            {
                search2 = search.Replace(" ", "+");

               _url = "http://www.hdvnn.net/tim-kiem/" + search2;

                LoadFilm(_url);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên phim muốn tìm !!");
            }
        }
    }
}
