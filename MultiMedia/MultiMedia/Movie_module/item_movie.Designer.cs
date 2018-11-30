namespace MultiMedia.Movie_module
{
    partial class item_movie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(item_movie));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_realname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_avatar = new System.Windows.Forms.PictureBox();
            this.lbl_detail = new MultiMedia.LabelRoundCorners();
            this.lbl_url = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_realname, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 37);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(288, 18);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Đảo Hải Tặc - 1998";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_realname
            // 
            this.lbl_realname.AutoSize = true;
            this.lbl_realname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_realname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_realname.ForeColor = System.Drawing.Color.White;
            this.lbl_realname.Location = new System.Drawing.Point(0, 18);
            this.lbl_realname.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_realname.Name = "lbl_realname";
            this.lbl_realname.Size = new System.Drawing.Size(288, 19);
            this.lbl_realname.TabIndex = 1;
            this.lbl_realname.Text = "One Piece";
            this.lbl_realname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_avatar
            // 
            this.btn_avatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_avatar.Image = ((System.Drawing.Image)(resources.GetObject("btn_avatar.Image")));
            this.btn_avatar.Location = new System.Drawing.Point(0, 0);
            this.btn_avatar.Name = "btn_avatar";
            this.btn_avatar.Size = new System.Drawing.Size(288, 164);
            this.btn_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_avatar.TabIndex = 1;
            this.btn_avatar.TabStop = false;
            // 
            // lbl_detail
            // 
            this.lbl_detail._BackColor = System.Drawing.Color.Red;
            this.lbl_detail.AutoSize = true;
            this.lbl_detail.BackColor = System.Drawing.Color.Red;
            this.lbl_detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_detail.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_detail.Location = new System.Drawing.Point(0, 0);
            this.lbl_detail.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_detail.Name = "lbl_detail";
            this.lbl_detail.Size = new System.Drawing.Size(40, 17);
            this.lbl_detail.TabIndex = 2;
            this.lbl_detail.Text = "2018";
            this.lbl_detail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.BackColor = System.Drawing.Color.Black;
            this.lbl_url.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_url.Location = new System.Drawing.Point(3, 4);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(0, 13);
            this.lbl_url.TabIndex = 3;
            // 
            // item_movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.lbl_detail);
            this.Controls.Add(this.btn_avatar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "item_movie";
            this.Size = new System.Drawing.Size(288, 201);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public LabelRoundCorners lbl_detail;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_name;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_realname;
        public System.Windows.Forms.PictureBox btn_avatar;
        public System.Windows.Forms.Label lbl_url;
    }
}
