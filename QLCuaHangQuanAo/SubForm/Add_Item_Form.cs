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
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Library.LoadFromDialog(picture);
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] imgbyte = Library.ConvertoByte(picture.Image);
            if (imgbyte != null)
                if (!DAO.SanPhamDAO.InsertSP(txbTen.Text, txbGiaTien.Text, txbSoLuong.Text, txbMota.Text, txbLoai.Text, imgbyte))
                {
                    MessageBox.Show("Them khong thanh cong.");
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Them thanh cong.");
                }
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
