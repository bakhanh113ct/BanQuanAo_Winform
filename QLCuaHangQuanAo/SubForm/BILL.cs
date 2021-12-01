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
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace QLCuaHangQuanAo.SubForm
{
    public partial class BILL : Form
    {
        private string Status;
        int SOHD;
        static bool kt = false;
        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "SendMail";
        string messageDilivery = "Đơn hàng của bạn đang được vận chuyển, cảm ơn đã sử dụng dịch vụ của shop.";
        string messageCancel = "Đơn hàng của bạn đã bị hủy vì lý do hết hàng. Shop thành thật xin lỗi vì sự bất tiện này.";

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
            DAO.Sound.Instance.sound_Click();
            DialogResult temp = MessageBox.Show("Bạn thật sự muốn hủy hàng", "Xác nhận", MessageBoxButtons.OKCancel);
            if (temp == DialogResult.OK)
            {
                DAO.Sound.Instance.cancel();
                DateTime x = DateTime.Now;
                string time = "'" + x.Year + "-" + x.Month + "-" + x.Day + " " + x.Hour + ":" + x.Minute + ":" + x.Second + "'";
                DAO.DataProvider.ExcuseNonQuery1("update HOADON set TRANG_THAI = 'Cancel' where SOHD = " + SOHD);
                DAO.DataProvider.ExcuseNonQuery1("update HOADON set NGXN = " + time + " Where SOHD = " + SOHD);
                return_SP();
                MessageBox.Show("Đã hủy thành công đơn hàng");
                Cancel.Visible = false;
                Delivery.Visible = false;
                kt = true;
                SendEmail(0);
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
            DAO.Sound.Instance.sound_Click();
            DialogResult temp = MessageBox.Show("Đơn hàng sẽ được chuyển đi.", "Xác nhận", MessageBoxButtons.OKCancel);
            if (temp == DialogResult.OK)
            {
                DAO.Sound.Instance.tada();
                DateTime x = DateTime.Now;
                string time = "'" + x.Year + "-" + x.Month + "-" + x.Day + " " + x.Hour + ":" + x.Minute + ":" + x.Second + "'";
                DAO.DataProvider.ExcuseNonQuery1("update HOADON set TRANG_THAI = 'Delivery' where SOHD = " + SOHD);
                DAO.DataProvider.ExcuseNonQuery1("update HOADON set NGXN = " + time + " Where SOHD = " + SOHD);
                MessageBox.Show("Đang vận chuyển");
                Delivery.Visible = false;
                SendEmail(1);
            }
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

        private void SendEmail(int i)
        {
            UserCredential credential;
            //read your credentials file
            using (FileStream stream = new FileStream(Application.StartupPath + @"/credentials.json", FileMode.Open, FileAccess.Read))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                path = Path.Combine(path, ".credentials/gmail-dotnet-quickstart.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(path, true)).Result;
            }
            string message;
            if (i == 1)
                message = $"To: {Login.kh.Email}\r\nSubject: {"Tinh trang don hang"}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h2>{messageDilivery}</h2>";
            else 
                message = $"To: {Login.kh.Email}\r\nSubject: {"Tinh trang don hang"}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h2>{messageCancel}</h2>";
            //call your gmail service
            var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = credential, ApplicationName = ApplicationName });
            var msg = new Google.Apis.Gmail.v1.Data.Message();
            msg.Raw = Base64UrlEncode(message.ToString());
            service.Users.Messages.Send(msg, "me").Execute();
            //MessageBox.Show("Your email has been successfully sent !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

    }
    
}

