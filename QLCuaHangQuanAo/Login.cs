using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLCuaHangQuanAo
{
    public partial class Login : Form
    {
        public static DTO.KHACHHANG kh = null;
        public static DTO.TAIKHOAN tk = null;
        public static int admin_user; //1. User, 0. Amin
        public Login()
        {
            InitializeComponent();
            admin_user = 1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool kq = DAO.TaiKhoanDAO.Instance.CheckUsername_Password(txtUsername.Text, txtPassword.Text);
            if (kq)
            {
                if (admin_user == 1)
                {
                    User_Login();
                }
                else
                {
                    Admin_Login();
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tài khoản hoặc mật khẩu.");
            }
        }

        private void Admin_Login()
        {
            tk = DAO.TaiKhoanDAO.Instance.LoadTK(txtUsername.Text);
            int id = DAO.TaiKhoanDAO.Instance.Getid_UserName(txtUsername.Text);
            int loaitk = DAO.TaiKhoanDAO.Instance.GetLoaiTK(txtUsername.Text);
            if (loaitk == 0)
            {
                kh = DAO.KhachHangDAO.Instance.LoadKH(id);
                PrgLogin.Value = 0;
                Gif_Logo.Visible = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tài khoản hoặc mật khẩu.");
            }
        }

        private void User_Login()
        {
            tk = DAO.TaiKhoanDAO.Instance.LoadTK(txtUsername.Text);
            int id = DAO.TaiKhoanDAO.Instance.Getid_UserName(txtUsername.Text);
            int loaitk = DAO.TaiKhoanDAO.Instance.GetLoaiTK(txtUsername.Text);
            if (loaitk == 1)
            {
                kh = DAO.KhachHangDAO.Instance.LoadKH(id);
                PrgLogin.Value = 0;
                Gif_Logo.Visible = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tài khoản hoặc mật khẩu.");
            }
        }

        private void pwshow_CheckedChanged(object sender, EventArgs e)
        {
            if (pwshow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PrgLogin.Visible = true;
            prg.Visible = true;
            PrgLogin.Increment(3);
            prg.Start();

            if (PrgLogin.ProgressPercentText == "100%")
            {
                timer1.Stop();
                this.Hide();
                UI_Home Home = new UI_Home();
                Home.Show();
            }
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void Admin_User_Lg_Click(object sender, EventArgs e)
        {
            if (Admin_User_Lg.Text == "Đăng nhập với quyền quản trị viên")
            {
                Admin_User_Lg.Text = "Đăng nhập với người dùng";
                btnAdmin_User.Text = "Quản trị viên";
                admin_user = 0;
            }
            else
            {
                Admin_User_Lg.Text = "Đăng nhập với quyền quản trị viên";
                btnAdmin_User.Text = "Khách hàng";
                admin_user = 1;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
