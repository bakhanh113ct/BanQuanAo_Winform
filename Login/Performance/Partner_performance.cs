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
    public partial class Partner_performance : Form
    {
        public SubForm.Edit_Form editform = new SubForm.Edit_Form();    //mọi item đều có chung 1 form edit
        string strCon = "Data Source=DESKTOP-LBAULH5;Initial Catalog=QuanLyKho;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Partner_performance()
        {
            InitializeComponent();
            AddThongBao();
        }

        

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }


        private void Partner_performance_Load(object sender, EventArgs e)
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
                string Ten = reader.GetString(1).Trim();
                double gia = reader.GetFloat(2);
                int soluong = reader.GetInt32(3);
                double danhgia = reader.GetFloat(4);
                int daban = reader.GetInt32(5);
                string mota = reader.GetString(6);
                string Loai = reader.GetString(7);
                //Tạo Usercontrol
                Control_User.Item u = new Control_User.Item(Ten, gia, soluong, danhgia, daban, mota, Loai);
                u.editform = editform;  //tham chiếu tới từng item
                u.Click -= u.picture_Click;

                
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
        public void btnReload_Click(object sender, EventArgs e)
        {
            flpnStore.Controls.Clear();
            LoadPanel("select * from SanPham");
        }

        //Chuyển byte sang ảnh
        public Image ConvertoImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
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

        private void btnCart_Click(object sender, EventArgs e)
        {
            
        }

        private void AddThongBao()
        {
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(2, 2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(14, 13);
            label1.TabIndex = 16;
            label1.Text = "1";
            Guna.UI2.WinForms.Guna2Chip btnSoHang = new Guna.UI2.WinForms.Guna2Chip();
            btnSoHang.Controls.Add(label1);
            btnCart.Controls.Add(btnSoHang);
            btnSoHang.AutoRoundedCorners = true;
            btnSoHang.BackColor = System.Drawing.Color.Transparent;
            btnSoHang.BorderRadius = 9;
            btnSoHang.FillColor = System.Drawing.Color.Red;
            btnSoHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSoHang.ForeColor = System.Drawing.Color.White;
            btnSoHang.IsClosable = false;
            btnSoHang.Location = new System.Drawing.Point(22, 3);
            btnSoHang.Margin = new System.Windows.Forms.Padding(-2);
            btnSoHang.Name = "btnSoHang";
            btnSoHang.ShadowDecoration.Parent = btnSoHang;
            btnSoHang.Size = new System.Drawing.Size(17, 17);
            btnSoHang.TabIndex = 0;
            btnSoHang.Text = "";
        }
    }
}
