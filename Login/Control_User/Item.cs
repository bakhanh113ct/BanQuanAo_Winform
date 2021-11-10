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

namespace Login.Control_User
{
    public partial class Item : UserControl
    {
        SANPHAM sanpham;
        public Store_performence Parent_Store { get; set; }
        public Partner_performance Parent_Partner { get; set; }
        ////Thông tin của từng item 
        //public string Ten;
        //public double gia;
        //public int soluong;
        //public double danhgia;
        //public int daban;
        //public string mota;
        //public int Loai;
        public Item() { }
        public Item(SANPHAM item, Control panel)
        {
            Parent_Store = panel as Store_performence;
            Parent_Partner = panel as Partner_performance;
            InitializeComponent();
            Init(item);
            this.sanpham = item;
        }

        private void Init(SANPHAM item)
        {
            //this.Ten = Ten;
            //this.gia = gia;
            //this.soluong = soluong;
            //this.danhgia = danhgia;
            //this.daban = daban;
            //this.mota = mota;
            //this.Loai = Loai;
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
            lbDaBan.Text = "Ban: " + item.SL.ToString();
            lbName.ForeColor = Color.FromKnownColor(KnownColor.Black);
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            //SubForm.Detail_Form detail_form = new SubForm.Detail_Form(this);
            //detail_form.lbName.Text = Ten;
            //detail_form.lbGia.Text = gia.ToString();
            //detail_form.lbSL.Text = soluong.ToString();
            //detail_form.lbDetail.Text = mota;
            //detail_form.picture.Image = picture.Image;
            //detail_form.picture.SizeMode = PictureBoxSizeMode.CenterImage;
            //detail_form.ShowDialog();
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
            if (Parent_Partner != null)
            {
                Parent_Partner.sanpham = sanpham;
            }
            btnItem.FillColor = Color.Yellow;
        }

    }
}
