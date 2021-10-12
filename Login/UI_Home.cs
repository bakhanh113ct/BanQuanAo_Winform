using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace Login
{
    public partial class UI_Home : Form
    {
        List<Panel> subbar = new List<Panel>();
        List<Guna2Button> Home_button = new List<Guna2Button>(); 
        public UI_Home()
        {
            InitializeComponent();
            AddSubbarandHomeButton();
        }

        private void subbar_Change(Panel panel, Guna.UI2.WinForms.Guna2Button button)
        {
            foreach (Panel x in subbar)
            {
                x.Visible = false;
            }
            foreach (Guna2Button x in Home_button)
            {
                x.ForeColor = Color.Black;
            }
            panel.Visible = true;
            button.ForeColor = Color.Fuchsia;
        }

        private void AddSubbarandHomeButton()
        {
            subbar.Add(subbar1);
            subbar.Add(subbar2);
            subbar.Add(subbar3);
            subbar.Add(subbar4);
            subbar.Add(subbar5);
            subbar.Add(subbar6);
            Home_button.Add(HOME);
            Home_button.Add(STORE);
            Home_button.Add(PARTNER);
            Home_button.Add(CUSTOMER);
            Home_button.Add(ANALYSIS);
            Home_button.Add(SETTING);
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
            subbar_Change(subbar1, HOME);
        }

        private void STORE_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar2, STORE);
        }

        private void PARTNER_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar3, PARTNER);
        }

        private void CUSTOMER_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar4, CUSTOMER);
        }

        private void ANALYSIS_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar5, ANALYSIS);
        }

        private void SETTING_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar6, SETTING);
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
