using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo.Performance
{
    public partial class Customer_perfomances : Form
    {
        public static List<Control_User.Customer> kh = new List<Control_User.Customer>();
        public Customer_perfomances()
        {
            InitializeComponent();
            addkieusx();
        }
        void addkieusx()
        {
            
            thang.Items.Add("Doanh thu tăng");
            thang.Items.Add("Doanh thu giảm");
            thang.Items.Add("Số lượng HĐ tăng");
            thang.Items.Add("Số lượng hóa đơn giảm");
            thang.SelectedIndex = 0;
            
        }
        void load(string kieu)
        {
            //xem.Visible = false;
            kh = DAO.KhachHangDAO.Instance.loadlistKH(kieu);
            foreach (Control_User.Customer x in kh)
            {
                list_KH.Controls.Add(x);
                //x.thao_tac.Click += show_chi_tiet;//them sự kiện click cho Control_user 
            }
        }

        private void xem_Click(object sender, EventArgs e)
        {
            Library.load_click();
            foreach (Control_User.Customer x in kh)
            {
                if(x.nen.FillColor == Color.FromArgb(174, 78, 191))
                {
                    SubForm.TTKH ttkh = new SubForm.TTKH(x.MAKH);
                    ttkh.Show();
                    return;
                }
            }
            MessageBox.Show("Vui lòng chọn khách hàng bạn muốn xem");
        }

        private void tim_theo_ten_TextChanged(object sender, EventArgs e)
        {
            int k = 0;
            foreach (Control_User.Customer i in kh)
            {
                //ie i = (item.btnItem.Tag as SANPHAM);
                if (i.Tenkh.Contains(tim_theo_ten.Text))
                {
                    k++;
                    if (k == 1)
                        list_KH.Controls.Clear();
                    list_KH.Controls.Add(i);
                }
            }
        }

        private void thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (thang.SelectedIndex)
            {
                case 0:
                    list_KH.Controls.Clear();
                    load("Sum(TRIGIA) desc");
                    break;
                case 1:
                    list_KH.Controls.Clear();
                    load("Sum(TRIGIA) asc");
                    break;
                case 2:
                    list_KH.Controls.Clear();
                    load("Count(SOHD) desc");
                    break;
                case 3:
                    list_KH.Controls.Clear();
                    load("Count(SOHD) asc");
                    break;
            }

        }
    }
}
