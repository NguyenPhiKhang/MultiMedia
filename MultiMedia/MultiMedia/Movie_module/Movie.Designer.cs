﻿namespace MultiMedia.Movie_module
{
    partial class Movie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movie));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropdown_theloai = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_chieurap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_phimmoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_phimle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_sotrang = new System.Windows.Forms.Label();
            this.btn_forward = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_back = new Bunifu.Framework.UI.BunifuImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tb_timkiem = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.34884F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.65116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 468F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1037, 726);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1031, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_timkiem);
            this.panel1.Controls.Add(this.dropdown_theloai);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.btn_chieurap);
            this.panel1.Controls.Add(this.btn_phimmoi);
            this.panel1.Controls.Add(this.btn_phimle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 47);
            this.panel1.TabIndex = 1;
            // 
            // dropdown_theloai
            // 
            this.dropdown_theloai.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.dropdown_theloai.BackColor = System.Drawing.Color.Transparent;
            this.dropdown_theloai.BorderRadius = 0;
            this.dropdown_theloai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_theloai.ForeColor = System.Drawing.Color.Black;
            this.dropdown_theloai.Items = new string[] {
        "Truyền hình",
        "Kiếm hiệp",
        "Hành động",
        "Võ thuật",
        "Tâm lý",
        "Hài hước",
        "Hoạt hình",
        "Phiêu lưu",
        "Kinh dị",
        "Hình sự",
        "Chiến tranh",
        "Thần thoại",
        "Viễn tưởng",
        "Cổ trang",
        "Âm nhạc",
        "Anime"};
            this.dropdown_theloai.Location = new System.Drawing.Point(0, 0);
            this.dropdown_theloai.Margin = new System.Windows.Forms.Padding(0);
            this.dropdown_theloai.Name = "dropdown_theloai";
            this.dropdown_theloai.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.dropdown_theloai.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dropdown_theloai.selectedIndex = 0;
            this.dropdown_theloai.Size = new System.Drawing.Size(150, 47);
            this.dropdown_theloai.TabIndex = 6;
            this.dropdown_theloai.onItemSelected += new System.EventHandler(this.dropdown_theloai_onItemSelected);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Tìm Kiếm";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(909, 2);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(107, 41);
            this.bunifuThinButton21.TabIndex = 5;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.btn_timkiem_Click_1);
            // 
            // btn_chieurap
            // 
            this.btn_chieurap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_chieurap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_chieurap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chieurap.BorderRadius = 0;
            this.btn_chieurap.ButtonText = "Phim Chiếu Rạp";
            this.btn_chieurap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chieurap.DisabledColor = System.Drawing.Color.Gray;
            this.btn_chieurap.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_chieurap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_chieurap.Iconimage")));
            this.btn_chieurap.Iconimage_right = null;
            this.btn_chieurap.Iconimage_right_Selected = null;
            this.btn_chieurap.Iconimage_Selected = null;
            this.btn_chieurap.IconMarginLeft = 0;
            this.btn_chieurap.IconMarginRight = 0;
            this.btn_chieurap.IconRightVisible = true;
            this.btn_chieurap.IconRightZoom = 0D;
            this.btn_chieurap.IconVisible = true;
            this.btn_chieurap.IconZoom = 60D;
            this.btn_chieurap.IsTab = false;
            this.btn_chieurap.Location = new System.Drawing.Point(424, -1);
            this.btn_chieurap.Margin = new System.Windows.Forms.Padding(0);
            this.btn_chieurap.Name = "btn_chieurap";
            this.btn_chieurap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_chieurap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_chieurap.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_chieurap.selected = false;
            this.btn_chieurap.Size = new System.Drawing.Size(183, 48);
            this.btn_chieurap.TabIndex = 3;
            this.btn_chieurap.Text = "Phim Chiếu Rạp";
            this.btn_chieurap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_chieurap.Textcolor = System.Drawing.Color.Black;
            this.btn_chieurap.TextFont = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chieurap.Click += new System.EventHandler(this.btn_chieurap_Click);
            // 
            // btn_phimmoi
            // 
            this.btn_phimmoi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_phimmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_phimmoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_phimmoi.BorderRadius = 0;
            this.btn_phimmoi.ButtonText = "Phim Mới";
            this.btn_phimmoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_phimmoi.DisabledColor = System.Drawing.Color.Gray;
            this.btn_phimmoi.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_phimmoi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_phimmoi.Iconimage")));
            this.btn_phimmoi.Iconimage_right = null;
            this.btn_phimmoi.Iconimage_right_Selected = null;
            this.btn_phimmoi.Iconimage_Selected = null;
            this.btn_phimmoi.IconMarginLeft = 0;
            this.btn_phimmoi.IconMarginRight = 0;
            this.btn_phimmoi.IconRightVisible = true;
            this.btn_phimmoi.IconRightZoom = 0D;
            this.btn_phimmoi.IconVisible = true;
            this.btn_phimmoi.IconZoom = 60D;
            this.btn_phimmoi.IsTab = false;
            this.btn_phimmoi.Location = new System.Drawing.Point(287, 0);
            this.btn_phimmoi.Margin = new System.Windows.Forms.Padding(0);
            this.btn_phimmoi.Name = "btn_phimmoi";
            this.btn_phimmoi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_phimmoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_phimmoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_phimmoi.selected = false;
            this.btn_phimmoi.Size = new System.Drawing.Size(137, 47);
            this.btn_phimmoi.TabIndex = 2;
            this.btn_phimmoi.Text = "Phim Mới";
            this.btn_phimmoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_phimmoi.Textcolor = System.Drawing.Color.Black;
            this.btn_phimmoi.TextFont = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phimmoi.Click += new System.EventHandler(this.btn_phimmoi_Click);
            // 
            // btn_phimle
            // 
            this.btn_phimle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_phimle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_phimle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_phimle.BorderRadius = 0;
            this.btn_phimle.ButtonText = "Phim Lẻ";
            this.btn_phimle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_phimle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_phimle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_phimle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_phimle.Iconimage")));
            this.btn_phimle.Iconimage_right = null;
            this.btn_phimle.Iconimage_right_Selected = null;
            this.btn_phimle.Iconimage_Selected = null;
            this.btn_phimle.IconMarginLeft = 0;
            this.btn_phimle.IconMarginRight = 0;
            this.btn_phimle.IconRightVisible = true;
            this.btn_phimle.IconRightZoom = 0D;
            this.btn_phimle.IconVisible = true;
            this.btn_phimle.IconZoom = 60D;
            this.btn_phimle.IsTab = false;
            this.btn_phimle.Location = new System.Drawing.Point(150, -1);
            this.btn_phimle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_phimle.Name = "btn_phimle";
            this.btn_phimle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_phimle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_phimle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_phimle.selected = false;
            this.btn_phimle.Size = new System.Drawing.Size(137, 48);
            this.btn_phimle.TabIndex = 1;
            this.btn_phimle.Text = "Phim Lẻ";
            this.btn_phimle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_phimle.Textcolor = System.Drawing.Color.Black;
            this.btn_phimle.TextFont = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phimle.Click += new System.EventHandler(this.btn_phimle_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_sotrang);
            this.panel2.Controls.Add(this.btn_forward);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 683);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 43);
            this.panel2.TabIndex = 2;
            // 
            // lbl_sotrang
            // 
            this.lbl_sotrang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sotrang.AutoSize = true;
            this.lbl_sotrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sotrang.ForeColor = System.Drawing.Color.White;
            this.lbl_sotrang.Location = new System.Drawing.Point(480, 11);
            this.lbl_sotrang.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_sotrang.Name = "lbl_sotrang";
            this.lbl_sotrang.Size = new System.Drawing.Size(34, 20);
            this.lbl_sotrang.TabIndex = 2;
            this.lbl_sotrang.Text = "0/0";
            // 
            // btn_forward
            // 
            this.btn_forward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_forward.BackColor = System.Drawing.Color.Transparent;
            this.btn_forward.Image = ((System.Drawing.Image)(resources.GetObject("btn_forward.Image")));
            this.btn_forward.ImageActive = null;
            this.btn_forward.Location = new System.Drawing.Point(541, 0);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(53, 42);
            this.btn_forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_forward.TabIndex = 1;
            this.btn_forward.TabStop = false;
            this.btn_forward.Zoom = 10;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageActive = null;
            this.btn_back.Location = new System.Drawing.Point(406, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(53, 42);
            this.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_back.TabIndex = 0;
            this.btn_back.TabStop = false;
            this.btn_back.Zoom = 10;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 218);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1031, 462);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_timkiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(622, 10);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(281, 25);
            this.tb_timkiem.TabIndex = 7;
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Movie";
            this.Size = new System.Drawing.Size(1037, 726);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_phimle;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuFlatButton btn_chieurap;
        private Bunifu.Framework.UI.BunifuFlatButton btn_phimmoi;
        private Bunifu.Framework.UI.BunifuDropdown dropdown_theloai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_sotrang;
        private Bunifu.Framework.UI.BunifuImageButton btn_forward;
        private Bunifu.Framework.UI.BunifuImageButton btn_back;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_timkiem;
    }
}
