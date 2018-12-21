using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
namespace MultiMedia.Football_module
{
   
    public partial class Football : UserControl
    {
        List<string> logo1 = new List<string>();
        List<string> logo2 = new List<string>();
        List<string> time = new List<string>();
        List<string> team = new List<string>();
        List<string> leage = new List<string>();
        List<string> link1 = new List<string>();
        List<string> link2 = new List<string>();
        List<string> link3 = new List<string>();
        List<ItemMatch> itemMatches = new List<ItemMatch>();
        public Football()
        {
            InitializeComponent();
            crawData();
            int sotran = logo1.Count;
            for (int i = 0; i < sotran; i++)
            {
                ItemMatch itemMatch = new ItemMatch();
                //itemMatch.BackColor = Color.Transparent;

                //itemMatch.ptb_team1.Tag = i.ToString();
                //itemMatch.ptb_team2.Tag = i.ToString();
                //itemMatch.txtTime.Tag = i.ToString();
                //itemMatch.txtTeam.Tag = i.ToString();
                //itemMatch.txtLeage.Tag = i.ToString();

                itemMatch.Tag = i.ToString();
                itemMatch.txtLeage.Tag = i.ToString();
                itemMatch.txtTeam.Tag = i.ToString();
                itemMatch.txtTime.Tag = i.ToString();
                itemMatch.ptb_team1.Tag = i.ToString();
                itemMatch.ptb_team2.Tag = i.ToString();

                itemMatch.ptb_team1.ImageLocation = logo1[i];
                //itemMatch.ptb_team1.SizeMode = PictureBoxSizeMode.StretchImage;
                itemMatch.ptb_team2.ImageLocation = logo2[i];
                //itemMatch.ptb_team2.SizeMode = PictureBoxSizeMode.StretchImage;
                itemMatch.txtTime.Text = time[i];
                itemMatch.txtTeam.Text = team[i];
                itemMatch.txtLeage.Text = leage[i];
                itemMatches.Add(itemMatch);
                flowLayoutPanel1.Controls.Add(itemMatch);

                itemMatch.Click += Click1;
                itemMatch.ptb_team1.Click += Click5;
                itemMatch.ptb_team2.Click += Click6;
                itemMatch.txtLeage.Click += Click2;
                itemMatch.txtTeam.Click += Click3;
                itemMatch.txtTime.Click += Click4;

            }

        }
        int KTYTB(string a)
        {
            return a.IndexOf("youtube");
        }
        void ShowVlc(string url, string name)
        {
            Movie_module.FrmVLC frmVlc = new Movie_module.FrmVLC(url);
            frmVlc.lbl_name_video.Text = name.ToString();
            frmVlc.btn_Pause.Visible = false;
            frmVlc.btn_play.Visible = false;
            frmVlc.btn_Stop.Visible = false;
            frmVlc.btn_play_vlc.Visible = false;
            //frmVLC.StartPosition = FormStartPosition.CenterScreen;
            frmVlc.Show();
        }
        void Click1(object sender, EventArgs e)
        {
            ItemMatch item = sender as ItemMatch;
            int a = Convert.ToInt32(item.Tag.ToString());
            if (KTYTB(link1[a]) >= 0) link1[a] = "0";
            //Movie_module.FrmVLC frmVLC = new Movie_module.FrmVLC(link1[a]);
            //frmVLC.StartPosition = FormStartPosition.CenterScreen;
            //frmVLC.Show();
            ShowVlc(link1[a], team[a]);
        }

        void Click2(object sender, EventArgs e)
        {
            Label item = sender as Label;
            int a = Convert.ToInt32(item.Tag.ToString());
            if (KTYTB(link1[a]) >= 0) link1[a] = "0";
            //Movie_module.FrmVLC frmVLC = new Movie_module.FrmVLC(link1[a]);
            //frmVLC.StartPosition = FormStartPosition.CenterScreen;
            //frmVLC.Show();
            ShowVlc(link1[a], team[a]);
        }

