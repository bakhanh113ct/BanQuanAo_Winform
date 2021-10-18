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

namespace Login
{
    public partial class Store_performence : Form
    {
        string strCon = "Data Source=DESKTOP-LBAULH5;Initial Catalog=QuanLyKho;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Store_performence()
        {
            InitializeComponent();
        }
        private void Store_performence_Load(object sender, EventArgs e)
        {

            LoadPanel("select * from SanPham");
        }

        public void LoadPanel(string query)
        {
            flpnStore.Controls.Clear();
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
                Control_User.Item u = new Control_User.Item();
                string Ten = reader.GetString(1).Trim();
                double gia = reader.GetFloat(2);
                int soluong = reader.GetInt32(3);
                int danhgia = reader.GetInt32(4);
                int daban = reader.GetInt32(5);
                string mota = reader.GetString(6);
                string Loai = reader.GetString(7);
                //Load
                u.lbName.Text = Ten;
                u.btnGia.Text = gia.ToString() + " VND";
                u.SoLuong.Text = "SL: " + soluong.ToString();
                u.DaBan.Text = "Ban: " + daban.ToString();
                if (soluong > 0)
                {
                    u.btnTinhTrang.Text = "Còn";
                    u.btnTinhTrang.FillColor = Color.FromArgb(68, 201, 97);
                }
                //Load ảnh
                byte[] b = null;
                b = (byte[])reader.GetValue(8);
                u.picture.Image = ConvertoImage(b);
                u.picture.SizeMode = PictureBoxSizeMode.CenterImage;
                // Thêm vào panel
                flpnStore.Controls.Add(u);
            }
            reader.Close();
        }
        //Load lại flowlayoutpanel
        private void btnReload_Click(object sender, EventArgs e)
        {
            flpnStore.Controls.Clear();
            LoadPanel("select * from SanPham");
        }
        //Chuyển ảnh sang byte
        byte[] ConvertoByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        //Chuyển byte sang ảnh
        public Image ConvertoImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SubForm.Add_Item_Form additem = new SubForm.Add_Item_Form();
            additem.ShowDialog();
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2ComboBox i = (Guna.UI2.WinForms.Guna2ComboBox)sender;
            switch (i.SelectedIndex)
            {
                case 0:
                    LoadPanel("select * from SanPham where Loai = 'ao' or Loai = 'Ao'");
                    break;
                case 1:
                    LoadPanel("select * from SanPham where Loai = 'quan' or Loai = 'Quan'");
                    break;
                case 2:
                    LoadPanel("select * from SanPham where Loai = 'giay' or Loai = 'Giay' or Loai = 'dep' or Loai = 'Dep'");
                    break;
                case 3:
                    LoadPanel("select * from SanPham where Loai = 'mu' or Loai = 'Mu'");
                    break;
                case 4:
                    LoadPanel("select * from SanPham");
                    break;
            }
        }
    }
}
