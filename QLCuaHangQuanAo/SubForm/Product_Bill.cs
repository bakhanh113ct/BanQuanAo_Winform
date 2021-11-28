using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo.SubForm
{
    public partial class Product_Bill : Form
    {
        int makh;
        string SoHD;
        public Product_Bill(string SoHD)
        {
            InitializeComponent();
            //this.makh = makh;
            this.SoHD = SoHD;
        }

        private void Product_Bill_Load(object sender, EventArgs e)
        {
            List<Image> list_images = new List<Image>();
            DataTable table = DAO.CTHDDAO.Instance.LoadCTHD(SoHD);
            dtgrvItem.DataSource = table;
            //foreach(DataRow row in table.Rows)
            //{
            //    list_images.Add(ConvertoImage((byte[])row["ANH"]));
            //}
            //foreach(DataGridViewRow row in dtgrvItem.Rows)
            //{
            //    row.Cells[0].Value = list_images[0];
            //}
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Image ConvertoImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
