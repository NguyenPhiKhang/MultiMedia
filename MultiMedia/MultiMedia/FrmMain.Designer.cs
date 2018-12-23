namespace MultiMedia
{
    partial class FrmMain
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.animator1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bntMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bntFoot = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntYTB = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntTV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntCinema = new Bunifu.Framework.UI.BunifuFlatButton();
            this.footBall = new MultiMedia.Football_module.Football();
            this.movie1 = new MultiMedia.Movie_module.Movie();
            this.tv1 = new MultiMedia.TV_module.TV();
            this.youtube1 = new MultiMedia.Youtube_module.youtube();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            // 
            // pnMenu
            // 
            this.pnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMenu.BackgroundImage")));
            this.pnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMenu.Controls.Add(this.bntMenu);
            this.pnMenu.Controls.Add(this.bunifuImageButton3);
            this.pnMenu.Controls.Add(this.bunifuImageButton1);
            this.pnMenu.Controls.Add(this.bntFoot);
            this.pnMenu.Controls.Add(this.bntYTB);
            this.pnMenu.Controls.Add(this.bntTV);
            this.pnMenu.Controls.Add(this.bntCinema);
            this.animator1.SetDecoration(this.pnMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnMenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnMenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Quality = 10;
            this.pnMenu.Size = new System.Drawing.Size(209, 726);
            this.pnMenu.TabIndex = 7;
            this.pnMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnMenu_MouseDown);
            this.pnMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMenu_MouseMove);
            this.pnMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnMenu_MouseUp);
            // 
            // bntMenu
            // 
            this.bntMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntMenu.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bntMenu, BunifuAnimatorNS.DecorationType.None);
            this.bntMenu.Image = ((System.Drawing.Image)(resources.GetObject("bntMenu.Image")));
            this.bntMenu.ImageActive = null;
            this.bntMenu.Location = new System.Drawing.Point(166, 3);
            this.bntMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntMenu.Name = "bntMenu";
            this.bntMenu.Size = new System.Drawing.Size(40, 40);
            this.bntMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntMenu.TabIndex = 3;
            this.bntMenu.TabStop = false;
            this.bntMenu.Zoom = 10;
            this.bntMenu.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(27, 3);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 2;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bntFoot
            // 
            this.bntFoot.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bntFoot.BackColor = System.Drawing.Color.Transparent;
            this.bntFoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntFoot.BorderRadius = 0;
            this.bntFoot.ButtonText = "   Football";
            this.bntFoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bntFoot, BunifuAnimatorNS.DecorationType.None);
            this.bntFoot.DisabledColor = System.Drawing.Color.Gray;
            this.bntFoot.Iconcolor = System.Drawing.Color.Transparent;
            this.bntFoot.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntFoot.Iconimage")));
            this.bntFoot.Iconimage_right = null;
            this.bntFoot.Iconimage_right_Selected = null;
            this.bntFoot.Iconimage_Selected = null;
            this.bntFoot.IconMarginLeft = 0;
            this.bntFoot.IconMarginRight = 0;
            this.bntFoot.IconRightVisible = true;
            this.bntFoot.IconRightZoom = 0D;
            this.bntFoot.IconVisible = true;
            this.bntFoot.IconZoom = 100D;
            this.bntFoot.IsTab = false;
            this.bntFoot.Location = new System.Drawing.Point(3, 352);
            this.bntFoot.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bntFoot.Name = "bntFoot";
            this.bntFoot.Normalcolor = System.Drawing.Color.Transparent;
            this.bntFoot.OnHovercolor = System.Drawing.Color.Transparent;
            this.bntFoot.OnHoverTextColor = System.Drawing.Color.Blue;
            this.bntFoot.selected = false;
            this.bntFoot.Size = new System.Drawing.Size(205, 50);
            this.bntFoot.TabIndex = 7;
            this.bntFoot.Text = "   Football";
            this.bntFoot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntFoot.Textcolor = System.Drawing.Color.White;
            this.bntFoot.TextFont = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntFoot.Click += new System.EventHandler(this.bntFoot_Click);
            // 
            // bntYTB
            // 
            this.bntYTB.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bntYTB.BackColor = System.Drawing.Color.Transparent;
            this.bntYTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntYTB.BorderRadius = 0;
            this.bntYTB.ButtonText = "  Youtube";
            this.bntYTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bntYTB, BunifuAnimatorNS.DecorationType.None);
            this.bntYTB.DisabledColor = System.Drawing.Color.Gray;
            this.bntYTB.Iconcolor = System.Drawing.Color.Transparent;
            this.bntYTB.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntYTB.Iconimage")));
            this.bntYTB.Iconimage_right = null;
            this.bntYTB.Iconimage_right_Selected = null;
            this.bntYTB.Iconimage_Selected = null;
            this.bntYTB.IconMarginLeft = 0;
            this.bntYTB.IconMarginRight = 0;
            this.bntYTB.IconRightVisible = true;
            this.bntYTB.IconRightZoom = 0D;
            this.bntYTB.IconVisible = true;
            this.bntYTB.IconZoom = 120D;
            this.bntYTB.IsTab = false;
            this.bntYTB.Location = new System.Drawing.Point(3, 278);
            this.bntYTB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bntYTB.Name = "bntYTB";
            this.bntYTB.Normalcolor = System.Drawing.Color.Transparent;
            this.bntYTB.OnHovercolor = System.Drawing.Color.Transparent;
            this.bntYTB.OnHoverTextColor = System.Drawing.Color.Blue;
            this.bntYTB.selected = false;
            this.bntYTB.Size = new System.Drawing.Size(206, 50);
            this.bntYTB.TabIndex = 6;
            this.bntYTB.Text = "  Youtube";
            this.bntYTB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntYTB.Textcolor = System.Drawing.Color.White;
            this.bntYTB.TextFont = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntYTB.Click += new System.EventHandler(this.bntYTB_Click);
            // 
            // bntTV
            // 
            this.bntTV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bntTV.BackColor = System.Drawing.Color.Transparent;
            this.bntTV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntTV.BorderRadius = 0;
            this.bntTV.ButtonText = "    TV Show";
            this.bntTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bntTV, BunifuAnimatorNS.DecorationType.None);
            this.bntTV.DisabledColor = System.Drawing.Color.Gray;
            this.bntTV.Iconcolor = System.Drawing.Color.Transparent;
            this.bntTV.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntTV.Iconimage")));
            this.bntTV.Iconimage_right = null;
            this.bntTV.Iconimage_right_Selected = null;
            this.bntTV.Iconimage_Selected = null;
            this.bntTV.IconMarginLeft = 0;
            this.bntTV.IconMarginRight = 0;
            this.bntTV.IconRightVisible = true;
            this.bntTV.IconRightZoom = 0D;
            this.bntTV.IconVisible = true;
            this.bntTV.IconZoom = 110D;
            this.bntTV.IsTab = false;
            this.bntTV.Location = new System.Drawing.Point(3, 199);
            this.bntTV.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bntTV.Name = "bntTV";
            this.bntTV.Normalcolor = System.Drawing.Color.Transparent;
            this.bntTV.OnHovercolor = System.Drawing.Color.Transparent;
            this.bntTV.OnHoverTextColor = System.Drawing.Color.Blue;
            this.bntTV.selected = false;
            this.bntTV.Size = new System.Drawing.Size(206, 50);
            this.bntTV.TabIndex = 5;
            this.bntTV.Text = "    TV Show";
            this.bntTV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntTV.Textcolor = System.Drawing.Color.White;
            this.bntTV.TextFont = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTV.Click += new System.EventHandler(this.bntTV_Click);
            // 
            // bntCinema
            // 
            this.bntCinema.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bntCinema.BackColor = System.Drawing.Color.Transparent;
            this.bntCinema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntCinema.BorderRadius = 0;
            this.bntCinema.ButtonText = "Cinema";
            this.bntCinema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bntCinema, BunifuAnimatorNS.DecorationType.None);
            this.bntCinema.DisabledColor = System.Drawing.Color.Gray;
            this.bntCinema.Iconcolor = System.Drawing.Color.Transparent;
            this.bntCinema.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntCinema.Iconimage")));
            this.bntCinema.Iconimage_right = null;
            this.bntCinema.Iconimage_right_Selected = null;
            this.bntCinema.Iconimage_Selected = null;
            this.bntCinema.IconMarginLeft = 0;
            this.bntCinema.IconMarginRight = 0;
            this.bntCinema.IconRightVisible = true;
            this.bntCinema.IconRightZoom = 0D;
            this.bntCinema.IconVisible = true;
            this.bntCinema.IconZoom = 130D;
            this.bntCinema.IsTab = false;
            this.bntCinema.Location = new System.Drawing.Point(3, 128);
            this.bntCinema.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bntCinema.Name = "bntCinema";
            this.bntCinema.Normalcolor = System.Drawing.Color.Transparent;
            this.bntCinema.OnHovercolor = System.Drawing.Color.Transparent;
            this.bntCinema.OnHoverTextColor = System.Drawing.Color.Blue;
            this.bntCinema.selected = false;
            this.bntCinema.Size = new System.Drawing.Size(206, 50);
            this.bntCinema.TabIndex = 4;
            this.bntCinema.Text = "Cinema";
            this.bntCinema.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntCinema.Textcolor = System.Drawing.Color.White;
            this.bntCinema.TextFont = new System.Drawing.Font("Snap ITC", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCinema.Click += new System.EventHandler(this.bntCinema_Click);
            // 
            // footBall
            // 
            this.footBall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.animator1.SetDecoration(this.footBall, BunifuAnimatorNS.DecorationType.None);
            this.footBall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footBall.Location = new System.Drawing.Point(209, 0);
            this.footBall.Name = "footBall";
            this.footBall.Size = new System.Drawing.Size(1037, 726);
            this.footBall.TabIndex = 8;
            // 
            // movie1
            // 
            this.movie1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.animator1.SetDecoration(this.movie1, BunifuAnimatorNS.DecorationType.None);
            this.movie1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movie1.Location = new System.Drawing.Point(209, 0);
            this.movie1.Name = "movie1";
            this.movie1.Size = new System.Drawing.Size(1037, 726);
            this.movie1.TabIndex = 9;
            // 
            // tv1
            // 
            this.tv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.animator1.SetDecoration(this.tv1, BunifuAnimatorNS.DecorationType.None);
            this.tv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv1.Location = new System.Drawing.Point(209, 0);
            this.tv1.Name = "tv1";
            this.tv1.Size = new System.Drawing.Size(1037, 726);
            this.tv1.TabIndex = 10;
            // 
            // youtube1
            // 
            this.youtube1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.animator1.SetDecoration(this.youtube1, BunifuAnimatorNS.DecorationType.None);
            this.youtube1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.youtube1.Location = new System.Drawing.Point(209, 0);
            this.youtube1.Name = "youtube1";
            this.youtube1.Size = new System.Drawing.Size(1037, 726);
            this.youtube1.TabIndex = 11;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1246, 726);
            this.Controls.Add(this.youtube1);
            this.Controls.Add(this.tv1);
            this.Controls.Add(this.movie1);
            this.Controls.Add(this.footBall);
            this.Controls.Add(this.pnMenu);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiMedia";
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bntMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition animator1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnMenu;
        private Bunifu.Framework.UI.BunifuImageButton bntMenu;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bntFoot;
        private Bunifu.Framework.UI.BunifuFlatButton bntYTB;
        private Bunifu.Framework.UI.BunifuFlatButton bntTV;
        private Bunifu.Framework.UI.BunifuFlatButton bntCinema;
        private Youtube_module.youtube youtube1;
        private TV_module.TV tv1;
        private Movie_module.Movie movie1;
        private Football_module.Football footBall;
        //private TV_module.TV tv1;
    }
}

