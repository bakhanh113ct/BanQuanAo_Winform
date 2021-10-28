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
            picture.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        public void Insert(byte[] image)
        {
            int check = 0;
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
            try
            {
                check = sqlCmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Them khong thanh cong.");
            }
            if (check != 0)
                MessageBox.Show("Them thanh cong.");
        }


        byte[] ConvertoByte(Image img)
        {
            if(img != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Chua them anh");
            }
            return null;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] imgbyte = ConvertoByte(picture.Image);
            if (imgbyte != null)
                Insert(imgbyte);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
