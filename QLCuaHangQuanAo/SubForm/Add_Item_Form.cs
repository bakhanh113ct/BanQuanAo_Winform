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

namespace QLCuaHangQuanAo.SubForm
{
    public partial class Add_Item_Form : Form
    {
        public Add_Item_Form()
        {
            InitializeComponent();
            this.Focus();
            txbTen.Select();
            cbLoinhuan.SelectedIndex = 0;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Library.LoadFromDialog(picture);
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] imgbyte = Library.ConvertoByte(picture.Image);
            int gia = (int)XulyGIa();
            if (imgbyte != null)
                if (!DAO.SanPhamDAO.InsertSP(txbTen.Text, txbGiaTien.Text, gia.ToString(),  txbSoLuong.Text, txbMota.Text, txbLoai.Text, imgbyte))
                {
                    MessageBox.Show("Thêm không thành công.");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thêm thành công.");
                }
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double XulyGIa()
        {
            double gia;
            if (cbLoinhuan.SelectedIndex == 0)
                gia = Convert.ToDouble(txbGiaTien.Text) * Convert.ToDouble(txbLoinhuan.Text)/100;
            else
                gia = Convert.ToDouble(txbGiaTien.Text) + Convert.ToDouble(txbLoinhuan.Text);
            return gia;
        }
    }
}
