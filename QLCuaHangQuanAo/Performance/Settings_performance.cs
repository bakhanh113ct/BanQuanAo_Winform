using QLCuaHangQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo
{
    public partial class Settings_performance : Form
    {
        List<Control> list;
        DataTable ListHD;
        public Settings_performance()   
        {
            InitializeComponent();
        }
        private void Settings_performance_Load(object sender, EventArgs e)
        {
            //Note **SỬa phần database IDUSERNAME trùng
            if (Login.tk.Typetk != 0)
            {
                ListHD = DAO.HoaDonDAO.Instance.LoadHDtoDatatable(Login.kh.MaKH.ToString());
                
                dtgv.DataSource = new BindingSource(ListHD, "");
                Loadform();
            }
            //cbDay.DataSource = Enumerable.Range(1, DateTime.DaysInMonth(DateTime.Now.Year, Convert.ToInt32(cbMonth.SelectedValue)));
        }

        private void Loadform()
        {
            txbName.Text = Login.kh.HoTen;
            lbName.Text = txbName.Text;
            txbUserName.Text = Login.tk.Username;
            txbAddress.Text = Login.kh.DiaChi;
            txbPhone.Text = Login.kh.SoDT;
            txbEmail.Text = Login.kh.Email;
            cbYear.DataSource = (Enumerable.Range(1950, DateTime.Now.Year).ToList());
            cbMonth.SelectedItem = Login.kh.NgSinh.Month.ToString();
            cbDay.SelectedItem = Login.kh.NgSinh.Day.ToString();
            cbYear.Text = "";
            cbYear.SelectedText = Login.kh.NgSinh.Year.ToString();
            if (Login.kh.Anh != null)
            {
                Avatar.Image = Library.ConvertoImage(Login.kh.Anh);
                picAvatar.Image = Avatar.Image;
                Avatar.SizeMode = PictureBoxSizeMode.Zoom;
                picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                //Ảnh thay thế
                if (Login.kh.Gioitinh == 1)
                {
                    picAvatar.Image = Properties.Resources.male_User;
                    Avatar.Image = Properties.Resources.male_User;
                }
                else
                {
                    picAvatar.Image = Properties.Resources.female_User;
                    Avatar.Image = Properties.Resources.female_User;
                }
            }
        }

        private void guna2TabControl1_Click(object sender, EventArgs e)
        {
            //if(guna2TabControl1.TabIndex == tabPage4.)
            //{
            //    Application.Exit();
            //}
            if(guna2TabControl1.SelectedTab == tabPage3)
            {
                ListHD = DAO.HoaDonDAO.Instance.LoadHDtoDatatable(Login.kh.MaKH.ToString());
                dtgv.DataSource = ListHD;
            }
            else if (guna2TabControl1.SelectedTab == tabPage4)
            {
                DialogResult kq = MessageBox.Show("Ban co muon dang xuat?", "Thong bao", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    MessageBox.Show("DX TC");
                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        if (Application.OpenForms[i].Name != "Menu")
                            Application.OpenForms[i].Hide();
                    }
                    Login newLogin = new Login();
                    newLogin.Show();
                }

            }
        }
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            Library.LoadFromDialog(picAvatar);
        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            if (list == null)
                list = new List<Control>();
            foreach (Control i in tabPage1.Controls)
            {
                if (i.Enabled == false)
                {
                    i.Enabled = true;
                    list.Add(i);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] anh = Library.ConvertoByte(picAvatar.Image);
            DTO.KHACHHANG kh = new DTO.KHACHHANG(Login.kh.MaKH, Login.kh.IdUsername, txbName.Text, txbAddress.Text, txbPhone.Text, new DateTime(Convert.ToInt32(cbYear.Text), Convert.ToInt32(cbMonth.Text), Convert.ToInt32(cbDay.Text)), Login.kh.Gioitinh, anh == null ? null : anh, txbEmail.Text);
            if (DAO.KhachHangDAO.Instance.Update(kh))
            {
                MessageBox.Show("Cập nhật thành công");
                Login.kh = kh;
                Loadform();
                if (list != null)
                    foreach (Control i in list)
                    {
                        i.Enabled = false;
                    }
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }

        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            foreach (Control i in tabPage2.Controls)
            {
                if (i.GetType().Name == "Guna2TextBox")
                {
                    Guna.UI2.WinForms.Guna2TextBox k = i as Guna.UI2.WinForms.Guna2TextBox;
                    if (k.Text == "")
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                        return;
                    }
                }
            }

            if (txbOldPass.Text != Login.tk.Password)
                MessageBox.Show("Sai mật khẩu");
            else if (txbNewPass.Text != txbCfPass.Text)
                MessageBox.Show("2 mật khẩu không khớp");
            else if (DAO.TaiKhoanDAO.Instance.ChangePassword(Login.kh.IdUsername.ToString(), txbNewPass.Text))
                MessageBox.Show("Thay đổi thành công");
            else
                MessageBox.Show("Thay đổi thất bại");
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView currentDataRowView = (DataRowView)dtgv.CurrentRow.DataBoundItem;
            int index = dtgv.SelectedRows[0].Index;
            DataRow row = currentDataRowView.Row;
            //if(row == dtgv.Rowhead)
            SubForm.Product_Bill product_Bill = new SubForm.Product_Bill(row["SOHD"].ToString());
            product_Bill.ShowDialog();
        }
    }
}
