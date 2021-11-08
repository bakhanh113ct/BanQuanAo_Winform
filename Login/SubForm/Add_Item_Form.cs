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
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] imgbyte = ConvertoByte(picture.Image);
            if (imgbyte != null)
                if (DAO.SanPhamDAO.InsertSP(txbTen.Text, txbGiaTien.Text, txbSoLuong.Text, txbMota.Text, txbLoai.Text, imgbyte))
                    this.Hide();
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
