using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.DAO
{
    class OrderList
    {
        
        //public static List<DTO.BillInfo> dcmm = new List<DTO.BillInfo>();
        private static OrderList instance;
        public static OrderList Instance
        {
            get { if (instance == null) instance = new OrderList(); return instance; }
            private set => instance = value;
        }
        
        public List<Control_User.list_order> load()
        {
            List<Control_User.list_order> loadInfoFromDB = new List<Control_User.list_order>();
            DataTable dt = DAO.DataProvider.ExcuseQuery1("exec test");
            foreach(DataRow row in dt.Rows)
            {
                Control_User.list_order temp = new Control_User.list_order(row);
                loadInfoFromDB.Add(temp);
            }
            return loadInfoFromDB;
        }
        public DataTable loadBill(int SOHD)
        {
            DataTable bill = DAO.DataProvider.ExcuseQuery1("Select TEN, CTHD.SL, GIA from CTHD, SANPHAM WHERE CTHD.MASP = SANPHAM.MASP AND SOHD = " + SOHD);
            return bill;
        }
       
    }
}
