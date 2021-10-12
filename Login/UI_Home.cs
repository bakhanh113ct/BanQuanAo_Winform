using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class UI_Home : Form
    {
        List<Panel> subbar = new List<Panel>();
        public UI_Home()
        {
            InitializeComponent();
            AddSubbar();
        }

        private void subbar_Visible(Panel a)
        {
            foreach (Panel x in subbar)
            {
                x.Visible = false;
            }
            a.Visible = true;
        }

        private void AddSubbar()
        {
            subbar.Add(subbar1);
            subbar.Add(subbar2);
            subbar.Add(subbar3);
            subbar.Add(subbar4);
            subbar.Add(subbar5);
            subbar.Add(subbar6);

        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            subbar_Visible(subbar1);
        }

        private void STORE_Click(object sender, EventArgs e)
        {
            subbar_Visible(subbar2);
        }

        private void PARTNER_Click(object sender, EventArgs e)
        {
            subbar_Visible(subbar3);
        }

        private void CUSTOMER_Click(object sender, EventArgs e)
        {
            subbar_Visible(subbar4);
        }

        private void ANALYSIS_Click(object sender, EventArgs e)
        {
            subbar_Visible(subbar5);
        }

        private void SETTING_Click(object sender, EventArgs e)
        {
            subbar_Visible(subbar6);
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/long.deptraiso1");
        }

        private void twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/?lang=vi");
        }

        private void instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }
    }
}
