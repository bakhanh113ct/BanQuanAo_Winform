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
        static public Guna.UI2.WinForms.Guna2Chip btnSoHang;
        static public Label label1;
        public Control_User.Item item;
        public Partner_performance()
        {
            InitializeComponent();
        }


        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }


        private void Partner_performance_Load(object sender, EventArgs e)
        {
            LoadPanel("select * from SanPham");
            btnSoHang = new Guna.UI2.WinForms.Guna2Chip();
            label1 = new Label();
            AddThongBao();
        }



        public void LoadPanel(string query)
        {
            flpnStore.Controls.Clear();
            DBA.Reload("select * from SanPham");
            foreach (Control_User.Item i in DBA.ListItem)
            {
                flpnStore.Controls.Add(i);
            }
            
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

        public static void reload(int i)
        {
            label1.Text = i.ToString();
        }

        private void AddThongBao()
        {
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(2, 2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(14, 13);
            label1.TabIndex = 16;
            label1.Text = UI_Home.i.ToString();

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
