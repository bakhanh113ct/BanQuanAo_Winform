using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Net.Mail;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace QLCuaHangQuanAo.SubForm
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
                BILLCT.Rows.Add(temp.TenSP, temp.SL, temp.Gia.ToString(), temp.Trigia);
                total += temp.Trigia;
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
                case "Chờ":
                    return null;
                case "Vận chuyển":
                    trangthai.Text = "Đang vận chuyển";
                    trangthai.ForeColor = Color.FromArgb(0, 192, 0);
                    DueDate.Text = NGXN.ToShortDateString();
                    return "hi";
                case "Hủy":
                    trangthai.Text = "Đã hủy";
                    trangthai.ForeColor = Color.Red;
                    DueDate.Text = NGXN.ToShortDateString();
                    return "hi";
                case "Hoàn thành":
                    trangthai.Text = "Hoàn thành";
                    DueDate.ForeColor = Color.Goldenrod;
                    DueDate.Text = NGXN.AddDays(2).ToShortDateString();
                    return "hi";
            }
            return "WTF";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Library.sound_Click();
            DialogResult temp = MessageBox.Show("Bạn thật sự muốn hủy hàng", "Xác nhận", MessageBoxButtons.OKCancel);
            if (temp == DialogResult.OK)
            {
                Library.cancel();
                DateTime x = DateTime.Now;
                string time = "'" + x.Year + "-" + x.Month + "-" + x.Day + " " + x.Hour + ":" + x.Minute + ":" + x.Second + "'";
                DAO.DataProvider.ExcuseNonQuery1("update HOADON set TRANG_THAI = N'Hủy' where SOHD = " + SOHD);
                DAO.DataProvider.ExcuseNonQuery1("update HOADON set NGXN = " + time + " Where SOHD = " + SOHD);
                return_SP();
                MessageBox.Show("Đã hủy thành công đơn hàng");
                Cancel.Visible = false;
                Delivery.Visible = false;
                kt = true;
            }
        }
        private void return_SP()
        {
            DataTable list_sp = DAO.HoaDonDAO.Instance.getSlSP_inHD(SOHD);
            foreach(DataRow row in list_sp.Rows)
            {
                DAO.SanPhamDAO.Instance.SLSP_in_MASP((int)row["MASP"], (int)row["SL"]);
            }
        }

        private void Delivery_Click(object sender, EventArgs e)
        {
            Library.sound_Click();
            DialogResult temp = MessageBox.Show("Đơn hàng sẽ được chuyển đi.", "Xác nhận", MessageBoxButtons.OKCancel);
            if (temp == DialogResult.OK)
            {
                Library.tada();
                DateTime x = DateTime.Now;
                string time = "'" + x.Year + "-" + x.Month + "-" + x.Day + " " + x.Hour + ":" + x.Minute + ":" + x.Second + "'";
                DAO.DataProvider.ExcuseNonQuery1("update HOADON set TRANG_THAI = N'Vận chuyển' where SOHD = " + SOHD);
                DAO.DataProvider.ExcuseNonQuery1("update HOADON set NGXN = " + time + " Where SOHD = " + SOHD);
                MessageBox.Show("Đang vận chuyển");
                Delivery.Visible = false;
                INHD.Visible = true;
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void xuli()
        {
            if (Status == "Hoàn thành")
            {
                Delivery.Visible = false;
                Cancel.Visible = false;
                INHD.Visible = true;
            }
            else if(Status == "Hủy")
            {
                Delivery.Visible = false;
                Cancel.Visible = false;
                INHD.Visible = false;
            }
            else if (Status == "Vận chuyển")
            {
                Delivery.Visible = false;
            }
            else
                INHD.Visible = false;
        }

        private void INHD_Click(object sender, EventArgs e)
        {
            CRP_HOADON inhoadon = new CRP_HOADON();


            CrystalDecisions.Shared.TableLogOnInfo thongtin;
            thongtin = inhoadon.Database.Tables[0].LogOnInfo;
            thongtin.ConnectionInfo.ServerName = @"DESKTOP-5E0I4OU\SQLEXPRESS01";
            thongtin.ConnectionInfo.DatabaseName = "QuanLyKho";
            thongtin.ConnectionInfo.IntegratedSecurity = true;
            inhoadon.Database.Tables[0].ApplyLogOnInfo(thongtin);

            inHD frmInHoadon = new inHD();

            frmInHoadon.cryinHD.ReportSource = inhoadon;
            frmInHoadon.cryinHD.SelectionFormula = "{HOADON.SOHD}=" + SOHD + "";
            frmInHoadon.ShowDialog();
        }
    }
}

