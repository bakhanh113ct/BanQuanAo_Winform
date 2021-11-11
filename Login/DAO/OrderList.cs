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
            DataTable dt = DataProvider.ExcuseQuery1("exec test");

            foreach(DataRow row in dt.Rows)
            {
                Control_User.list_order temp = new Control_User.list_order(row);
                loadInfoFromDB.Add(temp);
            }
            return loadInfoFromDB;
        }
        public DataTable loadBill(int SOHD)
        {
            DataTable bill = DataProvider.ExcuseQuery1("Select SANPHAM.MASP, TEN, CTHD.SL, GIA from CTHD, SANPHAM WHERE CTHD.MASP = SANPHAM.MASP AND SOHD = " + SOHD);
            return bill;
        }

        public void update_SLSP(int SOHD)
        {
            DataTable list_sp = DataProvider.ExcuseQuery1("select MASP, SL from CTHD where CTHD.SOHD = " + SOHD);

            foreach(DataRow row in list_sp.Rows)
            {
                int sl = (int)row["SL"];
                int masp = (int)row["MASP"];
                int soluong = 0;
                DataTable SL = DataProvider.ExcuseQuery1("select SL from SANPHAM where MASP = " + masp);
                foreach(DataRow row1 in SL.Rows)
                {
                    soluong = (int)row1["SL"];
                }
                soluong -= sl;
                if (soluong >= 0)
                {
                    DataProvider.ExcuseNonQuery1("update SANPHAM set SL = " + soluong + " where MASP =  " + masp);
                }
            }
        }

        public bool thanh_toan(int index)
        {
            foreach (Control_User.list_order x in Customer_performance.dcm)
            {
                if (x.SoHD == index && x.Status == "Waiting")
                {
                    DataProvider.ExcuseNonQuery1("Update HOADON set TRANG_THAI = 'Complete' where SOHD = " + index);
                    update_SLSP(index);
                    x.change_trang_thai();

                    return true;
                }
            }
            return false;
        }
       
    }
}
