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
        Control_User.Item item;
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
            string i = sp.Masp.ToString();
            if(i == id)
            {
                Item_HD item_HD = new Item_HD(sp.Masp.ToString(), sp.Ten, sp.IDLoai.ToString(), Convert.ToInt32(txbSLMua.Text), sp.Gia, item.picture.Image);
                Item_HD.item_HDs.Add(item_HD);
                MessageBox.Show("Them vao gio hang thanh cong");
                Store_performence.reloadlb(Store_performence.slhangtronggio);
                this.Close();
            }
            
        }

        private void btnAddSL_Click(object sender, EventArgs e)
        {
            txbSLMua.Text = (Convert.ToInt32(txbSLMua.Text)+1).ToString();
        }

        private void Detail_Form_Load(object sender, EventArgs e)
        {

            foreach (Control_User.Item item in UI_Home.ListItem)
            {
                this.item = item;
                sp = (item.btnItem.Tag as SANPHAM);
                string i = sp.Masp.ToString();
                if (i == id)
                {
                    lbName.Text = sp.Ten;
                    lbGia.Text = "Giá: " + sp.Gia.ToString();
                    lbSL.Text = "Số lượng: "+sp.SL.ToString();
                    lbDetail.Text = sp.MoTa;
                    picture.Image = Library.ConvertoImage(sp.Anh) == null ? Properties.Resources.NoImage : Library.ConvertoImage(sp.Anh);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    return;
                }
            }
            
        }
        

        private void txbSLMua_TextChanged(object sender, EventArgs e)
        {
            if (txbSLMua.Text == "")
                return;
            if (Convert.ToInt32(txbSLMua.Text) > sp.SL)
            {
                txbSLMua.Text = sp.SL.ToString();
                MessageBox.Show("Số lượng không đủ.");
            }
        }
    }
}
