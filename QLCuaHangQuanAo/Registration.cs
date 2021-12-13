using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo
{
    public partial class Registration : Form
    {
        List<Guna.UI2.WinForms.Guna2TextBox> listtb;
        public Registration()
        {
            InitializeComponent();
            listtb = new List<Guna.UI2.WinForms.Guna2TextBox>();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            listtb.Add(tbFullName);
            listtb.Add(tbUserName);
            listtb.Add(tbPhone);
            listtb.Add(tbPassword);
            listtb.Add(tbCfPassword);
            listtb.Add(tbAddress);
            listtb.Add(tbEmail);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            foreach (Guna.UI2.WinForms.Guna2TextBox u in listtb)
            {
                if (u.Text == "" || (rdMale.Checked == false && rdFemale.Checked == false && rdOther.Checked == false))
                {
                    MessageBox.Show("Điền đầy đủ thông tin");
                    return;
                }
            }
            if (tbPassword.Text != tbCfPassword.Text)
            {
                MessageBox.Show("Mật khẩu không đúng");
                return;
            }
            if (DAO.TaiKhoanDAO.Instance.CheckUserNameExists(tbUserName.Text))
                MessageBox.Show("Tên tài khoản đã tồn tại");
            else
            {
                int idtk = DAO.TaiKhoanDAO.Instance.GetIdMax();
                DTO.TAIKHOAN tk = new DTO.TAIKHOAN(idtk, tbFullName.Text, tbUserName.Text, tbPassword.Text, 1);
                if (DAO.TaiKhoanDAO.Instance.InsertAccount(tk))
                {
                    if (idtk == 0)
                    {
                        idtk = DAO.TaiKhoanDAO.Instance.GetIdMax() - 1;
                    }

                    int idkh = DAO.KhachHangDAO.Instance.GetIdMax();
                    int gt = GetGioiTinh();

                    DTO.KHACHHANG kh = new DTO.KHACHHANG(idkh, idtk + 1, tbFullName.Text, tbAddress.Text, tbPhone.Text, pickerBirthday.Value.Date.ToString("yyyy/MM/dd"), gt, null, tbEmail.Text);

                    if (DAO.KhachHangDAO.Instance.InsertKH(kh))
                    {
                        MessageBox.Show("Đăng kí thành công.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng kí thất bại.");
                        DAO.TaiKhoanDAO.Instance.DeleteAccount();
                    }
                }
                else
                    MessageBox.Show("Đăng kí thất bại.");
            }
        }

        private int GetGioiTinh()
        {
            if (rdMale.Checked == true)
                return 1;
            else if (rdFemale.Checked == true)
                return 0;
            else return 2;
        }
    }
}
