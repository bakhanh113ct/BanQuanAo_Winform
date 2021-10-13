using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LBAULH5;Initial Catalog=QuanLyKho;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from TaiKhoan where tendangnhap = '" + txtUsername.Text + "' and matkhau = '" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                PrgLogin.Value = 0;
                Gif_Logo.Visible = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("SAI.");
            }
        }

        private void pwshow_CheckedChanged(object sender, EventArgs e)
        {
            if (pwshow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PrgLogin.Increment(3);
            PhanTram.Text = PrgLogin.ProgressPercentText;

            if (PrgLogin.ProgressPercentText == "100%")
            {
                timer1.Stop();
                this.Hide();
                UI_Home H = new UI_Home();
                H.ShowDialog();
                //this.Show();
            }
        }
    }
}
