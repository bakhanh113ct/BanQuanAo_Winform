﻿using System;
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

        public DTO.KHACHHANG LoadKH(int id)
        {
            DTO.KHACHHANG kh;
            DataTable data = DAO.DataProvider.ExecuteQuery("Select * from KHACHHANG where IDUSERNAME = '" + id + "'");
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

        public bool InsertKH(DTO.KHACHHANG kh)
        {
            int kq = DAO.DataProvider.ExecuteNonQuery("insert into KHACHHANG(IDUSERNAME, HOTEN, DCHI, SODT, NGSINH, GIOITINH, ANH) values('" + kh.IdUsername + "','" + kh.HoTen + "','" + kh.DiaChi + "','" + kh.SoDT + "', '" + kh.NgSinh + "', '" + kh.Gioitinh + "', null)");
            if (kq != 0)
                return true;
            return false;
        }
        public bool Update(DTO.KHACHHANG kh)
        {
            int check;
            if (kh.Anh == null)
                check = DAO.DataProvider.ExecuteNonQuery("update KHACHHANG set HOTEN = @Ten , DCHI = @Diachi , SODT = @SDT , NGSINH = @Ngsinh , GIOITINH = @Gioitinh , ANH = @Anh where MAKH = '" + Login.kh.MaKH + "'",
                                                            new object[] { kh.HoTen, kh.DiaChi, kh.SoDT, kh.NgSinh, kh.Gioitinh, "NULL" });
            else
            {
                check = DAO.DataProvider.ExecuteNonQuery("update KHACHHANG set HOTEN = @Ten , DCHI = @Diachi , SODT = @SDT , NGSINH = @Ngsinh , GIOITINH = @Gioitinh , ANH = @Anh where MAKH = '" + Login.kh.MaKH + "'",
                                                            new object[] { kh.HoTen, kh.DiaChi, kh.SoDT, kh.NgSinh, kh.Gioitinh, kh.Anh });
            }
            if (check == 0)
                return false;
            else
                return true;
            return false;
        }
    }
}
