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
            load();
        }
        void load()
        {
            //xem.Visible = false;
            kh = DAO.KhachHangDAO.Instance.loadlistKH();
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
    }
}
