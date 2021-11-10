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
using Login.DTO;
using Login.DAO;

namespace Login.SubForm
{
    public partial class Edit_Form : Form
    {
        public bool check_save_click;
        public bool check_delete_click;
        public string id;
        public Edit_Form()
        {
            InitializeComponent();
        }

        private void Edit_Form_Load(object sender, EventArgs e)
        {
            check_save_click = false;
            check_delete_click = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] imgbyte = ConvertoByte(picture.Image);
            if (imgbyte != null)
                if (SanPhamDAO.UpdateSP(txbTen.Text, txbGiaTien.Text, txbSoLuong.Text, txbMota.Text, txbLoai.Text, imgbyte, id))
                {
                    check_save_click = true;
                    this.Close();
                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SanPhamDAO.DeleteSP(id))
            {
                check_delete_click = true;
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

        
    }
}
