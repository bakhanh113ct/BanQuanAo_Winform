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

namespace QLCuaHangQuanAo.Control_User
{
    public partial class Item : UserControl
    {
        SANPHAM sanpham;
        public List<Item_HD> item_HDs = new List<Item_HD>();
        public Item() { }
        public Item(SANPHAM item)
        {
            InitializeComponent();
            Init(item);
            this.sanpham = item;
        }

        private void Init(SANPHAM item)
        {
            //Load ảnh
            byte[] b = item.Anh;
            this.picture.Image = Library.ConvertoImage(b) == null ? Properties.Resources.NoImage : Library.ConvertoImage(b);
            btnTinhTrang.BackColor = Color.Transparent;
            lbName.Text = item.Ten;
            if (item.SL > 0)
            {
                btnTinhTrang.Text = "Còn";
                btnTinhTrang.BackColor = Color.Transparent;
                btnTinhTrang.FillColor = Color.FromArgb(68, 201, 97);
            }
            lbGia.Text = item.Gia.ToString() + " VND";
            lbSoLuong.Text = "Còn: " + ((item.SL) <= 0 ? 0 : item.SL).ToString();
            lbDaBan.Text = "Bán: " + item.DaBan.ToString();
            lbName.ForeColor = Color.FromKnownColor(KnownColor.Black);
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(Login.tk.Typetk == 0)
            {
                SubForm.AddSL addSL = new SubForm.AddSL(sanpham.Masp);
                addSL.ShowDialog();
            }
            else
            {
                SubForm.Detail_Form detail_form = new SubForm.Detail_Form((btnItem.Tag as SANPHAM).Masp.ToString());
                detail_form.ShowDialog();
            }
            
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            foreach (Item i in UI_Home.ListItem)
            {
                i.btnItem.FillColor = Color.Transparent;
            }
            Store_performence.sanpham = sanpham;
            btnItem.FillColor = Color.FromArgb(194, 130, 252);
        }
        private void picture_Click(object sender, EventArgs e)
        {
            btnItem_Click(btnItem, e);
        }
    }
}
