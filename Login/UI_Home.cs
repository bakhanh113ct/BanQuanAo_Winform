using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace Login
{
    public partial class UI_Home : Form
    {
        public static List<Control_User.Item> ListItem;
        List<Panel> subbar = new List<Panel>();
        List<Guna2Button> Home_button = new List<Guna2Button>();
        private Form activeForm = null;
        public static Store_performence store = null;
        private Home_perfomancecs home = null;
        private Partner_performance partner = null;
        public UI_Home()
        {
            InitializeComponent();
            AddSubbarandHomeButton();
            ListItem = new List<Control_User.Item>();
        }

        private void UI_Home_Load(object sender, EventArgs e)
        {
            partner = new Partner_performance();
            store = new Store_performence();
            //DBA.Reload("select * from SanPham");
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
       
        private void openPerformance(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            SubProgram.Controls.Add(childForm);
            SubProgram.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                x.FillColor = Color.White;
            }
            panel.Visible = true;
            button.ForeColor = Color.FromArgb(216, 19, 248);
            button.FillColor = Color.FromArgb(251, 237, 251);
            txtPerformance.Text = "> " + button.Text;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar1, HOME);
            openPerformance(new Home_perfomancecs());
        }

        private void STORE_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar2, STORE);
            openPerformance(store);
        }

        private void PARTNER_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar3, PARTNER);
            openPerformance(partner);
        }

        private void CUSTOMER_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar4, CUSTOMER);
            openPerformance(new Customer_performance());
        }

        private void ANALYSIS_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar5, ANALYSIS);
            openPerformance(new Analysis_performance());
        }

        private void SETTING_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar6, SETTING);
            openPerformance(new Settings_performance());
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

        private void MyLogo_MouseHover(object sender, EventArgs e)
        {
            MyLogo.FillColor = Color.White;
        }

        private void zooe_in_out_Click(object sender, EventArgs e)
        {

        }
        
    }
}
