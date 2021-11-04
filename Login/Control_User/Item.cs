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
        public SubForm.Edit_Form editform;      //tạo 1 form edit để tham chiếu tới form edit từ store_performence
        public Store_performence ParentForm { get; set; }
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
            ParentForm = panel as Store_performence;
            InitializeComponent();
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
            btnGia.Text = gia.ToString() + " VND";
            SoLuong.Text = "SL: " + soluong.ToString();
            DaBan.Text = "Ban: " + daban.ToString();
            
        }
        
        public void Reload(string Ten, double gia, int soluong, string mota, string Loai)
        {
            this.Ten = Ten;
            this.gia = gia;
            this.soluong = soluong;
            this.danhgia = danhgia;
            this.daban = daban;
            this.mota = mota;
            this.Loai = Loai;
        }
        
        public void picture_Click(object sender, EventArgs e)
        {
            if(ParentForm != null)
                ParentForm.item = this;
        }

        private void btn_Background_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            SubForm.Detail_Form detail_form = new SubForm.Detail_Form();
            detail_form.ShowDialog();
        }
    }
}
