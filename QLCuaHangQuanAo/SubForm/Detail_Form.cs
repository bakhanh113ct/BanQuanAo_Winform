using QLCuaHangQuanAo.DTO;
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
    public partial class Detail_Form : Form
    {
        SANPHAM sp;
        private string id;
        public Detail_Form(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txbSLMua.Text) == 0)
            {
                MessageBox.Show("Nhập số lượng.");
                return;
            }
            foreach(Item_HD item in Item_HD.item_HDs)
            {
                if(id == item.MaSP)
                {
                    item.Sl += Convert.ToInt32(txbSLMua.Text);
                    MessageBox.Show("Cập nhật số lượng thành công");
                    this.Close();
                    return;
                }
            }
            Item_HD item_HD = new Item_HD(sp.Masp.ToString(), sp.Ten, sp.IDLoai, Convert.ToInt32(txbSLMua.Text), sp.Gia, Library.ConvertoImage(sp.Anh));
            Item_HD.item_HDs.Add(item_HD);
            MessageBox.Show("Thêm vào giỏ hàng thành công.");
            Store_performence.reloadlb();
            this.Close();
            
        }

        private void btnAddSL_Click(object sender, EventArgs e)
        {
            try
            {
                txbSLMua.Text = (Convert.ToInt32(txbSLMua.Text)+1).ToString();
            }
            catch
            {
                txbSLMua.Text = "0";
            }
        }

        private void Detail_Form_Load(object sender, EventArgs e)
        {
            sp = DAO.SanPhamDAO.Instance.LoadSP(id);
            lbName.Text = sp.Ten;
            lbGia.Text = "Giá: " + sp.Gia.ToString();
            lbSL.Text = "Số lượng: "+sp.SL.ToString();
            lbDetail.Text = sp.MoTa;
            picture.Image = Library.ConvertoImage(sp.Anh) == null ? Properties.Resources.NoImage : Library.ConvertoImage(sp.Anh);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            return;
        }
        

        private void txbSLMua_TextChanged(object sender, EventArgs e)
        {
            if (txbSLMua.Text == "")
                return;
            try
            {
                if (Convert.ToInt32(txbSLMua.Text) > sp.SL)
                {
                    txbSLMua.Text = sp.SL.ToString();
                    MessageBox.Show("Số lượng không đủ.");
                }
            }
            catch
            {

            }
            
        }
    }
}
