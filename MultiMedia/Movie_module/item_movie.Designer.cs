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
            this.btn_avatar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_status = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_realname = new System.Windows.Forms.Label();
            this.lbl_url = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_year = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_avatar
            // 
            this.btn_avatar.BackColor = System.Drawing.Color.Transparent;
            this.btn_avatar.Image = ((System.Drawing.Image)(resources.GetObject("btn_avatar.Image")));
            this.btn_avatar.ImageActive = null;
            this.btn_avatar.Location = new System.Drawing.Point(0, 0);
            this.btn_avatar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_avatar.Name = "btn_avatar";
            this.btn_avatar.Size = new System.Drawing.Size(226, 262);
            this.btn_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_avatar.TabIndex = 10;
            this.btn_avatar.TabStop = false;
            this.btn_avatar.Zoom = 10;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.Red;
            this.lbl_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_status.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_status.Location = new System.Drawing.Point(3, 9);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(49, 15);
            this.lbl_status.TabIndex = 11;
            this.lbl_status.Text = "Vietsub";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_realname
            // 
            this.lbl_realname.ForeColor = System.Drawing.Color.Silver;
            this.lbl_realname.Location = new System.Drawing.Point(0, 306);
            this.lbl_realname.Name = "lbl_realname";
            this.lbl_realname.Size = new System.Drawing.Size(226, 19);
            this.lbl_realname.TabIndex = 7;
            this.lbl_realname.Text = "One Piece";
            this.lbl_realname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_url.Location = new System.Drawing.Point(3, 0);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(0, 13);
            this.lbl_url.TabIndex = 12;
            this.lbl_url.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(171)))), ((int)(((byte)(26)))));
            this.lbl_name.Location = new System.Drawing.Point(0, 262);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(226, 41);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "Đảo Hải Tặc - 1998";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.BackColor = System.Drawing.Color.Red;
            this.lbl_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_year.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_year.Location = new System.Drawing.Point(3, 237);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(35, 15);
            this.lbl_year.TabIndex = 14;
            this.lbl_year.Text = "2018";
            this.lbl_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item_movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_avatar);
            this.Controls.Add(this.lbl_realname);
            this.Name = "item_movie";
            this.Size = new System.Drawing.Size(226, 325);
            ((System.ComponentModel.ISupportInitialize)(this.btn_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.Framework.UI.BunifuImageButton btn_avatar;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_status;
        public System.Windows.Forms.Label lbl_realname;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_url;
        public System.Windows.Forms.Label lbl_name;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_year;
    }
}
