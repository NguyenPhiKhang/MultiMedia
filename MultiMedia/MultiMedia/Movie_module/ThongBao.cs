using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiMedia.Movie_module
{
    public partial class ThongBao : Form
    {
        public ThongBao()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Boolean flat;
        int x, y;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flat == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            flat = true;
            x = e.X;
            y = e.Y;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            flat = false;
        }
        private void TB_Deactivate(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkGray;
        }

        private void TB_Activated(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(3, 166, 255);
        }
    }
}
