using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VideoLibrary;
using YoutubeSearch;
using System.Net;
using System.Threading;

namespace MultiMedia.Youtube_module
{
    public partial class youtube : UserControl
    {
        int pagenumber = 1;
        //string link = "";
        List<item_ytb> itemYTBs ;
        List<VideoInformation> listYTB;
        public youtube()
        {
            InitializeComponent();
            //this.dGv_Ytb.DefaultCellStyle.Font = new Font("Tahoma", 12);
            //dGv_Ytb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //foreach (DataGridViewColumn col in dGv_Ytb.Columns)
            //{
            //    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //    col.HeaderCell.Style.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            //}
            //SearchYoutube();
            btn_back.Enabled=false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btn_forward.Enabled = true;
            if(pagenumber==1)
                btn_back.Enabled = false; 
            else btn_back.Enabled = true;
            while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);
            SearchYoutube(txtSearch.Text.ToString());
        }
        private void SearchYoutube(string text)
        {
            VideoSearch items = new VideoSearch();
            itemYTBs = new List<item_ytb>();
            try
            {
                int numberYTB = items.SearchQuery(text, pagenumber).Count;
                listYTB = new List<VideoInformation>();
                listYTB = items.SearchQuery(text, pagenumber);
                for (int i = 0; i < numberYTB; i++)
                {
                    item_ytb itemytb = new item_ytb();
                    byte[] bytes = Encoding.Default.GetBytes(listYTB[i].Title);
                    listYTB[i].Title = Encoding.UTF8.GetString(bytes);
                    itemytb.lbl_title.Text = listYTB[i].Title.ToString();
                    itemytb.lbl_url.Text = listYTB[i].Url.ToString();
                    itemytb.lbl_time.Text = listYTB[i].Duration.ToString();
                    //byte[] imageBytes = new WebClient().DownloadData(listYTB[i].Thumbnail);
                    //using (MemoryStream ms = new MemoryStream(imageBytes))
                    //{
                    //    itemytb.btn_image.Image = Image.FromStream(ms);
                    //}
                    itemytb.btn_image.ImageLocation = listYTB[i].Thumbnail;
                    itemytb.btn_image.Tag = i.ToString();
                    itemytb.btn_image.Click += Btn_image_Click;
                    itemYTBs.Add(itemytb);
                    flowLayoutPanel1.Controls.Add(itemytb);
                }
            }
            catch { MessageBox.Show("Vui lòng kết nối mạng!"); };
        }
        int tag;
        private void Btn_image_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuImageButton _image = sender as Bunifu.Framework.UI.BunifuImageButton;
            tag = Convert.ToInt32(_image.Tag);
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerAsync();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Invoke(new Action(()=>
                {
                    Movie_module.FrmVLC frmVlc = new Movie_module.FrmVLC(itemYTBs[tag].lbl_url.Text.ToString());
                    frmVlc.lbl_name_video.Text = itemYTBs[tag].lbl_title.Text.ToString();
                    frmVlc.axVLCPlugin21.playlist.stop();
                    frmVlc.Show();
                }
                ));
            }
            catch
            {
                Invoke(new Action(() =>
                {
                    Movie_module.ThongBao tb = new Movie_module.ThongBao();
                    tb.Show();
                }
                ));
            }
        }

        //private async void bunifuFlatButton1_Click(object sender, EventArgs e)
        //{
        //    using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
        //    {
        //        if (fbd.ShowDialog() == DialogResult.OK)
        //        {
        //            var youtube = YouTube.Default;
        //            //lblSearch.Text = "Đang tải...";
        //           // btnDownload.Visible = false;
        //            var video = await youtube.GetVideoAsync(link);
        //            File.WriteAllBytes(fbd.SelectedPath + video.FullName, await video.GetBytesAsync());
        //            //lblSearch.Text = "Hoàn thành !";
        //        }
        //    }
        //}
        //void threadYTB()
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
        //                tb.ShowDialog ();
        //                btnDownload.Visible = false;
        //            }));

        //        }
        //    });
        //    Thread.Sleep(5000);
        //    thread.Start();

        //}
        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //axVLCPlugin21.playlist.stop();
        //    if (e.RowIndex >= 0)
        //    {
        //        //lblSearch.Visible = true;
        //        //btnDownload.Visible = true;
        //        //lblSearch.Text = "Đang phát...";
        //        //int index = e.RowIndex;
        //        //dGv_Ytb.Rows[index].Selected = true;
        //        //DataGridViewRow row = this.dGv_Ytb.Rows[e.RowIndex];
        //        //lblTitle.Text = row.Cells[1].Value.ToString();
        //        //link = row.Cells["Url"].Value.ToString();
        //        //string a = list[index].Url;
        //        //axVLCPlugin21.playlist.items.clear();
        //        //axVLCPlugin21.playlist.add(link);
        //        //axVLCPlugin21.playlist.next();
        //        //axVLCPlugin21.playlist.play();
        //        Movie_module.FrmVLC frmVlc = new Movie_module.FrmVLC(link);
        //        frmVlc.axVLCPlugin21.playlist.stop();
        //        frmVlc.Show();

        //    }
        //    //threadYTB();
        //}

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                btnSearch_Click(sender, e);
                string[] temp = txtSearch.Text.Split('\n');
                txtSearch.Clear();
                txtSearch.Text = temp[0];
            }
        }
        
        private void btn_back_Click(object sender, EventArgs e)
        {
            pagenumber--;
            btnSearch_Click(sender, e);
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            pagenumber++;
            btnSearch_Click(sender, e);
        }
    }
}
