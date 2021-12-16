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
using QLCuaHangQuanAo.Performance;

namespace QLCuaHangQuanAo
{
    public partial class UI_Home : Form
    {
        static public List<Control_User.Item> ListItem;
        List<Panel> subbar = new List<Panel>();
        List<Guna2Button> Home_button = new List<Guna2Button>();
        private Form activeForm = null;
        public Store_performence store = null;
        private Statistics_perfomancecs statistics = null;
        private Customer_perfomances customer = null;
        private Home_perfomancecs home = null;
        private Settings_performance setting = null;
        public UI_Home()
        {
            InitializeComponent();
            AddSubbarandHomeButton();
            ListItem = new List<Control_User.Item>();
            subbar_Change(subbar1, HOME);
        }

        private void UI_Home_Load(object sender, EventArgs e)
        {
            store = new Store_performence();
            setting = new Settings_performance();
            home = new Home_perfomancecs(this, store);
            customer = new Customer_perfomances();
            time.Text = DateTime.Now.ToShortDateString();
            //statistics = new Statistics_perfomancecs();
            //invoice = new Invoice_performance();
            openPerformance(home);
            if (Login.tk.Typetk == 1)
            {
                btnINVOICE.Visible = false;
                CUSTOMER.Visible = false;
            }
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
            Home_button.Add(btnINVOICE);
            Home_button.Add(STATISTIC);
            Home_button.Add(CUSTOMER);
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

        public void StoreOpenPerformance(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            SubProgram.Controls.Add(childForm);
            SubProgram.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            subbar_Change(subbar2, STORE);
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
            Library.sound_Click();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
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
            openPerformance(new Invoice_performance());
        }

        private void STATISTIC_Click(object sender, EventArgs e)
        {
            if (Login.tk.Typetk == 1)
                subbar_Change(subbar3, STATISTIC);
            else 
                subbar_Change(subbar4, STATISTIC);
            openPerformance(new Statistics_perfomancecs());
        }
        private void CUSTOMER_Click(object sender, EventArgs e)
        {
            subbar_Change(subbar5, CUSTOMER);
            openPerformance(customer);
        }
        private void SETTING_Click(object sender, EventArgs e)
        {
            if (Login.tk.Typetk == 1)
            {
                subbar4.BringToFront();
                subbar_Change(subbar4, SETTING);
            }
            else
                subbar_Change(subbar6, SETTING);
            openPerformance(setting);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                //MessageBox.Show("Đăng xuất thành công");
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms.Count <= i)
                        i = Application.OpenForms.Count - 1;
                    if (Application.OpenForms[i].Name != "Login")
                        Application.OpenForms[i].Close();
                }
                Login newLogin = new Login();
                newLogin.Show();
            }
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

        private void MyLogo_Click(object sender, EventArgs e)
        {
            Library.sound_Click();
            SubForm.Show_creator creator = new SubForm.Show_creator();
            creator.ShowDialog();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
