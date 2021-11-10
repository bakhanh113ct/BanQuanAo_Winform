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
        static public SANPHAM sanpham;
        List<SANPHAM> listsp;
        //public static List<Control_User.Item> list = new List<Control_User.Item>();
        public SubForm.Edit_Form editform = new SubForm.Edit_Form();    //mọi item đều có chung 1 form edit
        public Store_performence()
        {
            InitializeComponent();
            cbbFilter.SelectedIndex = 4;
        }
        private void Store_performence_Load(object sender, EventArgs e)
        {
            LoadPanel();
        }

        public void LoadPanel()
        {
            if(UI_Home.ListItem != null) UI_Home.ListItem.Clear();
            flpnStore.Controls.Clear();
            listsp = SanPhamDAO.LoadSP();
            foreach (SANPHAM item in listsp)
            {
                Control_User.Item u = new Control_User.Item(item ,UI_Home.store);
                //Load ảnh
                u.btnItem.Tag = item;
                byte[] b = item.Anh;
                u.picture.Image = ConvertoImage(b);
                //gan the tag = item de dung luc sau...
                u.btnItem.Tag = item;
                //them vao danh sach item o UI_HOME
                UI_Home.ListItem.Add(u);
                //them vao panel
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
            additem.Close();
        }

        private void Filter(string Loai)
        {
            flpnStore.Controls.Clear();
           
            foreach(Control_User.Item item in UI_Home.ListItem)
            {
                int i = (item.btnItem.Tag as SANPHAM).IDLoai;
                if (i == 1 && Loai == "Quan")
                    flpnStore.Controls.Add(item);
                else if (i == 2 && Loai == "Ao")
                    flpnStore.Controls.Add(item);
                else if (i == 3 && Loai == "Mu")
                    flpnStore.Controls.Add(item);
                else if (i == 4 && Loai == "Giay")
                    flpnStore.Controls.Add(item);
                else if (Loai == "All")
                    flpnStore.Controls.Add(item);
            }

        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2ComboBox i = (Guna.UI2.WinForms.Guna2ComboBox)sender;
            switch (i.SelectedIndex)
            {
                case 0:
                    Filter("Quan");
                    break;
                case 1:
                    Filter("Ao");
                    break;
                case 2:
                    Filter("Mu");
                    break;
                case 3:
                    Filter("Giay");
                    break;
                case 4:
                    Filter("All");
                    break;
            }
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            if (sanpham == null)
            {
                MessageBox.Show("Vui lòng chọn item");
                return;
            }
            editform.txbTen.Text = sanpham.Ten;
            editform.txbGiaTien.Text = sanpham.Gia.ToString();
            editform.txbSoLuong.Text = sanpham.SL.ToString();
            editform.txbMota.Text = sanpham.MoTa;
            editform.txbLoai.Text = sanpham.IDLoai.ToString();
            editform.txbNhacungcap.Text = "a";
            editform.picture.Image = ConvertoImage(sanpham.Anh);
            editform.picture.SizeMode = PictureBoxSizeMode.CenterImage;
            editform.id = sanpham.Masp.ToString();
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
            sanpham = null;
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
