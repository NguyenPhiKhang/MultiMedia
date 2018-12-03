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
            this.lbl_down = new System.Windows.Forms.Label();
            this.btn_down = new Bunifu.Framework.UI.BunifuImageButton();
            this.bIbtn_MiniMize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bIbtn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_fullscreen = new Bunifu.Framework.UI.BunifuImageButton();
            this.bIbtn_Volume = new Bunifu.Framework.UI.BunifuImageButton();
            this.bIbtn_Stop = new Bunifu.Framework.UI.BunifuImageButton();
            this.bIbtn_Pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_play = new Bunifu.Framework.UI.BunifuImageButton();
            this.volume = new Bunifu.Framework.UI.BunifuTrackbar();
            this.lbl_maxtime = new System.Windows.Forms.Label();
            this.lbl_currenttime = new System.Windows.Forms.Label();
            this.time_movie = new Bunifu.Framework.UI.BunifuTrackbar();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_MiniMize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Close)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fullscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1502, 788);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_down);
            this.panel1.Controls.Add(this.btn_down);
            this.panel1.Controls.Add(this.bIbtn_MiniMize);
            this.panel1.Controls.Add(this.bIbtn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1494, 70);
            this.panel1.TabIndex = 0;
            // 
            // lbl_down
            // 
            this.lbl_down.AutoSize = true;
            this.lbl_down.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_down.ForeColor = System.Drawing.Color.Black;
            this.lbl_down.Location = new System.Drawing.Point(1290, 3);
            this.lbl_down.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_down.Name = "lbl_down";
            this.lbl_down.Size = new System.Drawing.Size(115, 26);
            this.lbl_down.TabIndex = 5;
            this.lbl_down.Text = "Download";
            // 
            // btn_down
            // 
            this.btn_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_down.Image = ((System.Drawing.Image)(resources.GetObject("btn_down.Image")));
            this.btn_down.ImageActive = null;
            this.btn_down.Location = new System.Drawing.Point(1410, 8);
            this.btn_down.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(80, 58);
            this.btn_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_down.TabIndex = 4;
            this.btn_down.TabStop = false;
            this.btn_down.Zoom = 10;
            // 
            // bIbtn_MiniMize
            // 
            this.bIbtn_MiniMize.BackColor = System.Drawing.Color.Transparent;
            this.bIbtn_MiniMize.Image = global::MultiMedia.Properties.Resources.Green_circle;
            this.bIbtn_MiniMize.ImageActive = null;
            this.bIbtn_MiniMize.Location = new System.Drawing.Point(30, 0);
            this.bIbtn_MiniMize.Margin = new System.Windows.Forms.Padding(2);
            this.bIbtn_MiniMize.Name = "bIbtn_MiniMize";
            this.bIbtn_MiniMize.Size = new System.Drawing.Size(28, 29);
            this.bIbtn_MiniMize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bIbtn_MiniMize.TabIndex = 3;
            this.bIbtn_MiniMize.TabStop = false;
            this.bIbtn_MiniMize.Zoom = 10;
            this.bIbtn_MiniMize.Click += new System.EventHandler(this.bIbtn_MiniMize_Click_1);
            // 
            // bIbtn_Close
            // 
            this.bIbtn_Close.BackColor = System.Drawing.Color.Transparent;
            this.bIbtn_Close.Image = global::MultiMedia.Properties.Resources.circle_red;
            this.bIbtn_Close.ImageActive = null;
            this.bIbtn_Close.Location = new System.Drawing.Point(0, 0);
            this.bIbtn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.bIbtn_Close.Name = "bIbtn_Close";
            this.bIbtn_Close.Size = new System.Drawing.Size(28, 29);
            this.bIbtn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bIbtn_Close.TabIndex = 1;
            this.bIbtn_Close.TabStop = false;
            this.bIbtn_Close.Zoom = 10;
            this.bIbtn_Close.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
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
            this.panel2.Location = new System.Drawing.Point(4, 706);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1494, 77);
            this.panel2.TabIndex = 1;
            // 
            // btn_fullscreen
            // 
            this.btn_fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fullscreen.BackColor = System.Drawing.Color.Transparent;
            this.btn_fullscreen.Image = ((System.Drawing.Image)(resources.GetObject("btn_fullscreen.Image")));
            this.btn_fullscreen.ImageActive = null;
            this.btn_fullscreen.Location = new System.Drawing.Point(1426, 8);
            this.btn_fullscreen.Margin = new System.Windows.Forms.Padding(0);
            this.btn_fullscreen.Name = "btn_fullscreen";
            this.btn_fullscreen.Size = new System.Drawing.Size(60, 62);
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
            this.bIbtn_Volume.Location = new System.Drawing.Point(1184, 8);
            this.bIbtn_Volume.Margin = new System.Windows.Forms.Padding(0);
            this.bIbtn_Volume.Name = "bIbtn_Volume";
            this.bIbtn_Volume.Size = new System.Drawing.Size(60, 62);
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
            this.bIbtn_Stop.Location = new System.Drawing.Point(129, 8);
            this.bIbtn_Stop.Margin = new System.Windows.Forms.Padding(0);
            this.bIbtn_Stop.Name = "bIbtn_Stop";
            this.bIbtn_Stop.Size = new System.Drawing.Size(60, 62);
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
            this.bIbtn_Pause.Location = new System.Drawing.Point(69, 8);
            this.bIbtn_Pause.Margin = new System.Windows.Forms.Padding(0);
            this.bIbtn_Pause.Name = "bIbtn_Pause";
            this.bIbtn_Pause.Size = new System.Drawing.Size(60, 62);
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
            this.btn_play.Location = new System.Drawing.Point(9, 8);
            this.btn_play.Margin = new System.Windows.Forms.Padding(0);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(60, 62);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_play.TabIndex = 13;
            this.btn_play.TabStop = false;
            this.btn_play.Zoom = 10;
            // 
            // volume
            // 
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volume.BackColor = System.Drawing.Color.Transparent;
            this.volume.BackgroudColor = System.Drawing.Color.DarkGray;
            this.volume.BorderRadius = 10;
            this.volume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.volume.IndicatorColor = System.Drawing.Color.Black;
            this.volume.Location = new System.Drawing.Point(1262, 18);
            this.volume.Margin = new System.Windows.Forms.Padding(0);
            this.volume.MaximumValue = 100;
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(150, 41);
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
            this.lbl_maxtime.Location = new System.Drawing.Point(1066, 28);
            this.lbl_maxtime.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_maxtime.Name = "lbl_maxtime";
            this.lbl_maxtime.Size = new System.Drawing.Size(81, 20);
            this.lbl_maxtime.TabIndex = 9;
            this.lbl_maxtime.Text = "00:00:00";
            this.lbl_maxtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_currenttime
            // 
            this.lbl_currenttime.AutoSize = true;
            this.lbl_currenttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currenttime.ForeColor = System.Drawing.Color.Blue;
            this.lbl_currenttime.Location = new System.Drawing.Point(204, 28);
            this.lbl_currenttime.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_currenttime.Name = "lbl_currenttime";
            this.lbl_currenttime.Size = new System.Drawing.Size(81, 20);
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
            this.time_movie.Location = new System.Drawing.Point(312, 18);
            this.time_movie.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.time_movie.MaximumValue = 100;
            this.time_movie.Name = "time_movie";
            this.time_movie.Size = new System.Drawing.Size(725, 41);
            this.time_movie.SliderRadius = 10;
            this.time_movie.TabIndex = 0;
            this.time_movie.Value = 0;
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(4, 85);
            this.axVLCPlugin21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(1494, 611);
            this.axVLCPlugin21.TabIndex = 2;
            // 
            // FrmVLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1502, 788);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVLC";
            this.Text = "FrmVLC";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_MiniMize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fullscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bIbtn_Close;
        private Bunifu.Framework.UI.BunifuImageButton bIbtn_MiniMize;
        private System.Windows.Forms.Label lbl_down;
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
    }
}