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

namespace MultiMedia.Movie_module
{
    public partial class Movie : UserControl
    {
        public static String url, url_origin, search2;
        public static int currentPage, MaxPage;
        public static bool isPlay = false;

        public int numberPage = 1;
        public int numberFilm;
        public String keyword = "keyword";
        item_movie item_Movie;
        List<item_movie> list_itemmovies = new List<item_movie>();
        List<String> detail = new List<string>();
        List<String> avatar = new List<string>();
        List<String> name = new List<string>();
        List<String> realname = new List<string>();
        List<String> url_first = new List<string>();

        public Movie()
        {
            InitializeComponent();
            //url_origin = "http://phimvnz.com/the-loai/chieu-rap?page=";
            //url = url_origin + numberPage;
            //LoadFilm(url);
            btn_back.Visible = false;
        }


        public void LoadFilm(String url)
        {
            while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);
            try
            {
                list_itemmovies.Clear();
                detail.Clear();
                realname.Clear();
                avatar.Clear();
                name.Clear();
                url_first.Clear();

                HtmlWeb htmlWeb = new HtmlWeb()
                {
                    AutoDetectEncoding = false,
                    OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
                };
                htmlWeb.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1";
                HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(url);
                //Lay so luong trang phim
                HtmlNode Soluongphim = document.DocumentNode.SelectSingleNode("//div[@class='page-navigation']/span");
                try
                {
                    currentPage = Convert.ToInt32(Soluongphim.SelectSingleNode(@"a[@class='item current']").InnerText);
                    MaxPage = Convert.ToInt32(Soluongphim.SelectSingleNode(@"a[last()-1]").InnerText);
                }
                catch
                {
                    currentPage = MaxPage = 1;
                }


                lbl_sotrang.Text = currentPage + " / " + MaxPage;
                if (currentPage <= 1)
                {
                    btn_back.Visible = false;
                    btn_forward.Visible = true;
                }
                else if (currentPage >= MaxPage)
                {
                    btn_back.Visible = true;
                    btn_forward.Visible = false;
                }
                else
                {
                    btn_back.Visible = true;
                    btn_forward.Visible = true;
                }

                //Lay so luong phim trong trang dau tien
                HtmlNode list_film = document.DocumentNode.SelectSingleNode("//ul[@class='list-film']");
                HtmlNodeCollection listfilm_collection = list_film.SelectNodes(@"li");

                foreach (var n in listfilm_collection)
                {
                    String name_film = n.SelectSingleNode("div[@class='name']/h4/a").InnerText;
                    String detail_film = n.SelectSingleNode("div[@class='poster']/div").InnerText.Trim();
                    String avatar_film = n.SelectSingleNode("div[@class='poster']/a/img").Attributes["src"].Value;
                    String realname_film = n.SelectSingleNode("div[@class='name']/dfn").InnerText;
                    String url_film = n.SelectSingleNode("div[@class='poster']/a").Attributes["href"].Value + "/xem-phim.html";

                    detail.Add(detail_film);
                    realname.Add(realname_film);
                    name.Add(name_film);
                    avatar.Add(avatar_film);
                    url_first.Add(url_film);
                }
                numberFilm = listfilm_collection.Count;

                //Hiển thị danh sách phim 
                for (int i = 0; i < numberFilm; i++)
                {
                    item_Movie = new item_movie();
                    item_Movie.Name = "movie" + i;
                    item_Movie.Tag = i.ToString();

                    item_Movie.lbl_name.Text = name[i];
                    item_Movie.lbl_detail.Text = detail[i];
                    item_Movie.lbl_realname.Text = realname[i];
                    item_Movie.lbl_url.Text = url_first[i];

                    item_Movie.btn_avatar.ImageLocation = avatar[i];
                    item_Movie.btn_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    item_Movie.btn_avatar.Tag = i.ToString();
                    item_Movie.btn_avatar.Click += btnAvatar_Click;


                    flowLayoutPanel1.Controls.Add(item_Movie);

                    list_itemmovies.Add(item_Movie);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Không có phim !!");
            }
        }

