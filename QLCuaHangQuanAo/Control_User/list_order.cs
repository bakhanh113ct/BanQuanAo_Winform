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

namespace QLCuaHangQuanAo.Control_User
{
    public partial class list_order : UserControl
    {
        private string tenKH;
        private string status;
        private int sL;
        private DateTime ngHD;
        private int soHD;
        private byte[] anh;
        private DateTime nGXN;
        public list_order()
        {
            InitializeComponent();
        }
        public list_order(DataRow row)
        {
            InitializeComponent();
            ten_khach_hang.Text = row["HOTEN"].ToString();
            so_luong_san_pham.Text = (row["SOHANG"]).ToString() + " Item";
            ngay_mua_hang.Text = row["NGHD"].ToString();
            SoHD = (int)row["SOHD"];

            Status = row["TRANG_THAI"].ToString();
            trang_thai.Text = Status;
            set_tt(Status);

            if (!row.IsNull("ANH"))
                anh = (byte[])row["ANH"];
            else
            {
                anh = null;
            }
            avt_khachhang.Image = Library.ConvertoImage(anh) == null ? Properties.Resources.male_User : Library.ConvertoImage(anh);
        }


        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Status { get => status; set => status = value; }
        public int SL { get => sL; set => sL = value; }
        public DateTime NgHD { get => ngHD; set => ngHD = value; }
        public int SoHD { get => soHD; set => soHD = value; }
        public DateTime NGXN { get => nGXN; set => nGXN = value; }

        
        
       
      

       
     
        private void thao_tac_Click(object sender, EventArgs e) //khi click vào list_order thì sẽ đỗi màu
        {
            change();
            DAO.Sound.Instance.sound_Click();
        }
        private void change()//đổi màu khi click
        {
            foreach (list_order item in Invoice_performance.dcm)
            {
                item.BackGround.FillColor = Color.White;
                item.ten_khach_hang.ForeColor = Color.Black;
                item.ngay_mua_hang.ForeColor = Color.Black;
                item.avt_khachhang.BackColor = Color.White;
            }

            BackGround.FillColor = Color.FromArgb(174, 78, 191);
            ten_khach_hang.ForeColor = Color.White;
            ngay_mua_hang.ForeColor = Color.White;
            avt_khachhang.ForeColor = Color.White;
            avt_khachhang.BackColor = Color.FromArgb(174, 78, 191);
        }

        
        private void thao_tac_MouseHover(object sender, EventArgs e)//hiêu ứng khi trỏ chuột
        {
            if(BackGround.FillColor == Color.White)
            {
                BackGround.FillColor = Color.Aqua;
                avt_khachhang.BackColor = Color.Aqua;
            }
            else if(BackGround.FillColor ==  Color.FromArgb(174, 78, 191))
            {
                BackGround.FillColor = Color.DarkViolet;
                avt_khachhang.BackColor = Color.DarkViolet;
            }
            
        }
        private void thao_tac_MouseLeave(object sender, EventArgs e)//hiệu ứng khi di chuyển chuột ra chỗ khác
        {
            if (BackGround.FillColor == Color.Aqua)
            {
                BackGround.FillColor = Color.White;
                avt_khachhang.BackColor = Color.White;
            }
            else if(BackGround.FillColor == Color.DarkViolet)
            {
                BackGround.FillColor = Color.FromArgb(174, 78, 191);
                avt_khachhang.BackColor = Color.FromArgb(174, 78, 191);
            }
        }

               
        public string getStatus()//Lấy trạng thái hiện tại của đơn hàng
        {
            return DAO.HoaDonDAO.Instance.gettt(SoHD);
        }
       
        public void set_tt(string tt) //chuyển trạng thái khi xác nhận đơn hàng
        {
            switch (tt)
            {
                case "Complete":
                    //trang_thai.Text = "Complete";
                    trang_thai.FillColor = Color.FromArgb(242, 203, 66);
                    trang_thai.ForeColor = Color.Black;
                    break;
                case "Delivery":
                    trang_thai.Text = "Delivery";
                    trang_thai.FillColor = Color.FromArgb(0, 192, 0);
                    trang_thai.ForeColor = Color.White;
                    break;
                case "Cancel":
                    trang_thai.Text = "Cancel";
                    trang_thai.FillColor = Color.Red;
                    trang_thai.ForeColor = Color.White;
                    break;
                case "Waiting":
                    trang_thai.FillColor = Color.RoyalBlue;
                    trang_thai.ForeColor = Color.White;
                    break;
            }
        }
        
    }
}
