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
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_fullscreen = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_play = new Bunifu.Framework.UI.BunifuImageButton();
            this.volume = new Bunifu.Framework.UI.BunifuTrackbar();
            this.lbl_maxtime = new System.Windows.Forms.Label();
            this.lbl_currenttime = new System.Windows.Forms.Label();
            this.time_movie = new Bunifu.Framework.UI.BunifuTrackbar();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fullscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 512);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_down);
            this.panel1.Controls.Add(this.btn_down);
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 46);
            this.panel1.TabIndex = 0;
            // 
            // lbl_down
            // 
            this.lbl_down.AutoSize = true;
            this.lbl_down.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_down.ForeColor = System.Drawing.Color.Black;
            this.lbl_down.Location = new System.Drawing.Point(463, 6);
            this.lbl_down.Name = "lbl_down";
            this.lbl_down.Size = new System.Drawing.Size(49, 19);
            this.lbl_down.TabIndex = 5;
            this.lbl_down.Text = "label1";
            // 
            // btn_down
            // 
            this.btn_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_down.Image = ((System.Drawing.Image)(resources.GetObject("btn_down.Image")));
            this.btn_down.ImageActive = null;
            this.btn_down.Location = new System.Drawing.Point(939, 5);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(53, 38);
            this.btn_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_down.TabIndex = 4;
            this.btn_down.TabStop = false;
            this.btn_down.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(21, 0);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(1);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(19, 19);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 3;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click_1);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(19, 19);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_fullscreen);
            this.panel2.Controls.Add(this.bunifuImageButton5);
            this.panel2.Controls.Add(this.bunifuImageButton4);
            this.panel2.Controls.Add(this.bunifuImageButton2);
            this.panel2.Controls.Add(this.btn_play);
            this.panel2.Controls.Add(this.volume);
            this.panel2.Controls.Add(this.lbl_maxtime);
            this.panel2.Controls.Add(this.lbl_currenttime);
            this.panel2.Controls.Add(this.time_movie);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 458);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 51);
            this.panel2.TabIndex = 1;
            // 
            // btn_fullscreen
            // 
            this.btn_fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fullscreen.BackColor = System.Drawing.Color.Transparent;
            this.btn_fullscreen.Image = ((System.Drawing.Image)(resources.GetObject("btn_fullscreen.Image")));
            this.btn_fullscreen.ImageActive = null;
            this.btn_fullscreen.Location = new System.Drawing.Point(949, 5);
            this.btn_fullscreen.Margin = new System.Windows.Forms.Padding(0);
            this.btn_fullscreen.Name = "btn_fullscreen";
            this.btn_fullscreen.Size = new System.Drawing.Size(40, 40);
            this.btn_fullscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_fullscreen.TabIndex = 17;
            this.btn_fullscreen.TabStop = false;
            this.btn_fullscreen.Zoom = 10;
            
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(788, 5);
            this.bunifuImageButton5.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 16;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(86, 5);
            this.bunifuImageButton4.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 15;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(46, 5);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 14;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
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
            // volume
            // 
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volume.BackColor = System.Drawing.Color.Transparent;
            this.volume.BackgroudColor = System.Drawing.Color.DarkGray;
            this.volume.BorderRadius = 10;
            this.volume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.volume.IndicatorColor = System.Drawing.Color.Black;
            this.volume.Location = new System.Drawing.Point(840, 12);
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
            this.lbl_maxtime.Location = new System.Drawing.Point(709, 18);
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
            this.time_movie.Size = new System.Drawing.Size(482, 30);
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
            this.axVLCPlugin21.Size = new System.Drawing.Size(995, 397);
            this.axVLCPlugin21.TabIndex = 2;
            // 
            // FrmVLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1001, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVLC";
            this.Text = "FrmVLC";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fullscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Label lbl_down;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuTrackbar volume;
        private System.Windows.Forms.Label lbl_maxtime;
        private System.Windows.Forms.Label lbl_currenttime;
        public Bunifu.Framework.UI.BunifuTrackbar time_movie;
        public Bunifu.Framework.UI.BunifuImageButton btn_down;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton btn_play;
        private Bunifu.Framework.UI.BunifuImageButton btn_fullscreen;
    }
}