        void btnAvatar_Click(object sender, EventArgs e)
        {
            //Lấy vị trí film trong list            
            Bunifu.Framework.UI.BunifuImageButton imageButton = sender as Bunifu.Framework.UI.BunifuImageButton;
            int id = Convert.ToInt32(imageButton.Tag.ToString());
            item_movie film = list_itemmovies[id];

            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
            };
            htmlWeb.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1";
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(film.lbl_url.Text.ToString());
            String text = document.ParsedText;
            String[] arr = text.Split((new String[] { "src" }), StringSplitOptions.None);
            String[] arr1 = arr[9].Split(new char[] { '"', '"' });
            String url_origin1 = arr1[1];
            String url_origin2 = url_origin1.Replace(@"'", "");
            String link2 = url_origin2.Replace("+", "");
            String link3 = link2.Replace(" ", "");

            HtmlAgilityPack.HtmlDocument document2 = htmlWeb.Load(link3);
            String text2 = document2.ParsedText;
            String[] arr2 = text2.Split(new char[] { '"', '"' });
            String link1 = arr2[27].Replace(@"\", "");
            //String link2 = arr2[33].Replace(@"\","");
            //String link3 = arr2[45].Replace(@"\","");

            String[] url_origin3 = new string[] { link1 };

            Movie_module.FrmVLC frmVLC = new Movie_module.FrmVLC(url_origin3[0]);
            frmVLC.StartPosition = FormStartPosition.CenterScreen;
            frmVLC.btn_down.Visible = true;
            frmVLC.Show();
        }

        private void dropdown_theloai_onItemSelected(object sender, EventArgs e)
        {
            if (dropdown_theloai.selectedIndex == 0)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-truyen-hinh?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 1)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-kiem-hiep?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 2)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-hanh-dong?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 3)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-vo-thuat?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 4)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-tam-ly?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 5)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-hai-huoc?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 6)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-hoat-hinh?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 7)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-phieu-luu?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 8)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-kinh-di?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 9)
            {
                url = "http://www.vtv16.com/the-loai/phim-hinh-su?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 10)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-chien-tranh?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 11)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-than-thoai?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 12)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-vien-tuong?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 13)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-co-trang?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 14)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-am-nhac?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 15)
            {
                url_origin = "http://www.vtv16.com/the-loai/phim-anime?page=";
                url = url_origin + numberPage;
            }
            LoadFilm(url);
        }

        private void btn_phimle_Click(object sender, EventArgs e)
        {
            url_origin = "http://www.vtv16.com/danh-sach/phim-le?page=";
            url = url_origin + numberPage;
            LoadFilm(url);
        }

        private void btn_phimmoi_Click(object sender, EventArgs e)
        {
            url_origin = "http://www.vtv16.com/danh-sach/phim-moi?page=";
            url = url_origin + numberPage;
            LoadFilm(url);
        }

        private void btn_xemnhieu_Click(object sender, EventArgs e)
        {
            url_origin = "http://www.vtv16.com/danh-sach/phim-chieu-rap?page=";
            url = url_origin + numberPage;
            LoadFilm(url);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (url.IndexOf("tim-kiem-phim") != -1)
            {
                url = "http://www.vtv16.com/tim-kiem-phim/" + search2 + "?page=2" + (currentPage - 1);

                LoadFilm(url);
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

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if (url.IndexOf("tim-kiem-phim") != -1)
            {
                url = "http://www.vtv16.com/tim-kiem-phim/" + search2 + "?page=2" + (currentPage + 1);

                LoadFilm(url);
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
            String search = tb_timkiem.Text.ToString();
            if (search != null)
            {
                search2 = search.Replace(" ", "-");

                url = "http://www.vtv16.com/tim-kiem-phim/" + search2;

                LoadFilm(url);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên phim muốn tìm !!");
            }
        }
    }
}
