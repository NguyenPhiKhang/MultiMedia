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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Stop = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_play = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_play_vlc = new Bunifu.Framework.UI.BunifuImageButton();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bIbtn_MiniMize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bIbtn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_name_video = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play_vlc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_MiniMize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Close)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.54371F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.45629F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 512);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Stop);
            this.panel2.Controls.Add(this.btn_Pause);
            this.panel2.Controls.Add(this.btn_play);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 37);
            this.panel2.TabIndex = 3;
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stop.Image")));
            this.btn_Stop.ImageActive = null;
            this.btn_Stop.Location = new System.Drawing.Point(488, 3);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(50, 34);
            this.btn_Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Stop.TabIndex = 19;
            this.btn_Stop.TabStop = false;
            this.btn_Stop.Zoom = 10;
            this.btn_Stop.Click += new System.EventHandler(this.bIbtn_Stop_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_Pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pause.Image")));
            this.btn_Pause.ImageActive = null;
            this.btn_Pause.Location = new System.Drawing.Point(438, 3);
            this.btn_Pause.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(50, 34);
            this.btn_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Pause.TabIndex = 18;
            this.btn_Pause.TabStop = false;
            this.btn_Pause.Zoom = 10;
            this.btn_Pause.Click += new System.EventHandler(this.bIbtn_Pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.ImageActive = null;
            this.btn_play.Location = new System.Drawing.Point(388, 3);
            this.btn_play.Margin = new System.Windows.Forms.Padding(0);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(50, 34);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_play.TabIndex = 17;
            this.btn_play.TabStop = false;
            this.btn_play.Zoom = 10;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_play_vlc);
            this.panel3.Controls.Add(this.axVLCPlugin21);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(918, 437);
            this.panel3.TabIndex = 4;
            // 
            // btn_play_vlc
            // 
            this.btn_play_vlc.BackColor = System.Drawing.Color.Black;
            this.btn_play_vlc.Image = ((System.Drawing.Image)(resources.GetObject("btn_play_vlc.Image")));
            this.btn_play_vlc.ImageActive = null;
            this.btn_play_vlc.Location = new System.Drawing.Point(411, 178);
            this.btn_play_vlc.Name = "btn_play_vlc";
            this.btn_play_vlc.Size = new System.Drawing.Size(95, 85);
            this.btn_play_vlc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_play_vlc.TabIndex = 1;
            this.btn_play_vlc.TabStop = false;
            this.btn_play_vlc.Zoom = 10;
            this.btn_play_vlc.Click += new System.EventHandler(this.btn_play_vlc_Click);
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(918, 440);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.466231F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.53377F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_name_video, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(918, 20);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bIbtn_MiniMize);
            this.panel1.Controls.Add(this.bIbtn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 20);
            this.panel1.TabIndex = 0;
            // 
            // bIbtn_MiniMize
            // 
            this.bIbtn_MiniMize.BackColor = System.Drawing.Color.Transparent;
            this.bIbtn_MiniMize.Image = ((System.Drawing.Image)(resources.GetObject("bIbtn_MiniMize.Image")));
            this.bIbtn_MiniMize.ImageActive = null;
            this.bIbtn_MiniMize.Location = new System.Drawing.Point(22, 2);
            this.bIbtn_MiniMize.Margin = new System.Windows.Forms.Padding(1);
            this.bIbtn_MiniMize.Name = "bIbtn_MiniMize";
            this.bIbtn_MiniMize.Size = new System.Drawing.Size(17, 17);
            this.bIbtn_MiniMize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bIbtn_MiniMize.TabIndex = 3;
            this.bIbtn_MiniMize.TabStop = false;
            this.bIbtn_MiniMize.Zoom = 10;
            this.bIbtn_MiniMize.Click += new System.EventHandler(this.bIbtn_MiniMize_Click_1);
            // 
            // bIbtn_Close
            // 
            this.bIbtn_Close.BackColor = System.Drawing.Color.Transparent;
            this.bIbtn_Close.Image = ((System.Drawing.Image)(resources.GetObject("bIbtn_Close.Image")));
            this.bIbtn_Close.ImageActive = null;
            this.bIbtn_Close.Location = new System.Drawing.Point(3, 2);
            this.bIbtn_Close.Margin = new System.Windows.Forms.Padding(1);
            this.bIbtn_Close.Name = "bIbtn_Close";
            this.bIbtn_Close.Size = new System.Drawing.Size(17, 17);
            this.bIbtn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bIbtn_Close.TabIndex = 1;
            this.bIbtn_Close.TabStop = false;
            this.bIbtn_Close.Zoom = 10;
            this.bIbtn_Close.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // lbl_name_video
            // 
            this.lbl_name_video.AutoSize = true;
            this.lbl_name_video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name_video.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_video.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_name_video.Location = new System.Drawing.Point(43, 0);
            this.lbl_name_video.Name = "lbl_name_video";
            this.lbl_name_video.Size = new System.Drawing.Size(872, 20);
            this.lbl_name_video.TabIndex = 1;
            this.lbl_name_video.Text = "label1";
            this.lbl_name_video.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lbl_name_video;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVLC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VLC";
            this.Activated += new System.EventHandler(this.TB_Activated);
            this.Deactivate += new System.EventHandler(this.TB_Deactivate);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_play_vlc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_MiniMize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIbtn_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bIbtn_Close;
        private Bunifu.Framework.UI.BunifuImageButton bIbtn_MiniMize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        public Bunifu.Framework.UI.BunifuImageButton btn_Stop;
        public Bunifu.Framework.UI.BunifuImageButton btn_Pause;
        public Bunifu.Framework.UI.BunifuImageButton btn_play;
        public Bunifu.Framework.UI.BunifuImageButton btn_play_vlc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_name_video;
    }
}