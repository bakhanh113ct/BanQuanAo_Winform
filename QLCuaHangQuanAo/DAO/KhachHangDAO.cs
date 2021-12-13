using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangQuanAo.DAO
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

        public DTO.KHACHHANG LoadKH(int id)
        {
            DTO.KHACHHANG kh;
            DataTable data = DAO.DataProvider.ExecuteQuery("Select * from KHACHHANG where IDTK = '" + id + "'");
            DataRow row = data.Rows[0];
            kh = new DTO.KHACHHANG(row);
            return kh;
           
        }
        public int GetIdMax()
        {
            object kq = DAO.DataProvider.ExecuteScalar("select max(MAKH) from KHACHHANG");
            if (kq is System.DBNull)
                return 0;
            return (int)kq;
        }
        public int SLKH()
        {
            int dem = 0;
            DataTable sl = DataProvider.ExcuseQuery1("Select count(MAKH) as SLKH from KHACHHANG");
            foreach (DataRow x in sl.Rows)
            {
                dem = (int)x["SLKH"];
            }
            return dem;
        }

        public bool InsertKH(DTO.KHACHHANG kh) {
            int kq = DAO.DataProvider.ExcuseNonQuery1("insert into KHACHHANG(IDTK, HOTEN, DCHI, SODT, EMAIL, NGSINH, GIOITINH, ANH) values('" + kh.IdUsername + "', N'" + kh.HoTen + "',N'" + kh.DiaChi + "', N'" + kh.SoDT + "', '" + kh.Email + "','" + kh.NgSinh + "', '" + kh.Gioitinh + "', null)");
            if (kq != 0)
                return true;
            return false;

        }
        public bool Update(DTO.KHACHHANG kh)
        {
            int check;
            if (kh.Anh == null)
                check = DAO.DataProvider.ExecuteNonQuery("update KHACHHANG set HOTEN = @Ten , DCHI = @Diachi , SODT = @SDT , EMAIL = @EMAIL , NGSINH = @Ngsinh , GIOITINH = @Gioitinh , ANH = @Anh where MAKH = '" + Login.kh.MaKH + "'",
                                                            new object[] { kh.HoTen, kh.DiaChi, kh.SoDT, kh.Email , kh.NgSinh, kh.Gioitinh, "NULL" });
            else
                check = DAO.DataProvider.ExecuteNonQuery("update KHACHHANG set HOTEN = @Ten , DCHI = @Diachi , SODT = @SDT , EMAIL = @EMAIL , NGSINH = @Ngsinh , GIOITINH = @Gioitinh , ANH = @Anh where MAKH = '" + Login.kh.MaKH + "'",
                                                           new object[] { kh.HoTen, kh.DiaChi, kh.SoDT, kh.Email , kh.NgSinh, kh.Gioitinh, kh.Anh });
            if (check == 0)
                return false;
            else
                return true;
        }
            
             
                
        internal DataTable loadInfo(int SOHD)
        {
           return DataProvider.ExcuseQuery1("select HOTEN, DCHI, SOHD, NGHD, TRANG_THAI from KHACHHANG, HOADON " +
                 "where SOHD = " + SOHD + " and KHACHHANG.MAKH = HOADON.MAKH");
        }

    }
}
