using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo.SubForm
{
    public partial class TTKH : Form
    {
        public static List<Control_User.HDcuaKH> HD_KH = new List<Control_User.HDcuaKH>();
        private int MAKH = 0;
        public TTKH()
        {
            InitializeComponent();
        }
        public TTKH(int MAKH)
        {
            InitializeComponent();
            DataTable KH = DAO.KhachHangDAO.loadctkh(MAKH);
            
            foreach(DataRow x in KH.Rows)
            {
                DTO.KHACHHANG xx = new DTO.KHACHHANG(x);
                anhdd.Image = Library.ConvertoImage(xx.Anh) == null ? Properties.Resources.NoImage: Library.ConvertoImage(xx.Anh);
                ten.Text = "Họ và tên: " + xx.HoTen;
                if(xx.Gioitinh == 1)
                {
                    gt.Text = "Giới tính: Nam";
                }else gt.Text = "Giới tính: Nữ";

                sdt.Text = "SĐT: " + xx.SoDT;
                email.Text = "Email: " + xx.Email;
                dc.Text = "Địa chỉ: " + xx.DiaChi;
                makh.Text = "MAKH: 00" + xx.MaKH;
                tuoi.Text = "Tuổi: " + DAO.KhachHangDAO.Instance.gettuoi(MAKH);
                this.MAKH = MAKH;
            }
            Load(MAKH);
        }
        void Load(int makh)
        {
            HD_KH = DAO.HoaDonDAO.Instance.load_HD_KH(makh);
            foreach (Control_User.HDcuaKH x in HD_KH)
            {
                list_HD.Controls.Add(x);
                //x.thao_tac.Click += show_chi_tiet;//them sự kiện click cho Control_user 
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LH_Click(object sender, EventArgs e)
        {
            SubForm.SendEmail send = new SubForm.SendEmail(MAKH, 0);
            this.SendToBack();
            send.BringToFront();
            send.ShowDialog();
            this.BringToFront();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mật khẩu hiện tại của TK " + MAKH + " là 123456");
            DAO.DataProvider.ExcuseNonQuery1("UPDATE TAIKHOAN set MATKHAU = '123456' where ID = " + MAKH);
        }
    }
}
