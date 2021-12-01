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
        string SoHD;
        public Product_Bill(string SoHD)
        {
            InitializeComponent();
            this.SoHD = SoHD;
        }

        private void Product_Bill_Load(object sender, EventArgs e)
        {
            DataTable table = DAO.CTHDDAO.Instance.LoadCTHD(SoHD);
            dtgrvItem.DataSource = table;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
