namespace MultiMedia.Youtube_module
{
    partial class item_ytb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(item_ytb));
            this.lbl_title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_image = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_url = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AllowDrop = true;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_title.Location = new System.Drawing.Point(3, 169);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(273, 58);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "SUÝT NỮA THÌ | OFFICIAL OST | CHUYẾN ĐI CỦA THANH XUÂN | ANDIEZ x BITI\'S HUNTER";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_title, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.44934F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.55066F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 227);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_url);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.btn_image);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 169);
            this.panel1.TabIndex = 2;
            // 
            // btn_image
            // 
            this.btn_image.BackColor = System.Drawing.Color.Transparent;
            this.btn_image.Image = ((System.Drawing.Image)(resources.GetObject("btn_image.Image")));
            this.btn_image.ImageActive = null;
            this.btn_image.Location = new System.Drawing.Point(3, 3);
            this.btn_image.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(271, 166);
            this.btn_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_image.TabIndex = 1;
            this.btn_image.TabStop = false;
            this.btn_image.Zoom = 10;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Black;
            this.lbl_time.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_time.Location = new System.Drawing.Point(223, 145);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(50, 15);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "0:00:00";
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.BackColor = System.Drawing.Color.Black;
            this.lbl_url.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_url.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_url.Location = new System.Drawing.Point(1, 3);
            this.lbl_url.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(0, 15);
            this.lbl_url.TabIndex = 3;
            this.lbl_url.Visible = false;
            // 
            // item_ytb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "item_ytb";
            this.Size = new System.Drawing.Size(279, 227);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_title;
        public Bunifu.Framework.UI.BunifuImageButton btn_image;
        public System.Windows.Forms.Label lbl_time;
        public System.Windows.Forms.Label lbl_url;
    }
}
