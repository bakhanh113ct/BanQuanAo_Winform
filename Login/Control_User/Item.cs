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
        public SubForm.Edit_Form editform;
        public string Ten;
        public double gia;
        public int soluong;
        public int danhgia;
        public int daban;
        public string mota;
        public string Loai;
        public Item() { }
        public Item(string Ten, double gia, int soluong, int danhgia, int daban, string mota, string Loai)
        {
            InitializeComponent();
            this.Ten = Ten;
            this.gia = gia;
            this.soluong = soluong;
            this.danhgia = danhgia;
            this.daban = daban;
            this.mota = mota;
            this.Loai = Loai;

            lbName.Text = Ten;
            if (soluong > 0)
            {
                btnTinhTrang.Text = "Còn";
                btnTinhTrang.FillColor = Color.FromArgb(68, 201, 97);
            }
            btnGia.Text = gia.ToString() + " VND";
            SoLuong.Text = "SL: " + soluong.ToString();
            DaBan.Text = "Ban: " + daban.ToString();
            
        }
        private void Reload(SubForm.Edit_Form editform)
        {
            lbName.Text = editform.txbTen.Text;
            if (Convert.ToInt32(editform.txbSoLuong.Text) > 0)
            {
                btnTinhTrang.Text = "Còn";
                btnTinhTrang.FillColor = Color.FromArgb(68, 201, 97);
            }
            editform.txbGiaTien.Text = gia.ToString() + " VND";
            SoLuong.Text = "SL: " + editform.txbSoLuong.Text;
        }
        private bool Check_Change(SubForm.Edit_Form editform)
        {
            if(editform.check_save_click == true)
                return true;
            return false;
        }
        private bool Check_delete(SubForm.Edit_Form editform)
        {
            if (editform.check_delete_click == true)
                return true;
            return false;
        }
        private void picture_Click(object sender, EventArgs e)
        {
            //SubForm.Edit_Form editform = new SubForm.Edit_Form();
            editform.txbTen.Text = this.Ten;
            editform.txbGiaTien.Text = gia.ToString();
            editform.txbSoLuong.Text = soluong.ToString();
            editform.txbMota.Text = mota;
            editform.txbLoai.Text = mota;
            editform.txbNhacungcap.Text = "a";
            editform.picture.Image = this.picture.Image;
            editform.picture.SizeMode = PictureBoxSizeMode.CenterImage;
            editform.ShowDialog();
            if(Check_Change(editform))
                Reload(editform);
            if (Check_delete(editform))
                //this.Dispose();
                MessageBox.Show("a");
        }

        private void btn_Background_Click(object sender, EventArgs e)
        {

        }
    }
}
