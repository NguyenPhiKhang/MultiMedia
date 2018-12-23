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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            youtube1.Visible = false;
            movie1.Visible = false;
            footBall.Visible = false;
            tv1.Visible = false;
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void bunifuImageButton2_Click(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Maximized)
        //        this.WindowState = FormWindowState.Normal;
        //    else this.WindowState = FormWindowState.Maximized;
        //}

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if(pnMenu.Width==58)
            {
                pnMenu.Visible = false;
                pnMenu.Width = 209;
                //bntMenu.Location = new Point(169, 3);
                bunifuImageButton1.Location = new Point(3, 3);
                //bunifuImageButton2.Location = new Point(37, 13);
                bunifuImageButton3.Location = new Point(27, 3);
                animator1.ShowSync(pnMenu);
            }
            else
            {
                //bntMenu.Location = new Point(0, 0);
                pnMenu.Visible = false;
                pnMenu.Width = 58;
                bunifuImageButton1.Location = new Point(3, 46);
                //bIbtn_Pause.Location = new Point(3, 71);
                bunifuImageButton3.Location = new Point(3, 71);
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
            movie1.Enabled = true;
            movie1.Visible = true;
            youtube1.Visible = false;
            youtube1.Enabled = false;
            footBall.Visible = false;
            footBall.Enabled = false;
            tv1.Visible = false;
            tv1.Enabled = false;
        }

        private void bntTV_Click(object sender, EventArgs e)
        {
            bntColor();
            bntTV.Normalcolor = Color.FromArgb(0, 102, 204);
            bntTV.Textcolor = Color.Yellow;
            tv1.Visible = true;
            tv1.Enabled = true;
            footBall.Visible = false;
            footBall.Enabled = false;
            youtube1.Visible = false;
            youtube1.Enabled = false;
            movie1.Enabled = false;
            movie1.Visible = false;
        }

        private void bntYTB_Click(object sender, EventArgs e)
        {
            bntColor();
            bntYTB.Normalcolor = Color.FromArgb(0, 102, 204);
            bntYTB.Textcolor = Color.Yellow;
            footBall.Visible = false;
            footBall.Enabled = false;
            youtube1.Visible = true;
            youtube1.Enabled = true;
            movie1.Enabled = false;
            movie1.Visible = false;
            tv1.Visible = false;
            tv1.Enabled = false;
        }

        private void bntFoot_Click(object sender, EventArgs e)
        {
            bntColor();
            bntFoot.Normalcolor = Color.FromArgb(0, 102, 204);
            bntFoot.Textcolor = Color.Yellow;
            footBall.Visible = true;
            footBall.Enabled = true;
            youtube1.Visible = false;
            youtube1.Enabled = false;
            movie1.Enabled = false;
            movie1.Visible = false;
            tv1.Enabled = false;
            tv1.Visible = false;
        }
        Boolean flag; int x, y;
        private void pnMenu_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void pnMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag==true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void pnMenu_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
    }
}
