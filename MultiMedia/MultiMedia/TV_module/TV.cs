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

namespace MultiMedia.TV_module
{
    public partial class TV : UserControl
    {
        public TV()
        {
            InitializeComponent();
            AddPlayPlitst();
        }
        string FindLinkVTC(String url)
        {
            HtmlWeb htmlweb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8
            };
            HtmlAgilityPack.HtmlDocument doc = htmlweb.Load(url);
            string parsedtext = doc.ParsedText;
            String[] a = parsedtext.Split(new string[] { "src: " }, StringSplitOptions.None);
            String[] b = a[3].Split(new string[] { "'" }, StringSplitOptions.None);
            return b[1];
        }
        string[] FindLinkTV(String url)
        {
            HtmlWeb htmlweb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8
            };
            HtmlAgilityPack.HtmlDocument doc = htmlweb.Load(url);
            string parsedtext = doc.ParsedText;
            string[] a = parsedtext.Split(new string[] { "link=['" }, StringSplitOptions.None);
            string[] b = a[1].Split(new string[] { "','" }, StringSplitOptions.None);
            string[] c = b[b.Length - 1].Split(new string[] { "'" }, StringSplitOptions.None);
            b[b.Length - 1] = c[0];
            return b;
           
        }
        void AddPlayPlitst()
        {
           
           
            //VTC
            string url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc1");
            axVLCPlugin21.playlist.add(url);
            url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc4");
            axVLCPlugin21.playlist.add(url);
            url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc7");
            axVLCPlugin21.playlist.add(url);
            url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc8");
            axVLCPlugin21.playlist.add(url);
            url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc9");
            axVLCPlugin21.playlist.add(url);
            url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc10");
            axVLCPlugin21.playlist.add(url);
            url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc11");
            axVLCPlugin21.playlist.add(url);
            url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc14");
            axVLCPlugin21.playlist.add(url);
            url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc16");
            axVLCPlugin21.playlist.add(url);
            //VTV
            axVLCPlugin21.playlist.add("https://hjyjrvmlsk.vcdn.com.vn/hls/elgfjdh/index.m3u8");
            axVLCPlugin21.playlist.add("https://cdn-livestream-live.vtvgiaitri.vn/vtv2.smil/playlist.m3u8");
            axVLCPlugin21.playlist.add("https://hjyjrvmlsk.vcdn.com.vn/hls/idmwifi/index.m3u8");
            axVLCPlugin21.playlist.add("https://hjyjrvmlsk.vcdn.com.vn/hls/hktebdo/index.m3u8");
            axVLCPlugin21.playlist.add("https://hjyjrvmlsk.vcdn.com.vn/hls/ira1wlr/index.m3u8");
            axVLCPlugin21.playlist.add("https://hjyjrvmlsk.vcdn.com.vn/hls/fjg6388/index.m3u8");
            axVLCPlugin21.playlist.add("https://cdn-livestream-live.vtvgiaitri.vn/vtv7.smil/playlist.m3u8");
            axVLCPlugin21.playlist.add("https://cdn-livestream-live.vtvgiaitri.vn/vtv8.smil/playlist.m3u8");
            axVLCPlugin21.playlist.add("https://hjyjrvmlsk.vcdn.com.vn/hls/ig9jpqw/index.m3u8");
            // Truyê`n hi`nh HCTV

            // tv1.axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtvcthuanviet_hls.smil/playlist.m3u8");
            axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtvcphim_hls.smil/playlist.m3u8");
            axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtvcdulich_hls.smil/playlist.m3u8");
            // tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htvc-giadinhhd");
            axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtvcphunu_hls.smil/playlist.m3u8");
            // tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htvc-canhachd");
            axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtv1_hls.smil/playlist.m3u8");
            axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtv2_hls.smil/playlist.m3u8");
            axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtv3_hls.smil/playlist.m3u8");
            axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtv7_hls.smil/playlist.m3u8");
            axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtv9_hls.smil/playlist.m3u8");                     
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=htvc-thuanviet");                    
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=htvc-giadinh");     
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=htvc-canhac");
            //Kệnh đặc sắc
                         
            axVLCPlugin21.playlist.add("http://data.xemtiviso.net/nguon/hpluss.php?id=vinhlong1&token=V91g7SoEiUewzwDGcf6otQ&e=1544206738");
            axVLCPlugin21.playlist.add("http://cdn3.vtcplay.vn:1935/VTC/smil:VinhLong2HD.smil/playlist.m3u8");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=htvc-thethao");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=foxsports ");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet.php?id=disney ");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet.php?id=cartoon ");
            axVLCPlugin21.playlist.add(" http://test.xemtiviso.net/tvnet.php?id=hbo");
            axVLCPlugin21.playlist.add(" http://test.xemtiviso.net/tvnet.php?id=axn");
            // Kênh địa phương
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=binhdinh ");
            axVLCPlugin21.playlist.add(" http://test.xemtiviso.net/tvnet2.php?id=binhphuoc1");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=hatinh ");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=khanhhoa ");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=hue ");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=kiengiang ");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=lamdong ");
            axVLCPlugin21.playlist.add(" http://test.xemtiviso.net/tvnet2.php?id=langson");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=longan ");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=quangnam ");
            axVLCPlugin21.playlist.add(" http://test.xemtiviso.net/tvnet2.php?id=soctrang1");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=tayninh");
            axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=cantho ");
            axVLCPlugin21.playlist.add(" http://test.xemtiviso.net/tvnet2.php?id=travinh");
                    //  LoadLink("");
        }

        private void vtc1_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(0);
        }

        private void vtc4_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(1);
        }

        private void vtc7_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(2);
        }

        private void vtc8_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(3);
        }

        private void vtc9_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(4);
        }

        private void vtc10_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(5);
        }

        private void vtc11_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(6);
        }

        private void vtc14_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(7);
        }

        private void vtc16_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(8);
        }

        private void vtv1_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(9);
        }

        private void vtv2_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(10);
        }

        private void vtv3_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(11);
        }

        private void vtv4_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(12);
        }

        private void vtv5_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(13);
        }

        private void vtv6_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(14);
        }

        private void vtv7_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(15);
        }

        private void vtv8_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(16);
        }

        private void vtv9_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(17);
        }

        private void phimhd_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(18);
        }



        private void dulich_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(19);
        }


        private void phunu_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(20);
        }


        private void htv1_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(21);
        }

        private void htv2_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(22);
        }

        private void htv3_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(23);
        }

        private void htv7hd_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(24);
        }

        private void htv9hd_Click(object sender, EventArgs e)
        {
            fpnlLink.Controls.Clear();
            axVLCPlugin21.playlist.playItem(25);
        }
        //static string[] linktv;
        //int tag ;
        //private void btn_Click(object sender, EventArgs e)
        //{
        //    axVLCPlugin21.playlist.stop();
        //    //string[] a = FindLinkTV("http://data.xemtiviso.com/live/diaphuong/thvl1.php");
        //    Button m = sender as Button;
        //    axVLCPlugin21.playlist.items.remove(tag);
        //    axVLCPlugin21.playlist.add(linktv[Convert.ToInt32(m.Tag)]);
            
        //    axVLCPlugin21.playlist.playItem(tag);

        //}
        //void LoadLink(string url)
        //{
        //    fpnlLink.Controls.Clear();
        //    axVLCPlugin21.playlist.stop();
        //    //  Array.Clear(linktv, 0, 0);
        //    linktv = FindLinkTV(url);

        //    for (int i = 0; i < linktv.Length; i++)
        //    {
        //        Button btn = new Button();

        //        btn.BackColor = Color.Red;
        //        btn.Text = "Link" + i.ToString();
        //        btn.Tag = i;
        //        btn.Click += new EventHandler(btn_Click);

        //        fpnlLink.Controls.Add(btn);


        //    }
        //}
       
        private void thuanviethd_Click(object sender, EventArgs e)
        {

            //LoadLink("http://data.xemtiviso.com/live/htv/htvc-thuanviethd.php");
            axVLCPlugin21.playlist.playItem(26);
        }
        private void giadinh_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(27);
            //LoadLink("http://data.xemtiviso.com/live/htv/htvc-giadinh.php");
        }

        private void nhac_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(28);
            //LoadLink("http://data.xemtiviso.com/live/htv/htvc-canhac.php");
        }
       
        
      
        private void vinhlong1_Click(object sender, EventArgs e)
        {

            axVLCPlugin21.playlist.playItem(29);
           ////LoadLink("http://data.xemtiviso.com/live/diaphuong/thvl1.php");
            //    axVLCPlugin21.playlist.add(a[0]);

            //    axVLCPlugin21.playlist.playItem(26);


            //if (axVLCPlugin21.playlist.isPlaying == false)
            //{

            //    for (int i = 1; i < a.Length; i++)
            //    {


            //            axVLCPlugin21.playlist.add(a[i]);
            //            axVLCPlugin21.playlist.playItem(26);

            //        if (axVLCPlugin21.playlist.isPlaying == true)
            //        {
            //            break;
            //        }
            //        axVLCPlugin21.playlist.items.remove(26);
            //    }
            //}
            //foreach (string item in a)
            //{
            //    axVLCPlugin21.playlist.add(item);
            //    axVLCPlugin21.playlist.playItem(26);
            //    if (axVLCPlugin21.playlist.isPlaying == true)
            //    {
            //        break;
            //    }

            //    else axVLCPlugin21.playlist.items.remove(26);

            //}
        }

        private void vinhlong2_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(30);
        }

        private void htvthethao_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(31);
        }

        private void fox_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(32);
        }

        private void disney_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(33);
        }

        private void cartoon_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(34);
        }

        private void HBO_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(35);
        }

        private void AXN_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(36);
        }

        private void binhdinh_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(37);
        }

        private void binhphuoc1_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(38);
        }

        private void hatinh_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(39);
        }

        private void khanhhoa_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(40);
        }

        private void hue_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(41);
        }

        private void kiengiang1_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(42);
        }

        private void lamdong_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(43);
        }

        private void langson_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(44);
        }

        private void longan_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(45);
        }

        private void quangnam_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(46);
        }

        private void soctrang1_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(47);
        }

        private void tayninh_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(48);
        }

        private void tpcantho_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(49);
        }

        private void travinh_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(50);
        }
    }
}