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

namespace Login.Control_User
{
    public partial class list_order : UserControl
    {

        private string tenKH;
        private string status;
        private int sL;
        private DateTime ngHD;
        private int soHD;
        private byte[] anh;

        

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
            Status = row["TRANG_THAI"].ToString();
            trang_thai.Text = Status;
            anh = (byte[])row["ANH"];
            avt_khachhang.Image = ConvertoImage(anh);

            if(Status == "Complete")
            {
                trang_thai.FillColor = Color.FromArgb(242, 203, 66);
                trang_thai.ForeColor = Color.Black;
            }
        }

        public void change_trang_thai()
        {
            Status = "Complete";
            trang_thai.Text = Status;
            trang_thai.FillColor = Color.FromArgb(242, 203, 66);
            trang_thai.ForeColor = Color.Black;
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

            BackGround.FillColor = Color.FromArgb(174, 78, 191);
            ten_khach_hang.ForeColor = Color.White;
            ngay_mua_hang.ForeColor = Color.White;
            avt_khachhang.ForeColor = Color.White;
            avt_khachhang.BackColor = Color.FromArgb(174, 78, 191);
        }

        public Image ConvertoImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void thao_tac_Click(object sender, EventArgs e)
        {
            change();
        }

        private void thao_tac_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
