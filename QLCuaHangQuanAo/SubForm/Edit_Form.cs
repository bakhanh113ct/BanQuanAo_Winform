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
        private string id;
        private SANPHAM sp;
        public Edit_Form(string id)
        {
            InitializeComponent();
            this.id = id;
            cbLoinhuan.SelectedIndex = 0;
        }

        private void Edit_Form_Load(object sender, EventArgs e)
        {
            sp = SanPhamDAO.Instance.LoadSP(id);
            txbTen.Text = sp.Ten;
            txbGiaTien.Text = sp.Gianhap.ToString();
            txbSoLuong.Text = sp.SL.ToString();
            txbMota.Text = sp.MoTa;
            txbLoai.Text = sp.IDLoai.ToString();
            GetLoiNhuan(sp);
            picture.Image = Library.ConvertoImage(sp.Anh) == null ? Properties.Resources.NoImage : Library.ConvertoImage(sp.Anh);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            
        }

        private void GetLoiNhuan(SANPHAM sp)
        {
            double profitPercent = (double)sp.Gia / sp.Gianhap;
            profitPercent = Math.Round(profitPercent, 3);
            txbLoinhuan.Text = (profitPercent*100).ToString() + "%";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] imgbyte = Library.ConvertoByte(picture.Image);
            if (imgbyte != null)
                if (SanPhamDAO.UpdateSP(txbTen.Text, txbGiaTien.Text, txbSoLuong.Text, sp.DaBan.ToString(), txbMota.Text, txbLoai.Text, imgbyte, id))
                {
                    MessageBox.Show("Cập nhật thành công.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công.");
                }
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SanPhamDAO.DeleteSP(id))
            {
                MessageBox.Show("Xoa thanh cong.");
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sản phẩm đang ở trong hóa đơn, không thể xóa.", "Thông báo",MessageBoxButtons.OK ,MessageBoxIcon.Error);
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
