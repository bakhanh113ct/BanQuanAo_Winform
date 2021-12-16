using System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using System.Text;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Google.Apis.Util.Store;
using System.Net;

namespace QLCuaHangQuanAo.SubForm
{

    public partial class SendEmail : Form
    {
        int SoHD = 0;
        int makh = 0;
        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "SendMail";
        string messageDilivery = "Don hang cua ban dang duoc van chuyen Cam on da su dung dich vu cua cua hang.";
        string messageCancel = "Don hang cua ban da bi huy vi ly do het hang. Rat xin loi vi su bat tien nay.";
        string messageWaitting = "Don hang cua ban dang duoc xu ly. Hang se duoc gui den trong thoi gian ngan nhat. Cam on da su dung dich vu cua cua hang.";
        string email;
        private string pass = "nguyenthihau@123";
        public SendEmail(int SoHD)
        {
            InitializeComponent();
            this.SoHD = SoHD;
        }
        public SendEmail(int makh, int i)
        {
            InitializeComponent();
            this.makh = makh;
        }
        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

        public void LoadFromDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.pdf; *.rpt; *.docx)|*.pdf; *.rpt; *.docx";

            string filename;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                lbFileName.Text = filename;
            }
            
        }
        
        //private void Send(int i)
        //{
        //    MailMessage mail = new MailMessage();
        //    mail.Subject = "Tinh trang don hang";
        //    //mail.BodyEncoding = System.Text.Encoding.Unicode;
        //    //mail.IsBodyHtml = true;
        //    //mail.BodyEncoding = Encoding.UTF8;
        //    //mail.BodyEncoding = System.Text.Encoding.UTF8;
        //    //mail.Body = $"<b><i>{txbContent.Text}</i></b>"; 
        //    mail.Body = "Nguyễn ";
        //    mail.Body.Replace("Nguyễn", "Nguyễn");
        //    mail.From = new MailAddress("bakhanh113ct@gmail.com");
        //    if (lbFileName.Text != "")
        //    {
        //        string attImg = "" + lbFileName.Text + "";
        //        mail.Attachments.Add(new Attachment(attImg));
        //    }
        //    mail.To.Add(new MailAddress("" + txbToEmail.Text + ""));
        //    MimeKit.MimeMessage mimeMessage = MimeKit.MimeMessage.CreateFromMailMessage(mail);


        //    //string message;
        //    //if (i == 1)
        //    //    message = $"To: {txbToEmail.Text}\r\nSubject: {"Tinh trang don hang"}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h2>{messageDilivery}</h2>";
        //    //else
        //    //    message = $"To: {txbToEmail.Text}\r\nSubject: {"Tinh trang don hang"}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h2>{messageCancel}</h2>";

        //    UserCredential credential;
        //    //read your credentials file
        //    using (FileStream stream = new FileStream(@"../../Credential/credentials.json", FileMode.Open, FileAccess.Read))
        //    {
        //        string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //        path = Path.Combine(path, ".credentials/gmail-dotnet-quickstart.json");
        //        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(path, true)).Result;
        //    }
        //    //call your gmail service
        //    var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = credential, ApplicationName = ApplicationName });
        //    var msg = new Google.Apis.Gmail.v1.Data.Message();

        //    msg.Raw = Base64UrlEncode(mimeMessage.ToString());
        //    service.Users.Messages.Send(msg, "me").Execute();
        //    MessageBox.Show("Your email has been successfully sent !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        private void Send(int i)
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential(Login.kh.Email, txbPass.Text);

                MailMessage message = new MailMessage(Login.kh.Email, txbToEmail.Text);
                message.Subject = "Tình trạng đơn hàng";
                message.Body = txbContent.Text;
                if (lbFileName.Text != "")
                {
                    string attimg = "" + lbFileName.Text + "";
                    message.Attachments.Add(new Attachment(attimg));
                }
                mailclient.Send(message);
                MessageBox.Show("Mail đã được gửi đi", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại mật khẩu.");
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            LoadFromDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send(1);
            this.Close();
        }

        private void SendEmail_Load(object sender, EventArgs e)
        {
            if (SoHD != 0)
                email = DAO.TaiKhoanDAO.Instance.LoadEmail(SoHD);
            else
                email = DAO.TaiKhoanDAO.Instance.LoadEmail_MaKH(makh.ToString());
            txbToEmail.Text = email;
            string checkStatus = DAO.HoaDonDAO.Instance.CheckStatus(SoHD);
            if (checkStatus == "Vận chuyển")
                txbContent.Text = messageDilivery;
            else if (checkStatus == "Hủy")
                txbContent.Text = messageCancel;
            else if (checkStatus == "Chờ")
                txbContent.Text = messageWaitting;
            else
                txbContent.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
