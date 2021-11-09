using Login.DAO;
using Login.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Store_performence : Form
    {

        public Control_User.Item item;
        public static List<Control_User.Item> list = new List<Control_User.Item>();
        public SubForm.Edit_Form editform = new SubForm.Edit_Form();    //mọi item đều có chung 1 form edit
        public Store_performence()
        {
            InitializeComponent();
        }
        private void Store_performence_Load(object sender, EventArgs e)
        {
            LoadPanel();
        }

        public void LoadPanel()
        {
            flpnStore.Controls.Clear();
            List<SANPHAM> listsp = SanPhamDAO.LoadSP();
            foreach (SANPHAM item in listsp)
            {
                Control_User.Item u = new Control_User.Item(item.Ten, item.Gia, item.SL, item.DanhGia, item.DaBan, item.MoTa, item.IDLoai, UI_Home.store);
                //Load ảnh
                byte[] b = item.Anh;
                u.picture.Image = ConvertoImage(b);
                u.btnItem.Tag = item;
                UI_Home.ListItem.Add(u);
                flpnStore.Controls.Add(u);
            }
        }
        //Load lại flowlayoutpanel
        public void btnReload_Click(object sender, EventArgs e)
        {
            //flpnStore.Controls.Clear();
            LoadPanel();
        }

        //Chuyển byte sang ảnh
        public Image ConvertoImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SubForm.Add_Item_Form additem = new SubForm.Add_Item_Form();
            additem.ShowDialog(this);
            LoadPanel();
            additem.Hide();
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Guna.UI2.WinForms.Guna2ComboBox i = (Guna.UI2.WinForms.Guna2ComboBox)sender;
            //switch (i.SelectedIndex)
            //{
            //    case 0:
            //        LoadPanel("select * from SanPham where Loai = 'ao' or Loai = 'Ao'");
            //        break;
            //    case 1:
            //        LoadPanel("select * from SanPham where Loai = 'quan' or Loai = 'Quan'");
            //        break;
            //    case 2:
            //        LoadPanel("select * from SanPham where Loai = 'giay' or Loai = 'Giay' or Loai = 'dep' or Loai = 'Dep'");
            //        break;
            //    case 3:
            //        LoadPanel("select * from SanPham where Loai = 'mu' or Loai = 'Mu'");
            //        break;
            //    case 4:
            //        LoadPanel("select * from SanPham");
            //        break;
            //}
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                MessageBox.Show("Vui lòng chọn item");
                return;
            }
            editform.txbTen.Text = item.Ten;
            editform.txbGiaTien.Text = item.gia.ToString();
            editform.txbSoLuong.Text = item.soluong.ToString();
            editform.txbMota.Text = item.mota;
            editform.txbLoai.Text = item.Loai.ToString();
            editform.txbNhacungcap.Text = "a";
            editform.picture.Image = item.picture.Image;
            editform.picture.SizeMode = PictureBoxSizeMode.CenterImage;
            //reload panel
            editform.ShowDialog();
            if (Check_update(editform))
            {
                LoadPanel();
            }
            if (Check_delete(editform))
            {
                LoadPanel();
            }
            item = null;
        }

        private bool Check_update(SubForm.Edit_Form editform)
        {
            if (editform.check_save_click == true)
                return true;
            return false;
        }
        private bool Check_delete(SubForm.Edit_Form editform)
        {
            if (editform.check_delete_click == true)
                return true;
            return false;
        }
    }
}
