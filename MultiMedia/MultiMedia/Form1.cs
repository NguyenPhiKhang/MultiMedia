using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if(pnMenu.Width==58)
            {
                pnMenu.Visible = false;
                pnMenu.Width = 209;
                //bntMenu.Location = new Point(169, 3);
                bunifuImageButton1.Location = new Point(12, 12);
                bunifuImageButton2.Location = new Point(37, 13);
                bunifuImageButton3.Location = new Point(61, 13);
                animator1.ShowSync(pnMenu);
            }
            else
            {
                //bntMenu.Location = new Point(0, 0);
                pnMenu.Visible = false;
                pnMenu.Width = 58;
                bunifuImageButton1.Location = new Point(3, 46);
                bunifuImageButton2.Location = new Point(3, 71);
                bunifuImageButton3.Location = new Point(3, 95);
                animator1.ShowSync(pnMenu);
            }
        }
        private void bntColor()
        {
            bntCinema.Normalcolor = Color.FromArgb(26, 32, 40);
            bntTV.Normalcolor = Color.FromArgb(26, 32, 40);
            bntYTB.Normalcolor = Color.FromArgb(26, 32, 40);
            bntFoot.Normalcolor = Color.FromArgb(26, 32, 40);
            bntCinema.Textcolor = Color.White;
            bntTV.Textcolor = Color.White;
            bntYTB.Textcolor = Color.White;
            bntFoot.Textcolor = Color.White;
        }
        private void bntCinema_Click(object sender, EventArgs e)
        {
            bntColor();
            bntCinema.Normalcolor = Color.FromArgb(0, 102, 204);
            bntCinema.Textcolor = Color.Yellow;
        }

        private void bntTV_Click(object sender, EventArgs e)
        {
            bntColor();
            bntTV.Normalcolor = Color.FromArgb(0, 102, 204);
            bntTV.Textcolor = Color.Yellow;
        }

        private void bntYTB_Click(object sender, EventArgs e)
        {
            bntColor();
            bntYTB.Normalcolor = Color.FromArgb(0, 102, 204);
            bntYTB.Textcolor = Color.Yellow;
        }

        private void bntFoot_Click(object sender, EventArgs e)
        {
            bntColor();
            bntFoot.Normalcolor = Color.FromArgb(0, 102, 204);
            bntFoot.Textcolor = Color.Yellow;
        }
    }
}
