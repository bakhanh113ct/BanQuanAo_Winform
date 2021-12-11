using QLCuaHangQuanAo.DAO;
using QLCuaHangQuanAo.DTO;
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

namespace QLCuaHangQuanAo
{
    public partial class Store_performence : Form
    {
        static public SANPHAM sanpham;
        public Guna.UI2.WinForms.Guna2Chip btnSoHang = new Guna.UI2.WinForms.Guna2Chip();
        static public Label label1 = new Label();
        List<SANPHAM> listsp;
        public Store_performence()
        {
            InitializeComponent();
            cbbFilter.SelectedIndex = 4;
        }
        private void Store_performence_Load(object sender, EventArgs e)
        {
            //219, 0
            LoadPanel();
            ThemSLHang();
            if (Login.tk.Typetk == 1)
            {
                btnAdd.Visible = false;
                btnEdit.Visible = false;
            }
            else
                btnCart.Location = new Point(219, 0);
        }
        
        public void LoadPanel() //Load lại flowlayoutpanel
        {
            if(UI_Home.ListItem != null) UI_Home.ListItem.Clear();
            flpnStore.Controls.Clear();
            listsp = SanPhamDAO.Instance.LoadListSP();
            foreach (SANPHAM item in listsp)
            {
                Control_User.Item u = new Control_User.Item(item);
                u.btnItem.Tag = item;
                //gan the tag = item de dung luc sau...
                //them vao danh sach item o UI_HOME
                UI_Home.ListItem.Add(u);
                //them vao panel
                flpnStore.Controls.Add(u);
            }
        }
        
        public void btnReload_Click(object sender, EventArgs e)
        {
            cbbFilter.SelectedIndex = 4;
            LoadPanel();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SubForm.Add_Item_Form additem = new SubForm.Add_Item_Form();
            additem.ShowDialog(this);
            LoadPanel();
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            if (sanpham == null)
            {
                MessageBox.Show("Vui lòng chọn item");
                return;
            }
            SubForm.Edit_Form editform = new SubForm.Edit_Form(sanpham.Masp.ToString());
            editform.ShowDialog();
            //reload panel
            if (Check_update(editform) || Check_delete(editform))
            {
                LoadPanel();
                sanpham = null;
            }
            
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            SubForm.Cart_Form cart_Form = new SubForm.Cart_Form();
            cart_Form.ShowDialog();
            LoadPanel();
        }

        private bool Check_update(SubForm.Edit_Form editform)
        {
            if (editform.DialogResult == DialogResult.OK)
                return true;
            return false;
        }
        private bool Check_delete(SubForm.Edit_Form editform)
        {
            if (editform.DialogResult == DialogResult.Abort)
                return true;
            return false;
        }

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                int k = 0;
                foreach (Control_User.Item item in UI_Home.ListItem)
                {
                    SANPHAM i = (item.btnItem.Tag as SANPHAM);
                    if (i.Ten.Contains(txbSearch.Text) && (i.IDLoai == cbbFilter.SelectedIndex + 1 || cbbFilter.SelectedIndex == 4))
                    {
                        k++;
                        if (k == 1)
                            flpnStore.Controls.Clear();
                        flpnStore.Controls.Add(item);
                    }
                }
                if (k == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm");
                }
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

        private void Filter(string Loai)
        {
            flpnStore.Controls.Clear();
            //1. Quần, 2.Áo, 3.Mũ, 4. Giày,Dép
            foreach (Control_User.Item item in UI_Home.ListItem)
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

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            int k = 0;
            foreach (Control_User.Item item in UI_Home.ListItem)
            {
                SANPHAM i = (item.btnItem.Tag as SANPHAM);
                if (i.Ten.Contains(txbSearch.Text) && (i.IDLoai == cbbFilter.SelectedIndex + 1 || cbbFilter.SelectedIndex == 4))
                {
                    k++;
                    if (k == 1)
                        flpnStore.Controls.Clear();
                    flpnStore.Controls.Add(item);
                }
            }
        }

        private void ThemSLHang()
        {
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(2, 2);
            label1.Name = "label1";
            label1.Size = new Size(14, 13);
            label1.Text = "0";

            btnSoHang.Controls.Add(label1);
            btnCart.Controls.Add(btnSoHang);
            btnSoHang.AutoRoundedCorners = true;
            btnSoHang.BackColor = Color.Transparent;
            btnSoHang.BorderRadius = 9;
            btnSoHang.FillColor = Color.Red;
            btnSoHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSoHang.ForeColor = Color.White;
            btnSoHang.IsClosable = false;
            btnSoHang.Location = new Point(22, 3);
            btnSoHang.Margin = new Padding(-2);
            btnSoHang.Name = "btnSoHang";
            btnSoHang.ShadowDecoration.Parent = btnSoHang;
            btnSoHang.Size = new Size(17, 17);
            btnSoHang.TabIndex = 0;
            btnSoHang.Text = "";
        }
        
        public static void reloadlb()
        {
            int i = Item_HD.item_HDs.Count();
            label1.Text = i.ToString();
        }
    }
}
