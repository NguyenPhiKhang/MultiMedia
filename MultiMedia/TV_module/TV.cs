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
        List<string> listLink = new List<string>();
        List<Bunifu.Framework.UI.BunifuImageButton> imgButton = new List<Bunifu.Framework.UI.BunifuImageButton>();
        //string url;
        //BackgroundWorker bw;
        public TV()
        {
            InitializeComponent();
            //AddPlayPlitst();
            AddListLink();
            AddChannel();
            for(int i=0;i<listLink.Count;i++)
            {
                imgButton[i].Tag = i.ToString();
                imgButton[i].Click += TV_Click;
            }
            
        }

        private void TV_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuImageButton a = sender as Bunifu.Framework.UI.BunifuImageButton;
            int b = Convert.ToInt32(a.Tag.ToString());
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (_s, _e) =>
              {
                  Invoke(new Action(
                  () =>
                  {
                      Movie_module.FrmVLC frmVlc = new Movie_module.FrmVLC(listLink[b]);
                      frmVlc.lbl_name_video.Text = "Bạn đang xem kênh " + imgButton[b].Name.ToString();
                          //frmVlc.time_movie.Enabled = false;
                          //frmVlc.time_movie.MaximumValue = 100;
                          frmVlc.btn_Pause.Visible = false;
                      frmVlc.btn_play.Visible = false;
                      frmVlc.btn_Stop.Visible = false;
                      frmVlc.btn_play_vlc.Visible = false;
                      frmVlc.Show();
                  }));

              };
            bw.RunWorkerAsync();
        }
        void AddListLink()
        {
            listLink.Add("https://hjyjrvmlsk.vcdn.com.vn/hls/elgfjdh/index.m3u8"); //vtv1
            listLink.Add("https://cdn-livestream-live.vtvgiaitri.vn/vtv2.smil/playlist.m3u8");//vtv2
            listLink.Add("https://hjyjrvmlsk.vcdn.com.vn/hls/idmwifi/index.m3u8");//vtv3
            listLink.Add("https://hjyjrvmlsk.vcdn.com.vn/hls/hktebdo/index.m3u8");//vtv4
            listLink.Add("https://hjyjrvmlsk.vcdn.com.vn/hls/ira1wlr/index.m3u8");//vtv5
            listLink.Add("https://hjyjrvmlsk.vcdn.com.vn/hls/fjg6388/index.m3u8");//vtv6
            listLink.Add("https://cdn-livestream-live.vtvgiaitri.vn/vtv7.smil/playlist.m3u8");//vtv7
            listLink.Add("https://cdn-livestream-live.vtvgiaitri.vn/vtv8.smil/playlist.m3u8");//vtv8
            listLink.Add("https://hjyjrvmlsk.vcdn.com.vn/hls/ig9jpqw/index.m3u8");//vtv9
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=khac-antv");//antv
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=khac-ttxvn");//ttxvn
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=khac-qpvn");//qpvn
            listLink.Add("https://sg.tvmienphi.net/live/vchannel6_low.m3u8");//echannel
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc1");//vtc1
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc2");//vtc2
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc3");//vtc3
            //url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc4");
            //listLink.Add(url);//vtc4
            //url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc5");
            //listLink.Add(url);//vtc5
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc6");//vtc6
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc7");//vtc7
            //url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc8");
            //listLink.Add(url);//vtc8
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc9");//vtc9
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc10");//vtc10
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc11");//vtc11
            //url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc13");
            //listLink.Add(url);//vtc13
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc14");//vtc14
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc16");//vtc16
            listLink.Add(/* http://cdn3.vtcplay.vn:1935/VTC/smil:VinhLong1HD.smil/playlist.m3u8 */"http://test.xemtiviso.net/tvnet2.php?id=diaphuong-vinhlong1");//thvl1
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-vinhlong2");//thvl2
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-hanoi1");//hanoi1
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-hanoi2");//hanoi2
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-dongnai1");//dongnai1
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-dongnai2");//dongnai2
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-binhduong1");//binhduong1
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=binhduong2");//binhduong2
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-binhduong4");//binhduong4
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-danang1");//danang1
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-danang2");//danang2
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-binhphuoc1");//binhphuoc
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-dongthap");//dongthap
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-haugiang");//haugiang
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-longan");//longan
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-laocai");//laocai
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-cantho");//cantho
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-tiengiang");//tiengiang
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-binhthuan");//binhthuan
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-binhdinh");//binhdinh
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=vinhphuc");//vinhphuc
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-tuyenquang");//tuyenquang
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-tayninh");//tay ninh
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-thainguyen1");//thainguyen
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-baclieu");//baclieu
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-hue");//hue
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-phutho");//phutho
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-langson");//langson
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-quangtri");//quangtri
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-lamdong");//lamdong
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-ninhthuan");//ninhthuan
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-haiphong");//haiphong
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-khanhhoa");//khanh hoa
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-thaibinh");//thaibinh
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-hoabinh");//hoabinh
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-nghean");//nghean
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-kiengiang");//kiengiang
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-camau");//camau
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-ninhbinh");//ninhbinh
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-gialai");//gialai
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-thanhhoa");//thanhhoa
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-hanam");//hanam
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-quangnam");//quangnam
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=hatinh");//hatinh
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-quangbinh");//quangbinh
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-bacgiang");//bacgiang
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-hagiang");//hagiang
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-yenbai");//yenbai
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-angiang1");//angiang
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-quangninh1");//quangninh
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-travinh");//travinh
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-quangngai");//quangngai
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-dienbien");//dienbien
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-bacninh");//bacninh
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=diaphuong-kontum");//kontum
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htvc-htv1");//htv1
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htvc-htv2");//htv2
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htvc-htv3");//htv3
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htvc-htv4");//htv4
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htvc-htv7");//htv7
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htvc-htv9");//htv9
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htvc-thethao");//htvthethao
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htv-htvc-phim");//htvphim
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htvc-thuanviet");//thuanviet
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htvc-giadinh");//giadinh
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htvc-phunu");//phunu
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htv-htvc-canhac");//canhac
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=htvc-dulich");//dulich
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=quocte-hbo");//HBO
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=quocte-starmovies");//FOXMOVIES
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=quocte-cinemax");//MAX
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=quocte-axn");//AXN
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=quocte-mtv");//MTV
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=quocte-disney");//disney
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=quocte-starworld");//FOX life
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=foxsports");//FOX sports
            listLink.Add("http://test.xemtiviso.net/tvnet2.php?id=quocte-cartoon"); //cartoon network

        }

        void AddChannel()
        {
            imgButton.Add(vtv1);
            imgButton.Add(vtv2);
            imgButton.Add(vtv3);
            imgButton.Add(vtv4);
            imgButton.Add(vtv5);
            imgButton.Add(vtv6);
            imgButton.Add(vtv7);
            imgButton.Add(vtv8);
            imgButton.Add(vtv9);
            imgButton.Add(antv);
            imgButton.Add(ttxvn);
            imgButton.Add(qpvn);
            imgButton.Add(echannel);
            imgButton.Add(vtc1);
            imgButton.Add(vtc2);
            imgButton.Add(vtc3);
            //imgButton.Add(vtc4);
            //imgButton.Add(vtc5);
            imgButton.Add(vtc6);
            imgButton.Add(vtc7);
            //imgButton.Add(vtc8);
            imgButton.Add(vtc9);
            imgButton.Add(vtc10);
            imgButton.Add(vtc11);
            //imgButton.Add(vtc13);
            imgButton.Add(vtc14);
            imgButton.Add(vtc16);
            imgButton.Add(thvl1);
            imgButton.Add(thvl2);
            imgButton.Add(hn1);
            imgButton.Add(hn2);
            imgButton.Add(dn1);
            imgButton.Add(dn2);
            imgButton.Add(bd1);
            imgButton.Add(bd2);
            imgButton.Add(bd4);
            imgButton.Add(danang1);
            imgButton.Add(danang2);
            imgButton.Add(binhphuoc);
            imgButton.Add(dongthap);
            imgButton.Add(haugiang);
            imgButton.Add(longan);
            imgButton.Add(laocai);
            imgButton.Add(cantho);
            imgButton.Add(tiengiang);
            imgButton.Add(binhthuan);
            imgButton.Add(binhdinh);
            imgButton.Add(vinhphuc);
            imgButton.Add(tuyenquang);
            imgButton.Add(tayninh);
            imgButton.Add(thainguyen);
            imgButton.Add(baclieu);
            imgButton.Add(hue);
            imgButton.Add(phutho);
            imgButton.Add(langson);
            imgButton.Add(quangtri);
            imgButton.Add(lamdong);
            imgButton.Add(ninhthuan);
            imgButton.Add(haiphong);
            imgButton.Add(khanhhoa);
            imgButton.Add(thaibinh);
            imgButton.Add(hoabinh);
            imgButton.Add(nghean);
            imgButton.Add(kiengiang);
            imgButton.Add(camau);
            imgButton.Add(ninhbinh);
            imgButton.Add(gialai);
            imgButton.Add(thanhhoa);
            imgButton.Add(hanam);
            imgButton.Add(quangnam);
            imgButton.Add(hatinh);
            imgButton.Add(quangbinh);
            imgButton.Add(bacgiang);
            imgButton.Add(hagiang);
            imgButton.Add(yenbai);
            imgButton.Add(angiang);
            imgButton.Add(quangninh);
            imgButton.Add(travinh);
            imgButton.Add(quangngai);
            imgButton.Add(dienbien);
            imgButton.Add(bacninh);
            imgButton.Add(kontum);
            imgButton.Add(htv1);
            imgButton.Add(htv2);
            imgButton.Add(htv3);
            imgButton.Add(htv4);
            imgButton.Add(htv7);
            imgButton.Add(htv9);
            imgButton.Add(htv_thethao);
            imgButton.Add(htv_phim);
            imgButton.Add(thuanviet);
            imgButton.Add(htv_giadinh);
            imgButton.Add(htv_phunu);
            imgButton.Add(htv_canhac);
            imgButton.Add(htv_dulich);
            imgButton.Add(hbo);
            imgButton.Add(starmovies);
            imgButton.Add(cinemax);
            imgButton.Add(axn);
            imgButton.Add(mtv);
            imgButton.Add(disney);
            imgButton.Add(starworld);
            imgButton.Add(foxsports);
            imgButton.Add(cartoon);
        }
        //string FindLinkVTC(String url)
        //{
        //    try
        //    {
        //        HtmlWeb htmlweb = new HtmlWeb()
        //        {
        //            AutoDetectEncoding = false,
        //            OverrideEncoding = Encoding.UTF8
        //        };
        //        HtmlAgilityPack.HtmlDocument doc = htmlweb.Load(url);
        //        string parsedtext = doc.ParsedText;
        //        String[] a = parsedtext.Split(new string[] { "src: " }, StringSplitOptions.None);
        //        String[] b = a[6].Split(new string[] { "'" }, StringSplitOptions.None);
        //        return b[1];
        //    }
        //    catch { return "0"; };
        //}
        //string[] FindLinkTV(String url)
        //{
        //    HtmlWeb htmlweb = new HtmlWeb()
        //    {
        //        AutoDetectEncoding = false,
        //        OverrideEncoding = Encoding.UTF8
        //    };
        //    HtmlAgilityPack.HtmlDocument doc = htmlweb.Load(url);
        //    string parsedtext = doc.ParsedText;
        //    string[] a = parsedtext.Split(new string[] { "link=['" }, StringSplitOptions.None);
        //    string[] b = a[1].Split(new string[] { "','" }, StringSplitOptions.None);
        //    string[] c = b[b.Length - 1].Split(new string[] { "'" }, StringSplitOptions.None);
        //    b[b.Length - 1] = c[0];
        //    return b;
           
        //}
        //void ShowVLC(string url)
        //{
        //    bw = new BackgroundWorker();
        //    bw.DoWork += (_s, _e) => Thread.Sleep(500);
        //    bw.RunWorkerCompleted += (_s, _e) =>
        //    {
        //        frmVlc = new Movie_module.FrmVLC(url);
        //        frmVlc.Show();
        //    };
        //    bw.RunWorkerAsync();
        //}
        //void Check_Isplaying()
        //{
        //    bw = new BackgroundWorker();
        //    bw.DoWork += (_s, _e) => Thread.Sleep(5000);
        //    bw.RunWorkerCompleted += (_s, _e) =>
        //    {
        //        //if (bw.IsBusy == true) { bw1.Dispose(); return; }
        //        try
        //        {
        //            if (frmVlc.axVLCPlugin21.playlist.isPlaying == false)
        //            {
        //                //axVLCPlugin21.playlist.stop();
        //                Movie_module.ThongBao tb = new Movie_module.ThongBao();
        //                tb.ShowDialog();
        //            }
        //        }
        //        catch
        //        {
        //            MessageBox.Show("nhấn từ từ");
        //        };
        //    };
        //    bw.RunWorkerAsync();
        //}




























        //void AddPlayPlitst()
        //{
        //    //VTC
        //    string url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc1");
        //    axVLCPlugin21.playlist.add(url);
        //    url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc4");
        //    axVLCPlugin21.playlist.add(url);
        //    url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc7");
        //    axVLCPlugin21.playlist.add(url);
        //    url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc8");
        //    axVLCPlugin21.playlist.add(url);
        //    url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc9");
        //    axVLCPlugin21.playlist.add(url);
        //    url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc10");
        //    axVLCPlugin21.playlist.add(url);
        //    url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc11");
        //    axVLCPlugin21.playlist.add(url);
        //    url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc14");
        //    axVLCPlugin21.playlist.add(url);
        //    url = FindLinkVTC("https://www.vtc.gov.vn/kenh/vtc16");
        //    axVLCPlugin21.playlist.add(url);
        //    //VTV
        //    axVLCPlugin21.playlist.add("https://hjyjrvmlsk.vcdn.com.vn/hls/elgfjdh/index.m3u8");
        //    axVLCPlugin21.playlist.add("https://cdn-livestream-live.vtvgiaitri.vn/vtv2.smil/playlist.m3u8");
        //    axVLCPlugin21.playlist.add("https://hjyjrvmlsk.vcdn.com.vn/hls/idmwifi/index.m3u8");
        //    axVLCPlugin21.playlist.add("https://hjyjrvmlsk.vcdn.com.vn/hls/hktebdo/index.m3u8");
        //    axVLCPlugin21.playlist.add("https://hjyjrvmlsk.vcdn.com.vn/hls/ira1wlr/index.m3u8");
        //    axVLCPlugin21.playlist.add("https://hjyjrvmlsk.vcdn.com.vn/hls/fjg6388/index.m3u8");
        //    axVLCPlugin21.playlist.add("https://cdn-livestream-live.vtvgiaitri.vn/vtv7.smil/playlist.m3u8");
        //    axVLCPlugin21.playlist.add("https://cdn-livestream-live.vtvgiaitri.vn/vtv8.smil/playlist.m3u8");
        //    axVLCPlugin21.playlist.add("https://hjyjrvmlsk.vcdn.com.vn/hls/ig9jpqw/index.m3u8");
        //    // Truyê`n hi`nh HCTV

        //    // tv1.axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtvcthuanviet_hls.smil/playlist.m3u8");
        //    axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtvcphim_hls.smil/playlist.m3u8");
        //    axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtvcdulich_hls.smil/playlist.m3u8");
        //    // tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htvc-giadinhhd");
        //    axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtvcphunu_hls.smil/playlist.m3u8");
        //    // tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htvc-canhachd");
        //    axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtv1_hls.smil/playlist.m3u8");
        //    axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtv2_hls.smil/playlist.m3u8");
        //    axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtv3_hls.smil/playlist.m3u8");
        //    axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtv7_hls.smil/playlist.m3u8");
        //    axVLCPlugin21.playlist.add("http://live.cdn.mobifonetv.vn/motv/myhtv9_hls.smil/playlist.m3u8");                     
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=htv-htvc-thuanviet");                    
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=htvc-giadinh");     
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=htvc-canhac");
        //    //Kệnh đặc sắc

        //    axVLCPlugin21.playlist.add("http://cdn3.vtcplay.vn:1935/VTC/smil:VinhLong1HD.smil/playlist.m3u8");
        //    axVLCPlugin21.playlist.add("http://cdn3.vtcplay.vn:1935/VTC/smil:VinhLong2HD.smil/playlist.m3u8");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=htvc-thethao");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=foxsports ");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet.php?id=disney ");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet.php?id=cartoon ");
        //    axVLCPlugin21.playlist.add(" http://test.xemtiviso.net/tvnet.php?id=hbo");
        //    axVLCPlugin21.playlist.add(" http://test.xemtiviso.net/tvnet.php?id=axn");
        //    // Kênh địa phương
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=binhdinh ");
        //    axVLCPlugin21.playlist.add(" http://test.xemtiviso.net/tvnet2.php?id=binhphuoc1");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=hatinh ");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=khanhhoa ");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=hue ");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=kiengiang ");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=lamdong ");
        //    axVLCPlugin21.playlist.add(" http://test.xemtiviso.net/tvnet2.php?id=langson");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=longan ");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=quangnam ");
        //    axVLCPlugin21.playlist.add(" http://test.xemtiviso.net/tvnet2.php?id=soctrang1");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=tayninh");
        //    axVLCPlugin21.playlist.add("http://test.xemtiviso.net/tvnet2.php?id=cantho ");
        //    axVLCPlugin21.playlist.add(" http://test.xemtiviso.net/tvnet2.php?id=travinh");
        //            //  LoadLink("");
        //}


        //BackgroundWorker bw1;

        //void threadlink()
        //{
        //    Thread thread = new Thread(() =>
        //    {
        //        if (axVLCPlugin21.playlist.isPlaying == false)
        //        {
        //            axVLCPlugin21.playlist.stop();
        //            Invoke(new Action(
        //            () =>
        //            {
        //                // MessageBox.Show("Error");
        //                Movie_module.ThongBao tb = new Movie_module.ThongBao();
        //                tb.ShowDialog();
        //            }));
        //        }
        //    });
        //    Thread.Sleep(10000);
        //    thread.IsBackground = true;
        //    thread.Start();


        //}

        //private void vtc1_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    //axVLCPlugin21.playlist.playItem(0);
        //    url = "http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc1";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtc4_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc4";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtc7_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc7";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtc8_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc8";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtc9_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc9";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtc10_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc10";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtc11_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc11";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtc14_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc14";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtc16_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "http://test.xemtiviso.net/tvnet2.php?id=vtc-vtc16";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtv1_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "https://hjyjrvmlsk.vcdn.com.vn/hls/elgfjdh/index.m3u8";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtv2_Click(object sender, EventArgs e)
        //{
        //    // axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "https://cdn-livestream-live.vtvgiaitri.vn/vtv2.smil/playlist.m3u8";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtv3_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "https://hjyjrvmlsk.vcdn.com.vn/hls/idmwifi/index.m3u8";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtv4_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "https://hjyjrvmlsk.vcdn.com.vn/hls/hktebdo/index.m3u8";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}
        //private void vtv5_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "https://hjyjrvmlsk.vcdn.com.vn/hls/ira1wlr/index.m3u8";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtv6_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "https://hjyjrvmlsk.vcdn.com.vn/hls/fjg6388/index.m3u8";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtv7_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "https://cdn-livestream-live.vtvgiaitri.vn/vtv7.smil/playlist.m3u8";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtv8_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    url = "https://cdn-livestream-live.vtvgiaitri.vn/vtv8.smil/playlist.m3u8";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void vtv9_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    //axVLCPlugin21.playlist.playItem(17);
        //    //Thread thread = new Thread(()=> { ShowVLC("https://hjyjrvmlsk.vcdn.com.vn/hls/ig9jpqw/index.m3u8"); });
        //    //Thread.Sleep(500);
        //    //thread.IsBackground = true;
        //    //thread.Start();
        //    url = "https://hjyjrvmlsk.vcdn.com.vn/hls/ig9jpqw/index.m3u8";
        //    ShowVLC(url);
        //    Check_Isplaying();
        //}

        //private void phimhd_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    //axVLCPlugin21.playlist.playItem(18);
        //    //threadlink();
        //}



        //private void dulich_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    //axVLCPlugin21.playlist.playItem(19);
        //    //threadlink();
        //}


        //private void phunu_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    //axVLCPlugin21.playlist.playItem(20);
        //    //threadlink();
        //}


        //private void htv1_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    //axVLCPlugin21.playlist.playItem(21);
        //    //threadlink();
        //}

        //private void htv2_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    //axVLCPlugin21.playlist.playItem(22);
        //    //threadlink();
        //}

        //private void htv3_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //   // axVLCPlugin21.playlist.playItem(23);
        //    //threadlink();
        //}

        //private void htv7hd_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    //axVLCPlugin21.playlist.playItem(24);
        //    //threadlink();
        //}

        //private void htv9hd_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //fpnlLink.Controls.Clear();
        //    //axVLCPlugin21.playlist.playItem(25);
        //    //threadlink();
        //}
        ////static string[] linktv;
        ////int tag ;
        ////private void btn_Click(object sender, EventArgs e)
        ////{
        ////    axVLCPlugin21.playlist.stop();
        ////    //string[] a = FindLinkTV("http://data.xemtiviso.com/live/diaphuong/thvl1.php");
        ////    Button m = sender as Button;
        ////    axVLCPlugin21.playlist.items.remove(tag);
        ////    axVLCPlugin21.playlist.add(linktv[Convert.ToInt32(m.Tag)]);

        ////    axVLCPlugin21.playlist.playItem(tag);

        ////}
        ////void LoadLink(string url)
        ////{
        ////    fpnlLink.Controls.Clear();
        ////    axVLCPlugin21.playlist.stop();
        ////    //  Array.Clear(linktv, 0, 0);
        ////    linktv = FindLinkTV(url);

        ////    for (int i = 0; i < linktv.Length; i++)
        ////    {
        ////        Button btn = new Button();

        ////        btn.BackColor = Color.Red;
        ////        btn.Text = "Link" + i.ToString();
        ////        btn.Tag = i;
        ////        btn.Click += new EventHandler(btn_Click);

        ////        fpnlLink.Controls.Add(btn);


        ////    }
        ////}

        //private void thuanviethd_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //LoadLink("http://data.xemtiviso.com/live/htv/htvc-thuanviethd.php");
        //    ///axVLCPlugin21.playlist.playItem(26);
        //    //threadlink();
        //}
        //private void giadinh_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    ///axVLCPlugin21.playlist.playItem(27);
        //    //threadlink();
        //    //LoadLink("http://data.xemtiviso.com/live/htv/htvc-giadinh.php");
        //}

        //private void nhac_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(28);
        //    //threadlink();
        //    //LoadLink("http://data.xemtiviso.com/live/htv/htvc-canhac.php");
        //}



        //private void vinhlong1_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(29);
        //    //threadlink();
        //    ////LoadLink("http://data.xemtiviso.com/live/diaphuong/thvl1.php");
        //    //    axVLCPlugin21.playlist.add(a[0]);

        //    //    axVLCPlugin21.playlist.playItem(26);


        //    //if (axVLCPlugin21.playlist.isPlaying == false)
        //    //{

        //    //    for (int i = 1; i < a.Length; i++)
        //    //    {


        //    //            axVLCPlugin21.playlist.add(a[i]);
        //    //            axVLCPlugin21.playlist.playItem(26);

        //    //        if (axVLCPlugin21.playlist.isPlaying == true)
        //    //        {
        //    //            break;
        //    //        }
        //    //        axVLCPlugin21.playlist.items.remove(26);
        //    //    }
        //    //}
        //    //foreach (string item in a)
        //    //{
        //    //    axVLCPlugin21.playlist.add(item);
        //    //    axVLCPlugin21.playlist.playItem(26);
        //    //    if (axVLCPlugin21.playlist.isPlaying == true)
        //    //    {
        //    //        break;
        //    //    }

        //    //    else axVLCPlugin21.playlist.items.remove(26);

        //    //}
        //}

        //private void vinhlong2_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(30);
        //    //threadlink();
        //}

        //private void htvthethao_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(31);
        //    //threadlink();
        //}

        //private void fox_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(32);
        //    //threadlink();
        //}

        //private void disney_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(33);
        //    //threadlink();
        //}

        //private void cartoon_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(34);
        //    //threadlink();
        //}

        //private void HBO_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(35);
        //    //threadlink();
        //}

        //private void AXN_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(36);
        //    //threadlink();
        //}

        //private void binhdinh_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(37);
        //    //threadlink();
        //}

        //private void binhphuoc1_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(38);
        //    //threadlink();
        //}

        //private void hatinh_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(39);
        //    //threadlink();
        //}

        //private void khanhhoa_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(40);
        //    //threadlink();
        //}

        //private void hue_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(41);
        //    //threadlink();
        //}

        //private void kiengiang1_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(42);
        //    //threadlink();
        //}

        //private void lamdong_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(43);
        //    //threadlink();
        //}

        //private void langson_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(44);
        //    //threadlink();
        //}

        //private void longan_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //   // axVLCPlugin21.playlist.playItem(45);
        //    //threadlink();
        //}

        //private void quangnam_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(46);
        //    //threadlink();
        //}

        //private void soctrang1_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(47);
        //    //threadlink();
        //}

        //private void tayninh_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(48);
        //    //threadlink();
        //}

        //private void tpcantho_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(49);
        //    //threadlink();
        //}

        //private void travinh_Click(object sender, EventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    //axVLCPlugin21.playlist.playItem(50);
        //    //threadlink();
        //}

    }
}