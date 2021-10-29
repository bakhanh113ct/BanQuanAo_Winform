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
using System.IO;

namespace Login.SubForm
{
    public partial class Edit_Form : Form
    {
        public bool check_save_click = false;
        public bool check_delete_click = false;
        string strCon = "Data Source=DESKTOP-LBAULH5;Initial Catalog=QuanLyKho;Integrated Security=True";
        SqlConnection sqlCon = null;
        string old_Name;
        public Edit_Form()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Update(byte[] image)
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

            sqlCmd.CommandText = "update SanPham set Ten = @Ten, Gia = @Gia, SoLuong = @SoLuong, DanhGia = @DanhGia, DaBan = @DaBan, MoTa = @MoTa, Loai = @Loai, Anh = @Anh where Ten = '"+old_Name+ "'";
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
                MessageBox.Show("Cap nhat khong thanh cong.");
            }
            if (check != 0)
            {
                MessageBox.Show("Cap nhat thanh cong.");
                check_save_click = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] imgbyte = ConvertoByte(picture.Image);
            if (imgbyte != null)
                Update(imgbyte);
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
            sqlCmd.CommandText = "DELETE FROM SanPham WHERE Ten = '" + txbTen.Text + "'";
            sqlCmd.Connection = sqlCon;
            try
            {
                check = sqlCmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Xoa khong thanh cong.");
            }
            if (check != 0)
            {
                check_delete_click = true;
                MessageBox.Show("Xoa thanh cong.");
                this.Close();
            }
        }
        byte[] ConvertoByte(Image img)
        {
            if (img != null)
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

        private void Edit_Form_Load(object sender, EventArgs e)
        {
            old_Name = txbTen.Text;
            check_save_click = false;
            check_delete_click = false;
        }
    }
}
