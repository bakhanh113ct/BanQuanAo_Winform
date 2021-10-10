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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        public void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5E0I4OU\SQLEXPRESS01;Initial Catalog=QuanLyKho;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from TaiKhoan where tendangnhap = '"+txtUsername.Text+"' and matkhau = '"+txtPassword.Text+"'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                this.Hide();
                Form2 f = new Form2();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("SAI.");
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (pwshow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
                txtPassword.UseSystemPasswordChar = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
