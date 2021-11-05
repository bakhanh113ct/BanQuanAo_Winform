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
        public Store_performence Parent_Store { get; set; }
        public Partner_performance Parent_Partner { get; set; }
        //Thông tin của từng item 
        public string Ten;
        public double gia;
        public int soluong;
        public double danhgia;
        public int daban;
        public string mota;
        public string Loai;
        public Item() { }
        public Item(string Ten, double gia, int soluong, double danhgia, int daban, string mota, string Loai, Control panel)
        {
            Parent_Store = panel as Store_performence;
            Parent_Partner = panel as Partner_performance;
            InitializeComponent();
            Init(Ten, gia, soluong, danhgia, daban, mota, Loai);
            
        }

        private void Init(string Ten, double gia, int soluong, double danhgia, int daban, string mota, string Loai)
        {
            this.Ten = Ten;
            this.gia = gia;
            this.soluong = soluong;
            this.danhgia = danhgia;
            this.daban = daban;
            this.mota = mota;
            this.Loai = Loai;
            btnTinhTrang.BackColor = Color.Transparent;
            lbName.Text = Ten;
            if (soluong > 0)
            {
                btnTinhTrang.Text = "Còn";
                btnTinhTrang.BackColor = Color.Transparent;
                btnTinhTrang.FillColor = Color.FromArgb(68, 201, 97);
            }
            lbGia.Text = gia.ToString() + " VND";
            lbSoLuong.Text = "SL: " + soluong.ToString();
            lbDaBan.Text = "Ban: " + daban.ToString();
            lbName.ForeColor = Color.FromKnownColor(KnownColor.Black);
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            SubForm.Detail_Form detail_form = new SubForm.Detail_Form();
            detail_form.lbName.Text = Ten;
            detail_form.lbGia.Text = gia.ToString();
            detail_form.lbSL.Text = soluong.ToString();
            detail_form.lbDetail.Text = mota;
            detail_form.picture.Image = picture.Image;
            detail_form.picture.SizeMode = PictureBoxSizeMode.CenterImage;
            detail_form.ShowDialog();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            foreach(Item i in DBA.ListItem)
            {
                i.btnItem.FillColor = Color.Transparent;
            }
            if (Parent_Store != null)
            {
                Parent_Store.item = this;
            }
            if (Parent_Partner != null)
            {
                Parent_Partner.item = this;
            }
            btnItem.FillColor = Color.Yellow;
        }

    }
}
