namespace MultiMedia.Football_module
{
    partial class ItemMatch
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTime = new System.Windows.Forms.Label();
            this.txtTeam = new System.Windows.Forms.Label();
            this.txtLeage = new System.Windows.Forms.Label();
            this.ptb_team1 = new System.Windows.Forms.PictureBox();
            this.ptb_team2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_team1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_team2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.53398F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.46602F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ptb_team1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ptb_team2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 97);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(99, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 91);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.txtTime, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtTeam, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtLeage, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(516, 91);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Blue;
            this.txtTime.Location = new System.Drawing.Point(3, 60);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(510, 21);
            this.txtTime.TabIndex = 11;
            this.txtTime.Text = "02/12/2018 - 18:30";
            this.txtTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTeam
            // 
            this.txtTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeam.AutoSize = true;
            this.txtTeam.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam.ForeColor = System.Drawing.Color.Crimson;
            this.txtTeam.Location = new System.Drawing.Point(3, 0);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(510, 28);
            this.txtTeam.TabIndex = 10;
            this.txtTeam.Text = "VietNam - Philippines";
            this.txtTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLeage
            // 
            this.txtLeage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLeage.AutoSize = true;
            this.txtLeage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeage.ForeColor = System.Drawing.Color.LightGray;
            this.txtLeage.Location = new System.Drawing.Point(3, 30);
            this.txtLeage.Name = "txtLeage";
            this.txtLeage.Size = new System.Drawing.Size(510, 25);
            this.txtLeage.TabIndex = 7;
            this.txtLeage.Text = "AFF Cup 2018";
            this.txtLeage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptb_team1
            // 
            this.ptb_team1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_team1.Location = new System.Drawing.Point(3, 3);
            this.ptb_team1.Name = "ptb_team1";
            this.ptb_team1.Size = new System.Drawing.Size(90, 91);
            this.ptb_team1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_team1.TabIndex = 1;
            this.ptb_team1.TabStop = false;
            // 
            // ptb_team2
            // 
            this.ptb_team2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_team2.Location = new System.Drawing.Point(621, 3);
            this.ptb_team2.Name = "ptb_team2";
            this.ptb_team2.Size = new System.Drawing.Size(91, 91);
            this.ptb_team2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_team2.TabIndex = 2;
            this.ptb_team2.TabStop = false;
            // 
            // ItemMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ItemMatch";
            this.Size = new System.Drawing.Size(715, 97);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_team1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_team2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label txtTime;
        public System.Windows.Forms.Label txtTeam;
        public System.Windows.Forms.Label txtLeage;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.PictureBox ptb_team1;
        public System.Windows.Forms.PictureBox ptb_team2;
    }
}
