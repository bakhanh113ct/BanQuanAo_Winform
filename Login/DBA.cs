using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public class DBA
    {
        public static List<Control_User.Item> ListItem;
        static string strCon = "Data Source=DESKTOP-5E0I4OU\\SQLEXPRESS01;Initial Catalog=QuanLyKho;Integrated Security=True";
        static SqlConnection sqlCon = null;
        public static void Reload(string query)
        {
            ListItem = new List<Control_User.Item>();
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
            sqlCmd.CommandText = query;
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string Ten = reader.GetString(1).Trim();
                double gia = reader.GetFloat(2);
                int soluong = reader.GetInt32(3);
                double danhgia = reader.GetFloat(4);
                int daban = reader.GetInt32(5);
                string mota = reader.GetString(6);
                int Loai = reader.GetInt32(7);
                //Tạo Usercontrol
                Control_User.Item u = new Control_User.Item(Ten, gia, soluong, danhgia, daban, mota, Loai, UI_Home.store);
                //Load ảnh
                byte[] b = null;
                b = (byte[])reader.GetValue(8);
                u.picture.Image = ConvertoImage(b);
                //u.picture.SizeMode = PictureBoxSizeMode.Zoom;
                ListItem.Add(u);
            }
            reader.Close();
        }
        static public Image ConvertoImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        static public bool Insert(string ten, string gia, string SL, string mota, string loai, byte[] image)
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
            sqlCmd.CommandText = "insert into SANPHAM(TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI, ANH) values(@Ten, @Gia, @SoLuong, @DanhGia, @DaBan, @MoTa, @Loai, @Anh)";
            sqlCmd.Parameters.AddWithValue("@Ten", ten);
            sqlCmd.Parameters.AddWithValue("@Gia", gia);
            sqlCmd.Parameters.AddWithValue("@SoLuong", SL);
            sqlCmd.Parameters.AddWithValue("@DanhGia", "0");
            sqlCmd.Parameters.AddWithValue("@DaBan", "0");
            sqlCmd.Parameters.AddWithValue("@MoTa", mota);
            sqlCmd.Parameters.AddWithValue("@Loai", loai);
            sqlCmd.Parameters.AddWithValue("@Anh", image);
            sqlCmd.Connection = sqlCon;
            try
            {
                check = sqlCmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Them khong thanh cong.");
                return false;
            }
            if (check != 0)
            {
                DialogResult result = MessageBox.Show("Them thanh cong.");
                if (result == DialogResult.OK)
                {
                    return true;
                }
            }
            return true;
        }

        static public bool InsertHD(string ten, string gia, string SL, string mota, string loai, byte[] image)
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
            sqlCmd.CommandText = "insert into SANPHAM(TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI, ANH) values(@Ten, @Gia, @SoLuong, @DanhGia, @DaBan, @MoTa, @Loai, @Anh)";
            sqlCmd.Parameters.AddWithValue("@Ten", ten);
            sqlCmd.Parameters.AddWithValue("@Gia", gia);
            sqlCmd.Parameters.AddWithValue("@SoLuong", SL);
            sqlCmd.Parameters.AddWithValue("@DanhGia", "0");
            sqlCmd.Parameters.AddWithValue("@DaBan", "0");
            sqlCmd.Parameters.AddWithValue("@MoTa", mota);
            sqlCmd.Parameters.AddWithValue("@Loai", loai);
            sqlCmd.Parameters.AddWithValue("@Anh", image);
            sqlCmd.Connection = sqlCon;
            try
            {
                check = sqlCmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Them khong thanh cong.");
                return false;
            }
            if (check != 0)
            {
                DialogResult result = MessageBox.Show("Them thanh cong.");
                if (result == DialogResult.OK)
                {
                    return true;
                }
            }
            return true;
        }

        static public bool Update(string ten, string gia, string SL, string mota, string loai, byte[] image, string old_Name)
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

            sqlCmd.CommandText = "update SANPHAM set TEN = @Ten, GIA = @Gia, SL = @SoLuong, DANHGIA = @DanhGia, DABAN = @DaBan, MOTA = @MoTa, LOAI = @Loai, ANH = @Anh where TEN = '" + old_Name + "'";
            sqlCmd.Parameters.AddWithValue("@Ten", ten);
            sqlCmd.Parameters.AddWithValue("@Gia", gia);
            sqlCmd.Parameters.AddWithValue("@SoLuong", SL);
            sqlCmd.Parameters.AddWithValue("@DanhGia", "0");
            sqlCmd.Parameters.AddWithValue("@DaBan", "0");
            sqlCmd.Parameters.AddWithValue("@MoTa", mota);
            sqlCmd.Parameters.AddWithValue("@Loai", loai);
            sqlCmd.Parameters.AddWithValue("@Anh", image);
            sqlCmd.Connection = sqlCon;
            try
            {
                check = sqlCmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Cap nhat khong thanh cong.");
                return false;
            }
            if (check != 0)
            {
                DialogResult result = MessageBox.Show("Cap nhat thanh cong.");
                if (result == DialogResult.OK)
                {
                    return true;
                }
            }
            return true;
        }
        static public bool Delete(string ten)
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
            sqlCmd.CommandText = "DELETE FROM SanPham WHERE Ten = '" + ten + "'";
            sqlCmd.Connection = sqlCon;
            try
            {
                check = sqlCmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Xoa khong thanh cong.");
                return false;
            }
            if (check != 0)
            {
                MessageBox.Show("Xoa thanh cong.");
                return true;
            }
            return true;
        }
    }
}
