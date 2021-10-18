using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.SubForm
{
    public partial class Add_Item_Form : Form
    {
        string strCon = "Data Source=DESKTOP-LBAULH5;Initial Catalog=QuanLyKho;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Add_Item_Form()
        {
            InitializeComponent();
            this.Focus();
            txbTen.Select();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picture.Image = Image.FromFile(ofd.FileName);
            }
        }
        public void Insert(byte[] image)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into SanPham(Ten, Gia, SoLuong, DanhGia, DaBan, MoTa, Loai, Anh) values(@Ten, @Gia, @SoLuong, @DanhGia, @DaBan, @MoTa, @Loai, @Anh)";
            sqlCmd.Parameters.AddWithValue("@Ten", txbTen.Text);
            sqlCmd.Parameters.AddWithValue("@Gia", txbGiaTien.Text);
            sqlCmd.Parameters.AddWithValue("@SoLuong", txbSoLuong.Text);
            sqlCmd.Parameters.AddWithValue("@DanhGia", "0");
            sqlCmd.Parameters.AddWithValue("@DaBan", "0");
            sqlCmd.Parameters.AddWithValue("@MoTa", txbMota.Text);
            sqlCmd.Parameters.AddWithValue("@Loai", txbLoai.Text);
            sqlCmd.Parameters.AddWithValue("@Anh", image);
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
        }


        byte[] ConvertoByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Insert(ConvertoByte(picture.Image));
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
