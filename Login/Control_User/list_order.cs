using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Control_User
{
    public partial class list_order : UserControl
    {
        private string tenKH;
        private string status;
        private int sL;
        private DateTime ngHD;

        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Status { get => status; set => status = value; }
        public int SL { get => sL; set => sL = value; }
        public DateTime NgHD { get => ngHD; set => ngHD = value; }

        //private Image anh;
        public list_order()
        {
            InitializeComponent();
        }

        public list_order(DataRow row)
        {
            InitializeComponent();
            ten_khach_hang.Text = row["HOTEN"].ToString();
            this.status = "Provider";
            so_luong_san_pham.Text = (row["SOHANG"]).ToString() + " Item";
            ngay_mua_hang.Text = row["NGHD"].ToString();
        }

      

        private void change()
        {
            foreach(list_order item in DAO.OrderList.dcm)
            {
                item.BackGround.FillColor = Color.White;
                item.ten_khach_hang.ForeColor = Color.Black;
                item.ngay_mua_hang.ForeColor =  Color.Black;
                item.avt_khachhang.BackColor =  Color.White;
            }
            BackGround.FillColor = Color.FromArgb(118, 53, 210);
            ten_khach_hang.ForeColor = Color.White;
            ngay_mua_hang.ForeColor = Color.White;
            avt_khachhang.ForeColor = Color.White;
            avt_khachhang.BackColor = Color.FromArgb(118, 53, 210);
        }

        private void thao_tac_Click(object sender, EventArgs e)
        {
            change();
        }
    }
}
