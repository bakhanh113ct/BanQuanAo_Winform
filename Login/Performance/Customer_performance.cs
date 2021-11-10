using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Customer_performance : Form
    {
        public static List<Control_User.list_order> dcm = new List<Control_User.list_order>();
        public Customer_performance()
        {
            InitializeComponent();
            DAO.DataProvider.IntializeConnection();
            load();
        }
        void load()
        {
           dcm = DAO.OrderList.Instance.load();
           foreach(Control_User.list_order x in dcm)
            {
                list_KH.Controls.Add(x);
                x.thao_tac.Click += show_chi_tiet;

            }
        }
        private void show_chi_tiet(object sender, EventArgs e)
        {
            foreach (Control_User.list_order x in dcm)
            {
                if (x.BackGround.FillColor == Color.FromArgb(118, 53, 210))
                {
                    showBill(x.SoHD);
                    return;
                }
            }
        }
        private void showBill(int soHD)
        {
            DataTable Bill = DAO.OrderList.Instance.loadBill(soHD);
            loadBilltoBill(Bill);
        }

        private void loadBilltoBill(DataTable Bill)
        {
            loadBill.Rows.Clear();
            foreach(DataRow x in Bill.Rows)
            {
                DTO.BillInfo temp = new DTO.BillInfo(x);
                loadBill.Rows.Add(temp.TenSP, temp.SL, temp.Gia);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
