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
        int index;
        public Customer_performance()
        {
            InitializeComponent();
            DAO.DataProvider.IntializeConnection();
            load();
            loadBill.Visible = false;
            thanh_toan.Visible = false;
            tong.Visible = false;
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
            loadBill.Visible = true;
            thanh_toan.Visible = true;

            foreach (Control_User.list_order x in dcm)
            {
                if (x.BackGround.FillColor == Color.FromArgb(174, 78, 191))
                {   
                    showBill(x.SoHD);
                    return;
                }
            }

        }
        private void showBill(int soHD)
        {
            DataTable Bill = DAO.OrderList.Instance.loadBill(soHD);
            index = soHD;
            loadBilltoBill(Bill);
        }

        private void loadBilltoBill(DataTable Bill)
        {
            tong.Visible = true;
            int total = 0;
            loadBill.Rows.Clear();

            foreach(DataRow x in Bill.Rows)
            {
                DTO.BillInfo temp = new DTO.BillInfo(x);
                loadBill.Rows.Add(temp.MaSP, temp.TenSP, temp.SL, temp.Gia.ToString());
                total += temp.Gia;
            }
            //loadBill.Rows.Add("", "", "Tổng:", total);
            tong.Text = "Tổng: " + total.ToString();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void thanh_toan_Click(object sender, EventArgs e)
        {

            if (DAO.OrderList.Instance.thanh_toan(index))
            {
                //(sender as Guna.UI2.WinForms.Guna2Button).FillColor = Color.White;
                MessageBox.Show("Hoàn thành");
                //DAO.OrderList.Instance.update_SLSP();

                list_KH.Controls.Clear();

                foreach (Control_User.list_order x in dcm)
                {
                    list_KH.Controls.Add(x);
                }
            }
            else
                MessageBox.Show("Hóa đơn này đã được thanh toán");
            
        }

        private void loadBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void list_KH_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
