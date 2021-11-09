using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DAO
{
    class OrderList
    {
        public static List<Control_User.list_order> dcm = new List<Control_User.list_order>();
        public static void load()
        {
            DataTable dt = DAO.DataProvider.ExcuseQuery1("exec test");
            foreach(DataRow row in dt.Rows)
            {
                Control_User.list_order temp = new Control_User.list_order(row);
                dcm.Add(temp);
            }

            
        }
    }
}
