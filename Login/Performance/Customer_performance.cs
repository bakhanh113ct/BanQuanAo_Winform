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
        
        public Customer_performance()
        {
            InitializeComponent();
            DAO.DataProvider.IntializeConnection();
            DAO.OrderList.load();
            load();
        }
        void load()
        {
            //Control_User.list_order x = new Control_User.list_order();
            //list_KH.Controls.Add(x);
            //Control_User.list_order x1 = new Control_User.list_order();
            //list_KH.Controls.Add(x1);
            //Control_User.list_order x2 = new Control_User.list_order();
            //list_KH.Controls.Add(x2);
            //Control_User.list_order x3 = new Control_User.list_order();
            //list_KH.Controls.Add(x3);
            foreach(Control_User.list_order x in  DAO.OrderList.dcm)
            {
                list_KH.Controls.Add(x);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
