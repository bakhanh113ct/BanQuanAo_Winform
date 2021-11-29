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
        public Store_performence Parent_Store { get; set; }
        
        public Item() { }
        public Item(SANPHAM item, Control panel)
        {
            Parent_Store = panel as Store_performence;
            InitializeComponent();
            Init(item);
            this.sanpham = item;
        }

        private void Init(SANPHAM item)
        {
            //Load ảnh
            byte[] b = item.Anh;
            this.picture.Image = ConvertoImage(b) == null ? Properties.Resources.NoImage : ConvertoImage(b);
            btnTinhTrang.BackColor = Color.Transparent;
            lbName.Text = item.Ten;
            if (item.SL > 0)
            {
                btnTinhTrang.Text = "Còn";
                btnTinhTrang.BackColor = Color.Transparent;
                btnTinhTrang.FillColor = Color.FromArgb(68, 201, 97);
            }
            lbGia.Text = item.Gia.ToString() + " VND";
            lbSoLuong.Text = "SL: " + item.SL.ToString();
            lbDaBan.Text = "Ban: " + item.DaBan.ToString();
            lbName.ForeColor = Color.FromKnownColor(KnownColor.Black);
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            SubForm.Detail_Form detail_form = new SubForm.Detail_Form((btnItem.Tag as SANPHAM).Masp.ToString());
            detail_form.ShowDialog();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            foreach (Item i in UI_Home.ListItem)
            {
                i.btnItem.FillColor = Color.Transparent;
            }
            if (Parent_Store != null)
            {
                Store_performence.sanpham = sanpham;
            }
            btnItem.FillColor = Color.Yellow;
        }

        public Image ConvertoImage(byte[] data)
        {
            if (data != null)
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            else
                return null;
        }

        private void picture_Click(object sender, EventArgs e)
        {
            btnItem_Click(btnItem, e);
        }
    }
}
