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
using System.Runtime.InteropServices;
namespace QLCuaHangQuanAo.SubForm
{

    public partial class SendEmail : Form
    {
        int SoHD;
        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "SendMail";
        string messageDilivery = "Đơn hàng của bạn đang được vận chuyển, cảm ơn đã sử dụng dịch vụ của shop.";
        string messageCancel = "Đơn hàng của bạn đã bị hủy vì lý do hết hàng. Shop thành thật xin lỗi vì sự bất tiện này.";
        string messageWaitting = "Đơn hàng của bạn đang được xử lí. Sẽ gửi cho bạn trong thời gian sớm nhất. Cảm ơn đã sử dụng dịch vụ của cửa hàng.";
        string email;
        public SendEmail(int SoHD)
        {
            InitializeComponent();
            this.SoHD = SoHD;
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

        private void Send(int i)
        {
            MailMessage mail = new MailMessage();
            mail.Subject = "Tinh trang don hang";
            //mail.BodyEncoding = System.Text.Encoding.Unicode;
            mail.Body = $"<b><i>{txbContent.Text}</i></b>";
            mail.From = new MailAddress("bakhanh113ct@gmail.com");
            mail.IsBodyHtml = true;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            if (lbFileName.Text != "")
            {
                string attImg = "" + lbFileName.Text + "";
                mail.Attachments.Add(new Attachment(attImg));
            }
            mail.To.Add(new MailAddress("" + txbToEmail.Text + ""));
            MimeKit.MimeMessage mimeMessage = MimeKit.MimeMessage.CreateFromMailMessage(mail);

            //string message;
            //if (i == 1)
            //    message = $"To: {txbToEmail.Text}\r\nSubject: {"Tinh trang don hang"}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h2>{messageDilivery}</h2>";
            //else
            //    message = $"To: {txbToEmail.Text}\r\nSubject: {"Tinh trang don hang"}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h2>{messageCancel}</h2>";

            UserCredential credential;
            //read your credentials file
            using (FileStream stream = new FileStream(@"../../Credential/credentials.json", FileMode.Open, FileAccess.Read))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                path = Path.Combine(path, ".credentials/gmail-dotnet-quickstart.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(path, true)).Result;
            }
            //call your gmail service
            var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = credential, ApplicationName = ApplicationName });
            var msg = new Google.Apis.Gmail.v1.Data.Message();

            msg.Raw = Base64UrlEncode(mimeMessage.ToString()); ;
            service.Users.Messages.Send(msg, "me").Execute();
            MessageBox.Show("Your email has been successfully sent !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            email = DAO.TaiKhoanDAO.Instance.LoadEmail(SoHD);
            txbToEmail.Text = email;
            string checkStatus = DAO.HoaDonDAO.Instance.CheckStatus(SoHD);
            if (checkStatus == "Delivery")
                txbContent.Text = messageDilivery;
            else if (checkStatus == "Cancel")
                txbContent.Text = messageCancel;
            else
                txbContent.Text = messageWaitting;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
