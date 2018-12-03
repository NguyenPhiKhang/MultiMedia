using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using System.Net;
using System.IO;
namespace MultiMedia.Movie_module
{
    public partial class FrmVLC : Form
    {
        public bool isFullScreen;
        public string url;
        public string uri;

        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }

        public FrmVLC(String url)
        {
            InitializeComponent();
            isFullScreen = false;
            for (int i = 0; i < axVLCPlugin21.playlist.itemCount; i++)
            {
                axVLCPlugin21.playlist.items.remove(i);
            }

            axVLCPlugin21.playlist.add(url);
            axVLCPlugin21.playlist.play();
            lbl_currenttime.Text = "0:00:00";

            volume.Value = 100;
            btn_play.Click += btn_play_Click;
            bIbtn_Pause.Click += bIbtn_Pause_Click;
            bIbtn_Stop.Click += bIbtn_Stop_Click;
            btn_fullscreen.Click += btn_fullscreen_Click;
            
            volume.ValueChanged += volume_ValueChanged;
            time_movie.ValueChanged += time_movie_ValueChanged;
            uri = url;
        }

        public String TimeFormat(int millisecond)
        {
            int TotalSecond = millisecond / 1000;
            int hour = TotalSecond / 3600;
            int hour_res = TotalSecond - (hour * 3600);
            int minute = hour_res / 60;
            int minute_res = hour_res - (minute * 60);
            int second = minute_res % 60;
            string strTime = String.Format("{0,1}:{1,2:D2}:{2,2:D2}", hour, minute, second);
            return strTime;
        }

        private void bIbtn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bIbtn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void axVLCPlugin21_MediaPlayerPlaying(object sender, EventArgs e)
        {
            lbl_maxtime.Text = TimeFormat((int)axVLCPlugin21.input.length);
            time_movie.MaximumValue = (int)axVLCPlugin21.input.length;
        }

        private void volume_ValueChanged(object sender, EventArgs e)
        {
            axVLCPlugin21.volume = volume.Value;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            //if (axVLCPlugin21.playlist.isPlaying)
            //{
            //    axVLCPlugin21.playlist.pause();
            //}
            //else
            //{
            //    axVLCPlugin21.playlist.play();
            //}
            axVLCPlugin21.playlist.play();
        }
        private void bIbtn_Pause_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.pause();
        }

        private void bIbtn_Stop_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.stop();
        }

        private void axVLCPlugin21_MediaPlayerTimeChanged(object sender, AxAXVLC.DVLCEvents_MediaPlayerTimeChangedEvent e)
        {
            lbl_currenttime.Text = TimeFormat(e.time);
            time_movie.Value += e.time / 1000;
        }

        private void time_movie_ValueChanged(object sender, EventArgs e)
        {
            if (time_movie.Value < time_movie.MaximumValue)
            {
                lbl_currenttime.Text = TimeFormat(time_movie.Value);
                axVLCPlugin21.input.time = time_movie.Value;
            }
            else
            {
                time_movie.Value = time_movie.MaximumValue;
                axVLCPlugin21.playlist.stop();
            }   
        }

        private void btn_fullscreen_Click(object sender, EventArgs e)
        {
            if (!isFullScreen)
            {
                System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
                //this.MaximizedBounds = Screen.GetWorkingArea(this);
                this.WindowState = FormWindowState.Maximized;
                isFullScreen = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isFullScreen = false;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_fullscreen_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            isFullScreen = false;
        }

        WebClient c = new WebClient();
        private void btn_down_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    lbl_down.Visible = true;
                    Uri u = new Uri(this.uri);
                    c.DownloadFileAsync(u, Path.Combine(fbd.SelectedPath, Path.GetFileName(u.AbsolutePath)));
                    c.DownloadProgressChanged += C_DownloadProgressChanged;
                    c.DownloadFileCompleted += C_DownloadFileCompleted;
                }
            }

        }

        private void C_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Đã tải xong");
        }

        private void C_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double r = e.BytesReceived;
            double file_size = e.TotalBytesToReceive;
            double pe = r / file_size * 100;
            lbl_down.Text = string.Format("{0 : 0.00}%", pe);
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bIbtn_MiniMize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bIbtn_Volume_Click(object sender, EventArgs e)
        {
            volume.Value = 0;
            axVLCPlugin21.audio.volume = volume.Value;
        }
    }
}
