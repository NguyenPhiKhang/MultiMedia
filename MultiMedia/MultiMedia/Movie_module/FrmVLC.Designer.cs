namespace MultiMedia.Movie_module
{
    partial class FrmVLC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVLC));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_video = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.volume = new Bunifu.Framework.UI.BunifuTrackbar();
            this.lbl_maxtime = new System.Windows.Forms.Label();
            this.lbl_currenttime = new System.Windows.Forms.Label();
            this.time_movie = new Bunifu.Framework.UI.BunifuTrackbar();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.btn_down = new Bunifu.Framework.UI.BunifuImageButton();
            this.bIbtn_MiniMize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bIbtn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_fullscreen = new Bunifu.Framework.UI.BunifuImageButton();
            this.bIbtn_Volume = new Bunifu.Framework.UI.BunifuImageButton();
            this.bIbtn_Stop = new Bunifu.Framework.UI.BunifuImageButton();
            this.bIbtn_Pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_play = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_MiniMize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fullscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.axVLCPlugin21, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 512);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_name_video);
            this.panel1.Controls.Add(this.btn_down);
            this.panel1.Controls.Add(this.bIbtn_MiniMize);
            this.panel1.Controls.Add(this.bIbtn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 46);
            this.panel1.TabIndex = 0;
            // 
            // lbl_name_video
            // 
            this.lbl_name_video.AutoSize = true;
            this.lbl_name_video.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_video.ForeColor = System.Drawing.Color.Black;
            this.lbl_name_video.Location = new System.Drawing.Point(400, 6);
            this.lbl_name_video.Name = "lbl_name_video";
            this.lbl_name_video.Size = new System.Drawing.Size(89, 19);
            this.lbl_name_video.TabIndex = 5;
            this.lbl_name_video.Text = "name_video";
            this.lbl_name_video.TextChanged += new System.EventHandler(this.lbl_name_video_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_fullscreen);
            this.panel2.Controls.Add(this.bIbtn_Volume);
            this.panel2.Controls.Add(this.bIbtn_Stop);
            this.panel2.Controls.Add(this.bIbtn_Pause);
            this.panel2.Controls.Add(this.btn_play);
            this.panel2.Controls.Add(this.volume);
            this.panel2.Controls.Add(this.lbl_maxtime);
            this.panel2.Controls.Add(this.lbl_currenttime);
            this.panel2.Controls.Add(this.time_movie);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 458);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 51);
            this.panel2.TabIndex = 1;
            // 
            // volume
            // 
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volume.BackColor = System.Drawing.Color.Transparent;
            this.volume.BackgroudColor = System.Drawing.Color.DarkGray;
            this.volume.BorderRadius = 10;
            this.volume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.volume.IndicatorColor = System.Drawing.Color.Black;
            this.volume.Location = new System.Drawing.Point(763, 12);
            this.volume.Margin = new System.Windows.Forms.Padding(0);
            this.volume.MaximumValue = 100;
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(100, 30);
            this.volume.SliderRadius = 10;
            this.volume.TabIndex = 11;
            this.volume.Value = 0;
            // 
            // lbl_maxtime
            // 
            this.lbl_maxtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_maxtime.AutoSize = true;
            this.lbl_maxtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxtime.ForeColor = System.Drawing.Color.Blue;
            this.lbl_maxtime.Location = new System.Drawing.Point(633, 18);
            this.lbl_maxtime.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_maxtime.Name = "lbl_maxtime";
            this.lbl_maxtime.Size = new System.Drawing.Size(57, 13);
            this.lbl_maxtime.TabIndex = 9;
            this.lbl_maxtime.Text = "00:00:00";
            this.lbl_maxtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_currenttime
            // 
            this.lbl_currenttime.AutoSize = true;
            this.lbl_currenttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currenttime.ForeColor = System.Drawing.Color.Blue;
            this.lbl_currenttime.Location = new System.Drawing.Point(136, 18);
            this.lbl_currenttime.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_currenttime.Name = "lbl_currenttime";
            this.lbl_currenttime.Size = new System.Drawing.Size(57, 13);
            this.lbl_currenttime.TabIndex = 5;
            this.lbl_currenttime.Text = "00:00:00";
            this.lbl_currenttime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_movie
            // 
            this.time_movie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time_movie.BackColor = System.Drawing.Color.Transparent;
            this.time_movie.BackgroudColor = System.Drawing.Color.DarkGray;
            this.time_movie.BorderRadius = 10;
            this.time_movie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.time_movie.IndicatorColor = System.Drawing.Color.Black;
            this.time_movie.Location = new System.Drawing.Point(208, 12);
            this.time_movie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.time_movie.MaximumValue = 100;
            this.time_movie.Name = "time_movie";
            this.time_movie.Size = new System.Drawing.Size(405, 30);
            this.time_movie.SliderRadius = 10;
            this.time_movie.TabIndex = 0;
            this.time_movie.Value = 0;
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(3, 55);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(918, 397);
            this.axVLCPlugin21.TabIndex = 2;
            // 
            // btn_down
            // 
            this.btn_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_down.Image = ((System.Drawing.Image)(resources.GetObject("btn_down.Image")));
            this.btn_down.ImageActive = null;
            this.btn_down.Location = new System.Drawing.Point(862, 5);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(53, 38);
            this.btn_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_down.TabIndex = 4;
            this.btn_down.TabStop = false;
            this.btn_down.Zoom = 10;
            // 
            // bIbtn_MiniMize
            // 
            this.bIbtn_MiniMize.BackColor = System.Drawing.Color.Transparent;
            this.bIbtn_MiniMize.Image = global::MultiMedia.Properties.Resources.Trafficlight_green_icon;
            this.bIbtn_MiniMize.ImageActive = null;
            this.bIbtn_MiniMize.Location = new System.Drawing.Point(26, 1);
            this.bIbtn_MiniMize.Margin = new System.Windows.Forms.Padding(1);
            this.bIbtn_MiniMize.Name = "bIbtn_MiniMize";
            this.bIbtn_MiniMize.Size = new System.Drawing.Size(20, 20);
            this.bIbtn_MiniMize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bIbtn_MiniMize.TabIndex = 3;
            this.bIbtn_MiniMize.TabStop = false;
            this.bIbtn_MiniMize.Zoom = 10;
            this.bIbtn_MiniMize.Click += new System.EventHandler(this.bIbtn_MiniMize_Click_1);
            // 
            // bIbtn_Close
            // 
            this.bIbtn_Close.BackColor = System.Drawing.Color.Transparent;
            this.bIbtn_Close.Image = global::MultiMedia.Properties.Resources.red;
            this.bIbtn_Close.ImageActive = null;
            this.bIbtn_Close.Location = new System.Drawing.Point(4, 1);
            this.bIbtn_Close.Margin = new System.Windows.Forms.Padding(1);
            this.bIbtn_Close.Name = "bIbtn_Close";
            this.bIbtn_Close.Size = new System.Drawing.Size(20, 20);
            this.bIbtn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bIbtn_Close.TabIndex = 1;
            this.bIbtn_Close.TabStop = false;
            this.bIbtn_Close.Zoom = 10;
            this.bIbtn_Close.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // btn_fullscreen
            // 
            this.btn_fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fullscreen.BackColor = System.Drawing.Color.Transparent;
            this.btn_fullscreen.Image = ((System.Drawing.Image)(resources.GetObject("btn_fullscreen.Image")));
            this.btn_fullscreen.ImageActive = null;
            this.btn_fullscreen.Location = new System.Drawing.Point(873, 5);
            this.btn_fullscreen.Margin = new System.Windows.Forms.Padding(0);
            this.btn_fullscreen.Name = "btn_fullscreen";
            this.btn_fullscreen.Size = new System.Drawing.Size(40, 40);
            this.btn_fullscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_fullscreen.TabIndex = 17;
            this.btn_fullscreen.TabStop = false;
            this.btn_fullscreen.Zoom = 10;
            // 
            // bIbtn_Volume
            // 
            this.bIbtn_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bIbtn_Volume.BackColor = System.Drawing.Color.Transparent;
            this.bIbtn_Volume.Image = global::MultiMedia.Properties.Resources.volume_512;
            this.bIbtn_Volume.ImageActive = null;
            this.bIbtn_Volume.Location = new System.Drawing.Point(711, 5);
            this.bIbtn_Volume.Margin = new System.Windows.Forms.Padding(0);
            this.bIbtn_Volume.Name = "bIbtn_Volume";
            this.bIbtn_Volume.Size = new System.Drawing.Size(40, 40);
            this.bIbtn_Volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bIbtn_Volume.TabIndex = 16;
            this.bIbtn_Volume.TabStop = false;
            this.bIbtn_Volume.Zoom = 10;
            this.bIbtn_Volume.Click += new System.EventHandler(this.bIbtn_Volume_Click);
            // 
            // bIbtn_Stop
            // 
            this.bIbtn_Stop.BackColor = System.Drawing.Color.Transparent;
            this.bIbtn_Stop.Image = global::MultiMedia.Properties.Resources._219_512;
            this.bIbtn_Stop.ImageActive = null;
            this.bIbtn_Stop.Location = new System.Drawing.Point(86, 5);
            this.bIbtn_Stop.Margin = new System.Windows.Forms.Padding(0);
            this.bIbtn_Stop.Name = "bIbtn_Stop";
            this.bIbtn_Stop.Size = new System.Drawing.Size(40, 40);
            this.bIbtn_Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bIbtn_Stop.TabIndex = 15;
            this.bIbtn_Stop.TabStop = false;
            this.bIbtn_Stop.Zoom = 10;
            this.bIbtn_Stop.Click += new System.EventHandler(this.bIbtn_Stop_Click);
            // 
            // bIbtn_Pause
            // 
            this.bIbtn_Pause.BackColor = System.Drawing.Color.Transparent;
            this.bIbtn_Pause.Image = global::MultiMedia.Properties.Resources.img_357679;
            this.bIbtn_Pause.ImageActive = null;
            this.bIbtn_Pause.Location = new System.Drawing.Point(46, 5);
            this.bIbtn_Pause.Margin = new System.Windows.Forms.Padding(0);
            this.bIbtn_Pause.Name = "bIbtn_Pause";
            this.bIbtn_Pause.Size = new System.Drawing.Size(40, 40);
            this.bIbtn_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bIbtn_Pause.TabIndex = 14;
            this.bIbtn_Pause.TabStop = false;
            this.bIbtn_Pause.Zoom = 10;
            this.bIbtn_Pause.Click += new System.EventHandler(this.bIbtn_Pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.ImageActive = null;
            this.btn_play.Location = new System.Drawing.Point(6, 5);
            this.btn_play.Margin = new System.Windows.Forms.Padding(0);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(40, 40);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_play.TabIndex = 13;
            this.btn_play.TabStop = false;
            this.btn_play.Zoom = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmVLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVLC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVLC";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_MiniMize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fullscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bIbtn_Close;
        private Bunifu.Framework.UI.BunifuImageButton bIbtn_MiniMize;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuTrackbar volume;
        private System.Windows.Forms.Label lbl_maxtime;
        private System.Windows.Forms.Label lbl_currenttime;
        public Bunifu.Framework.UI.BunifuTrackbar time_movie;
        public Bunifu.Framework.UI.BunifuImageButton btn_down;
        private Bunifu.Framework.UI.BunifuImageButton bIbtn_Volume;
        private Bunifu.Framework.UI.BunifuImageButton bIbtn_Stop;
        private Bunifu.Framework.UI.BunifuImageButton bIbtn_Pause;
        private Bunifu.Framework.UI.BunifuImageButton btn_play;
        private Bunifu.Framework.UI.BunifuImageButton btn_fullscreen;
        public System.Windows.Forms.Label lbl_name_video;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}