using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DAO
{
    public class CTHDDAO
    {
        private static CTHDDAO instance;

        public static CTHDDAO Instance
        {
            get { if (instance == null) instance = new CTHDDAO(); return instance; }
            private set => instance = value;
        }
        public bool InsertCTHD(string sohd, string masp, string sl)
        {
            int check = DAO.DataProvider.ExecuteNonQuery("insert into CTHD(SOHD,MASP,SL) values ( @SOHD , @MASP , @SL )", new object[] { sohd, masp, sl });
            if (check == 0)
                return false;
            else
                return true;
            return false;
        }
    }
}
