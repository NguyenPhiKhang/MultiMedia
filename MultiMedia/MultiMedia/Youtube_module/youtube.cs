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
        string text_search = "";
        List<item_ytb> itemYTBs = new List<item_ytb>();
        List<VideoInformation> listYTB = new List<VideoInformation>();
        item_ytb itemytb;
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
            SearchYoutube();
            btn_back.Enabled=false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().ToString() == null || txtSearch.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            else
            {
                pagenumber = 1;
                btn_forward.Enabled = true;
                btn_back.Enabled = false;
                text_search = txtSearch.Text.ToString();
                SearchYoutube();
            }
        }
        private void SearchYoutube()
        {
            while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);
            VideoSearch items = new VideoSearch();
            itemYTBs.Clear();
            try
            {
                listYTB.Clear();
                listYTB = items.SearchQuery(text_search, pagenumber);
                int numberYTB = listYTB.Count;
                for (int i = 0; i < numberYTB; i++)
                {
                    itemytb = new item_ytb();
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
                itemytb.Dispose();
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
            SearchYoutube();
            if (pagenumber == 1)
                btn_back.Enabled = false;
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            pagenumber++;
            SearchYoutube();
        }
    }
}
