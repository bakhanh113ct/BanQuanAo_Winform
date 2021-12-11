using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangQuanAo.DAO
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
        }

        public DataTable LoadCTHD(string SoHD)
        {
            DataTable data = DAO.DataProvider.ExecuteQuery("select ANH, TEN, TENLOAI, CTHD.SL, GIA " +
                                                        "from CTHD, SANPHAM, LOAISP " +
                                                        "where CTHD.MASP = SANPHAM.MASP " +
                                                        "AND IDLOAI = LOAISP.ID " +
                                                        "AND SOHD = '"+SoHD+"'");
            return data;
        }

        public bool DeleteCTHD(string SoHD)
        {
            int check = DAO.DataProvider.ExecuteNonQuery("delete from CTHD where SOHD = '" + SoHD + "'");
            if (check == 0)
                return false;
            else
                return true;
        }
    }
}
