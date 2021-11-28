using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.SubForm
{
    public partial class BILL : Form
    {
        private string Status;
        int SOHD;
        static bool kt = false;
        public BILL()
        {
            InitializeComponent();
            
        }
        public BILL(int SOHD)
        {
            InitializeComponent();
            Status = DAO.HoaDonDAO.Instance.gettt(SOHD);
            this.SOHD = SOHD;
            loadInfo(SOHD);
            loadCTSP(SOHD);
           
        }

        private void loadCTSP(int sOHD)
        {
            int total = 0;
            DataTable bill = DAO.HoaDonDAO.Instance.loadBill(sOHD);
            foreach (DataRow x in bill.Rows)
            {
                DTO.BillInfo temp = new DTO.BillInfo(x);
                BILLCT.Rows.Add(temp.MaSP, temp.TenSP, temp.SL, temp.Gia.ToString());
                total = temp.Gia;
            }
            tong.Text = (total + 15000).ToString() + "₫";
            TONGALL.Text = tong.Text;
            TONG_GIA.Text = total.ToString() + "₫";
            xuli();
        }

        private void loadInfo(int SOHD)
        {
            DataTable info = DAO.KhachHangDAO.Instance.loadInfo(SOHD);
            foreach(DataRow row in info.Rows)
            {
                NameKh.Text = row["HOTEN"].ToString();
                DiaChi.Text = row["DCHI"].ToString();
                SoHD.Text = "#" + row["SOHD"].ToString();
                DateTime x = (DateTime)row["NGHD"];
                invoiceDate.Text = x.ToShortDateString();
                DateTime nGXN = DAO.HoaDonDAO.Instance.getTimeXN(SOHD);
                if(getDuaday(row["TRANG_THAI"].ToString(), nGXN) == null)
                    DueDate.Text = x.AddDays(7).ToShortDateString();
                
                
            }
            
        }

        private string getDuaday(string v1, DateTime NGXN)
        {
            switch(v1)
            {
                case "Waiting":
                    return null;
                case "Delivery":
                    trangthai.Text = "Đang vận chuyển";
                    trangthai.ForeColor = Color.FromArgb(0, 192, 0);
                    DueDate.Text = NGXN.ToShortDateString();
                    return "hi";
                case "Cancel":
                    trangthai.Text = "Đã hủy";
                    trangthai.ForeColor = Color.Red;
                    DueDate.Text = NGXN.ToShortDateString();
                    return "hi";
                case "Complete":
                    trangthai.Text = "Hoàn thành";
                    DueDate.ForeColor = Color.Goldenrod;
                    DueDate.Text = NGXN.AddDays(2).ToShortDateString();
                    return "hi";
            }
            return "WTF";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DAO.Sound.Instance.cancel();
            DateTime x = DateTime.Now;
            string time = "'" + x.Year + "-" + x.Month + "-" + x.Day + " " + x.Hour + ":" + x.Minute + ":" + x.Second + "'";
            DAO.DataProvider.ExcuseNonQuery1("update HOADON set TRANG_THAI = 'Cancel' where SOHD = " + SOHD);
            DAO.DataProvider.ExcuseNonQuery1("update HOADON set NGXN = " + time + " Where SOHD = " + SOHD);
            MessageBox.Show("Đã hủy thành công đơn hàng");
            Cancel.Visible = false;
            Delivery.Visible = false;
            kt = true;
        }
        private void Delivery_Click(object sender, EventArgs e)
        {
            DAO.Sound.Instance.tada();
            DateTime x = DateTime.Now;
            string time = "'" + x.Year + "-" + x.Month + "-" + x.Day + " " + x.Hour + ":" + x.Minute + ":" + x.Second + "'";
            DAO.DataProvider.ExcuseNonQuery1("update HOADON set TRANG_THAI = 'Delivery' where SOHD = " + SOHD);
            DAO.DataProvider.ExcuseNonQuery1("update HOADON set NGXN = " + time + " Where SOHD = " + SOHD);
            MessageBox.Show("Đang vận chuyển");
            Delivery.Visible = false;
            
        }
        public static bool getChange()
        {
            return kt;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            DAO.Sound.Instance.sound_Click();
        }
        private void xuli()
        {
            if (Status == "Complete" || Status == "Cancel")
            {
                Delivery.Visible = false;
                Cancel.Visible = false;
            }
            else if (Status == "Delivery")
                Delivery.Visible = false;
        }

        

       
    }
    
}

