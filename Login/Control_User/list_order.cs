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
        private int soHD;

        

        //private Image anh;
        public list_order()
        {
            InitializeComponent();
        }

        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Status { get => status; set => status = value; }
        public int SL { get => sL; set => sL = value; }
        public DateTime NgHD { get => ngHD; set => ngHD = value; }
        public int SoHD { get => soHD; set => soHD = value; }

        public list_order(DataRow row)
        {
            InitializeComponent();
            ten_khach_hang.Text = row["HOTEN"].ToString();
            this.Status = "Provider";
            so_luong_san_pham.Text = (row["SOHANG"]).ToString() + " Item";
            ngay_mua_hang.Text = row["NGHD"].ToString();
            SoHD = (int)row["SOHD"];
        }

       

        private void change()
        {
            foreach(list_order item in Customer_performance.dcm)
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