        void Click3(object sender, EventArgs e)
        {
            Label item = sender as Label;
            int a = Convert.ToInt32(item.Tag.ToString());
            if (KTYTB(link1[a]) >= 0) link1[a] = "0";
            //Movie_module.FrmVLC frmVLC = new Movie_module.FrmVLC(link1[a]);
            //frmVLC.StartPosition = FormStartPosition.CenterScreen;
            //frmVLC.Show();
            ShowVlc(link1[a], team[a]);
        }

        void Click4(object sender, EventArgs e)
        {
            Label item = sender as Label;
            int a = Convert.ToInt32(item.Tag.ToString());
            if (KTYTB(link1[a]) >= 0) link1[a] = "0";
            //Movie_module.FrmVLC frmVLC = new Movie_module.FrmVLC(link1[a]);
            //frmVLC.StartPosition = FormStartPosition.CenterScreen;
            //frmVLC.Show();
            ShowVlc(link1[a], team[a]);
        }

        void Click5(object sender, EventArgs e)
        {
            PictureBox item = sender as PictureBox;
            int a = Convert.ToInt32(item.Tag.ToString());
            if (KTYTB(link1[a]) >= 0) link1[a] = "0";
            //Movie_module.FrmVLC frmVLC = new Movie_module.FrmVLC(link1[a]);
            //frmVLC.StartPosition = FormStartPosition.CenterScreen;
            //frmVLC.Show();
            ShowVlc(link1[a], team[a]);
        }

        void Click6(object sender, EventArgs e)
        {
            PictureBox item = sender as PictureBox;
            int a = Convert.ToInt32(item.Tag.ToString());
            if (KTYTB(link1[a]) >= 0) link1[a] = "0";
            //Movie_module.FrmVLC frmVLC = new Movie_module.FrmVLC(link1[a]);
            //frmVLC.StartPosition = FormStartPosition.CenterScreen;
            //frmVLC.Show();
            ShowVlc(link1[a], team[a]);
        }

        private void crawData()
        {
            try
            {
                string url = "http://xemmienphi.xyz/tructiep.html";
                HtmlWeb hw = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = hw.Load(url);
                HtmlNodeCollection newsitemlogo1 = doc.DocumentNode.SelectNodes("//div[@class='0']");
                HtmlNodeCollection newsitemlogo2 = doc.DocumentNode.SelectNodes("//div[@class='1']");
                HtmlNodeCollection newsitemtime = doc.DocumentNode.SelectNodes("//div[@class='2']");
                HtmlNodeCollection newsitemteam = doc.DocumentNode.SelectNodes("//div[@class='3']");
                HtmlNodeCollection newsitemleage = doc.DocumentNode.SelectNodes("//div[@class='5']");
                HtmlNodeCollection newsitemlink1 = doc.DocumentNode.SelectNodes("//div[@class='6']");
                HtmlNodeCollection newsitemlink2 = doc.DocumentNode.SelectNodes("//div[@class='7']");
                HtmlNodeCollection newsitemlink3 = doc.DocumentNode.SelectNodes("//div[@class='8']");

                foreach (var item in newsitemlogo1)
                {
                    logo1.Add(item.InnerHtml);
                }
                foreach (var item in newsitemlogo2)
                {
                    logo2.Add(item.InnerHtml);
                }
                foreach (var item in newsitemtime)
                {
                    time.Add(item.InnerText.Replace("\n", " "));
                }
                foreach (var item in newsitemteam)
                {
                    team.Add(item.InnerText);
                }
                foreach (var item in newsitemleage)
                {
                    leage.Add(item.InnerText);
                }
                foreach (var item in newsitemlink1)
                {
                    link1.Add(item.InnerHtml);
                }
                foreach (var item in newsitemlink2)
                {
                    link2.Add(item.InnerHtml);
                }
                foreach (var item in newsitemlink3)
                {
                    link3.Add(item.InnerHtml);
                }
            }
            catch
            {

            }

        }
    }
    
}
