using Login.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.SubForm
{
    public partial class Detail_Form : Form
    {
        public string id;
        public Detail_Form()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach(Control_User.Item item in UI_Home.ListItem)
            {
                SANPHAM sp = (item.btnItem.Tag as SANPHAM);
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
        }

        private void btnAddSL_Click(object sender, EventArgs e)
        {
            txbSLMua.Text = (Convert.ToInt32(txbSLMua.Text)+1).ToString() ;
        }

        private void Detail_Form_Load(object sender, EventArgs e)
        {

            foreach (Control_User.Item item in UI_Home.ListItem)
            {
                SANPHAM sp = (item.btnItem.Tag as SANPHAM);
                string i = sp.Masp.ToString();
                if (i == id)
                {
                    lbName.Text = sp.Ten;
                    lbGia.Text = sp.Gia.ToString();
                    lbSL.Text = sp.SL.ToString();
                    lbDetail.Text = sp.MoTa;
                    picture.Image = picture.Image;
                    picture.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
            
        }
    }
}
