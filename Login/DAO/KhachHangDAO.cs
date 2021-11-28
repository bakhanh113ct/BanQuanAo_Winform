using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set => instance = value;
        }
        public DataTable loadtopKH()
        {
            return DataProvider.ExcuseQuery1("select top 3  HOTEN, ANH, sum(TRIGIA) AS DOANHSO " +
                "FROM KHACHHANG, HOADON WHERE HOADON.MAKH = KHACHHANG.MAKH " +
                "group by  HOTEN, ANH " +
                "order by sum(TRIGIA) DESC");
        }
        public int SLKH()
        {
            int dem = 0;
            DataTable sl = DataProvider.ExcuseQuery1("Select count(MAKH) as SLKH from KHACHHANG");
            foreach(DataRow x in sl.Rows)
            {
                dem = (int)x["SLKH"];
            }
            return dem;
        }

        internal DataTable loadInfo(int SOHD)
        {
             return DataProvider.ExcuseQuery1("select HOTEN, DCHI, SOHD, NGHD, TRANG_THAI from KHACHHANG, HOADON " +
                 "where SOHD = " + SOHD + " and KHACHHANG.MAKH = HOADON.MAKH");
        }

        
    }
}
