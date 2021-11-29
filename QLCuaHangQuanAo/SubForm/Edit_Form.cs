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
using QLCuaHangQuanAo.DTO;
using QLCuaHangQuanAo.DAO;

namespace QLCuaHangQuanAo.SubForm
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
            foreach (Control_User.Item item in UI_Home.ListItem)
            {
                SANPHAM sp = (item.btnItem.Tag as SANPHAM);
                string i = sp.Masp.ToString();
                if (i == id)
                {
                    txbTen.Text = sp.Ten;
                    txbGiaTien.Text = sp.Gia.ToString();
                    txbSoLuong.Text = sp.SL.ToString();
                    txbMota.Text = sp.MoTa;
                    txbLoai.Text = sp.IDLoai.ToString();
                    picture.Image = Library.ConvertoImage(sp.Anh) == null ? Properties.Resources.NoImage : Library.ConvertoImage(sp.Anh);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] imgbyte = Library.ConvertoByte(picture.Image);
            if (imgbyte != null)
                if (SanPhamDAO.UpdateSP(txbTen.Text, txbGiaTien.Text, txbSoLuong.Text, txbMota.Text, txbLoai.Text, imgbyte, id))
                {
                    MessageBox.Show("Cap nhat thanh cong.");
                    check_save_click = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cap nhat khong thanh cong.");
                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SanPhamDAO.DeleteSP(id))
            {
                DialogResult result = MessageBox.Show("Xoa thanh cong.");
                check_delete_click = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Xoa khong thanh cong.");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Library.LoadFromDialog(picture);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
