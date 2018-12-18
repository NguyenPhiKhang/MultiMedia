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
        string link = "";
        public youtube()
        {
            InitializeComponent();
            this.dGv_Ytb.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dGv_Ytb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            foreach (DataGridViewColumn col in dGv_Ytb.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            //SearchYoutube();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchYoutube();
        }
        private void SearchYoutube()
        {
            List<Video> list = new List<Video>();
            VideoSearch items = new VideoSearch();
            try
            {
                foreach (var item in items.SearchQuery(txtSearch.Text, pagenumber))
                {
                    Video video = new Video();

                    byte[] bytes = Encoding.Default.GetBytes(item.Title);
                    item.Title = Encoding.UTF8.GetString(bytes);
                    video.Title = item.Title;
                    video.Url = item.Url;

                    byte[] imageBytes = new WebClient().DownloadData(item.Thumbnail);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        video.Thumbnail = Image.FromStream(ms);
                    }
                    list.Add(video);
                }
                videoBindingSource.DataSource = list;
            } catch { MessageBox.Show("Vui lòng kết nối mạng!"); };
        }

        private async void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var youtube = YouTube.Default;
                    //lblSearch.Text = "Đang tải...";
                   // btnDownload.Visible = false;
                    var video = await youtube.GetVideoAsync(link);
                    File.WriteAllBytes(fbd.SelectedPath + video.FullName, await video.GetBytesAsync());
                    //lblSearch.Text = "Hoàn thành !";
                }
            }
        }
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //axVLCPlugin21.playlist.stop();
            if (e.RowIndex >= 0)
            {
                //lblSearch.Visible = true;
                //btnDownload.Visible = true;
                //lblSearch.Text = "Đang phát...";
                //int index = e.RowIndex;
                //dGv_Ytb.Rows[index].Selected = true;
                DataGridViewRow row = this.dGv_Ytb.Rows[e.RowIndex];
                //lblTitle.Text = row.Cells[1].Value.ToString();
                link = row.Cells["Url"].Value.ToString();
                //string a = list[index].Url;
                //axVLCPlugin21.playlist.items.clear();
                //axVLCPlugin21.playlist.add(link);
                //axVLCPlugin21.playlist.next();
                //axVLCPlugin21.playlist.play();
                Movie_module.FrmVLC frmVlc = new Movie_module.FrmVLC(link);
                frmVlc.axVLCPlugin21.playlist.stop();
                frmVlc.Show();
                
            }
            //threadYTB();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SearchYoutube();

                string[] temp = txtSearch.Text.Split('\n');
                txtSearch.Clear();
                foreach (string item in temp)
                {
                    txtSearch.Text = item;
                }
            }
        }
        
        private void btn_back_Click(object sender, EventArgs e)
        {
            if (pagenumber > 1)
            {
                pagenumber--;
                btnSearch_Click(sender, e);
            }
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            pagenumber++;
            btnSearch_Click(sender, e);
        }
    }
}
