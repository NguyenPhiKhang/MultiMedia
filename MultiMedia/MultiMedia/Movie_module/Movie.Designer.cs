namespace MultiMedia.Movie_module
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
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_phimle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_phimmoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_chieurap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.85107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.14894F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 392F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1037, 726);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1031, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuDropdown1.BorderRadius = 0;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.Items = new string[] {
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
            this.bunifuDropdown1.Location = new System.Drawing.Point(-3, 0);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = 0;
            this.bunifuDropdown1.Size = new System.Drawing.Size(173, 48);
            this.bunifuDropdown1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomTextbox1);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.btn_chieurap);
            this.panel1.Controls.Add(this.btn_phimmoi);
            this.panel1.Controls.Add(this.btn_phimle);
            this.panel1.Controls.Add(this.bunifuDropdown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 48);
            this.panel1.TabIndex = 2;
            // 
            // btn_phimle
            // 
            this.btn_phimle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_phimle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_phimle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_phimle.BorderRadius = 0;
            this.btn_phimle.ButtonText = "Phim Lẻ";
            this.btn_phimle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_phimle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_phimle.ForeColor = System.Drawing.Color.Black;
            this.btn_phimle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_phimle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_phimle.Iconimage")));
            this.btn_phimle.Iconimage_right = null;
            this.btn_phimle.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("btn_phimle.Iconimage_right_Selected")));
            this.btn_phimle.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btn_phimle.Iconimage_Selected")));
            this.btn_phimle.IconMarginLeft = 0;
            this.btn_phimle.IconMarginRight = 0;
            this.btn_phimle.IconRightVisible = true;
            this.btn_phimle.IconRightZoom = 0D;
            this.btn_phimle.IconVisible = true;
            this.btn_phimle.IconZoom = 50D;
            this.btn_phimle.IsTab = false;
            this.btn_phimle.Location = new System.Drawing.Point(170, 0);
            this.btn_phimle.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_phimle.Name = "btn_phimle";
            this.btn_phimle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_phimle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_phimle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_phimle.selected = false;
            this.btn_phimle.Size = new System.Drawing.Size(172, 48);
            this.btn_phimle.TabIndex = 7;
            this.btn_phimle.Text = "Phim Lẻ";
            this.btn_phimle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_phimle.Textcolor = System.Drawing.Color.Black;
            this.btn_phimle.TextFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_phimmoi
            // 
            this.btn_phimmoi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_phimmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_phimmoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_phimmoi.BorderRadius = 0;
            this.btn_phimmoi.ButtonText = "Phim mới";
            this.btn_phimmoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_phimmoi.DisabledColor = System.Drawing.Color.Gray;
            this.btn_phimmoi.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_phimmoi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_phimmoi.Iconimage")));
            this.btn_phimmoi.Iconimage_right = null;
            this.btn_phimmoi.Iconimage_right_Selected = null;
            this.btn_phimmoi.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btn_phimmoi.Iconimage_Selected")));
            this.btn_phimmoi.IconMarginLeft = 0;
            this.btn_phimmoi.IconMarginRight = 0;
            this.btn_phimmoi.IconRightVisible = true;
            this.btn_phimmoi.IconRightZoom = 0D;
            this.btn_phimmoi.IconVisible = true;
            this.btn_phimmoi.IconZoom = 50D;
            this.btn_phimmoi.IsTab = false;
            this.btn_phimmoi.Location = new System.Drawing.Point(342, 0);
            this.btn_phimmoi.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_phimmoi.Name = "btn_phimmoi";
            this.btn_phimmoi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_phimmoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_phimmoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_phimmoi.selected = false;
            this.btn_phimmoi.Size = new System.Drawing.Size(173, 48);
            this.btn_phimmoi.TabIndex = 8;
            this.btn_phimmoi.Text = "Phim mới";
            this.btn_phimmoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_phimmoi.Textcolor = System.Drawing.Color.Black;
            this.btn_phimmoi.TextFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_chieurap
            // 
            this.btn_chieurap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_chieurap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_chieurap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chieurap.BorderRadius = 0;
            this.btn_chieurap.ButtonText = "Phim chiếu rạp";
            this.btn_chieurap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chieurap.DisabledColor = System.Drawing.Color.Gray;
            this.btn_chieurap.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_chieurap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_chieurap.Iconimage")));
            this.btn_chieurap.Iconimage_right = null;
            this.btn_chieurap.Iconimage_right_Selected = null;
            this.btn_chieurap.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btn_chieurap.Iconimage_Selected")));
            this.btn_chieurap.IconMarginLeft = 0;
            this.btn_chieurap.IconMarginRight = 0;
            this.btn_chieurap.IconRightVisible = true;
            this.btn_chieurap.IconRightZoom = 0D;
            this.btn_chieurap.IconVisible = true;
            this.btn_chieurap.IconZoom = 50D;
            this.btn_chieurap.IsTab = false;
            this.btn_chieurap.Location = new System.Drawing.Point(515, 0);
            this.btn_chieurap.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_chieurap.Name = "btn_chieurap";
            this.btn_chieurap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.btn_chieurap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_chieurap.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_chieurap.selected = false;
            this.btn_chieurap.Size = new System.Drawing.Size(173, 48);
            this.btn_chieurap.TabIndex = 10;
            this.btn_chieurap.Text = "Phim chiếu rạp";
            this.btn_chieurap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_chieurap.Textcolor = System.Drawing.Color.Black;
            this.btn_chieurap.TextFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 10;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Tìm Kiếm";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(935, 2);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(90, 41);
            this.bunifuThinButton21.TabIndex = 12;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(700, 13);
            this.bunifuCustomTextbox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(226, 20);
            this.bunifuCustomTextbox1.TabIndex = 13;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_chieurap;
        private Bunifu.Framework.UI.BunifuFlatButton btn_phimmoi;
        private Bunifu.Framework.UI.BunifuFlatButton btn_phimle;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
    }
}
