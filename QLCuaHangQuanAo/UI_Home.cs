using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace QLCuaHangQuanAo
{
    public partial class UI_Home : Form
    {
        public static List<Control_User.Item> ListItem;
        List<Panel> subbar = new List<Panel>();
        List<Guna2Button> Home_button = new List<Guna2Button>();
        private Form activeForm = null;
        public static Store_performence store = null;
        private Home_perfomancecs home = null;
        private Invoice_performance invoice = null;
        private Settings_performance setting = null;
        public UI_Home(DTO.KHACHHANG kh)
        {
            InitializeComponent();
            home = new Home_perfomancecs();
            AddSubbarandHomeButton();
            ListItem = new List<Control_User.Item>();
            subbar_Change(subbar1, HOME);
            openPerformance(home);
          
        }

        private void UI_Home_Load(object sender, EventArgs e)
        {
            store = new Store_performence();
            invoice = new Invoice_performance();
            setting = new Settings_performance();
        }

       
        private void AddSubbarandHomeButton()
        {
            subbar.Add(subbar1);
            subbar.Add(subbar2);
            subbar.Add(subbar3);
            subbar.Add(subbar4);
            Home_button.Add(HOME);
            Home_button.Add(STORE);
            Home_button.Add(btnINVOICE);
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
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        

        private void HOME_Click(object sender, EventArgs e)
        {
            DAO.Sound.Instance.sound_Click();
            subbar_Change(subbar1, HOME);
            openPerformance(home);
        }

        private void STORE_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar2, STORE);
            openPerformance(store);
        }

        private void btnINVOICE_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar3, btnINVOICE);
            openPerformance(invoice);

            DAO.Sound.Instance.sound_Click();
        }

        private void SETTING_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar4, SETTING);
            openPerformance(setting);
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
           // MyLogo.FillColor = Color.White;
        }

    }
}
