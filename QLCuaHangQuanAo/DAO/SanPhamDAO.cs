﻿using QLCuaHangQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return instance; }
            private set => instance = value;
        }

        public static List<SANPHAM> LoadSP()
        {
            List<SANPHAM> lll = new List<SANPHAM>();

            DataTable data = DataProvider.ExecuteQuery("select * from SANPHAM");
            foreach (DataRow item in data.Rows)
            {
                SANPHAM sanpham = new SANPHAM(item);
                lll.Add(sanpham);
            }
            return lll;
        }
        public static List<SANPHAM> LoadSP1()
        {
            List<SANPHAM> lll = new List<SANPHAM>();

            DataTable data = DataProvider.ExcuseQuery1("select * from SANPHAM");
            foreach (DataRow item in data.Rows)
            {
                SANPHAM sanpham = new SANPHAM(item);
                lll.Add(sanpham);
            }
            return lll;
        }
        static public bool InsertSP(string ten, string gia, string SL, string mota, string loai, byte[] image)
        {
            int check = DAO.DataProvider.ExecuteNonQuery("Insert into SANPHAM(TEN, GIA, SL, DANHGIA, DABAN , MOTA, IDLOAI, ANH) values( @TEN , @GIA , @SL , @DANHGIA , @DABAN  , @MOTA ,  @IDLOAI , @ANH )", 
                                             new object[] { ten, gia, SL, "0", "0" , mota, loai, image });
            if (check == 0)
                return false;
            else
                return true;
            return false;
        }

        internal DataTable loadSLBanDc(int month)
        {
            return DataProvider.ExcuseQuery1("select TENLOAI, sum(CTHD.SL) as SL FROM LOAISP,SANPHAM, CTHD, HOADON " +
                "WHERE CTHD.MASP = SANPHAM.MASP and HOADON.SOHD = CTHD.SOHD " +
                "AND IDLOAI = ID and month(NGHD) = "+ month +" GROUP BY TENLOAI");
        }

        static public bool UpdateSP(string ten, string gia, string SL, string mota, string loai, byte[] image, string old_Name)
        {
            int check = DAO.DataProvider.ExecuteNonQuery("update SANPHAM set TEN = @Ten , GIA = @Gia , SL = @SoLuong , DANHGIA = @DanhGia , DABAN = @DaBan , MOTA = @MoTa , IDLOAI = @Loai , ANH = @Anh where MASP = '" + old_Name + "'",
                                                            new object[] { ten , gia , SL , "0" , "0" , mota , loai , image });
            if (check == 0)
                return false;
            else
                return true;
            return false;
        }

        internal object SLSP()
        {
            DataTable temp = DataProvider.ExcuseQuery1("select count(MASP) as SL from SANPHAM");
            foreach (DataRow row in temp.Rows)
            {
                return row["SL"].ToString();
            }
            return null;
        }

        static public bool DeleteSP(string id)
        {
           DAO.DataProvider.ExcuseNonQuery1("delete from SANPHAM where MASP = '"+id+"'");
            //if (check == 0)
            //    return false;
            //else
            //    return true;
            return false;
        }

        public bool ReduceSL(string sl, string id)
        {
            int check = DataProvider.ExecuteNonQuery("update SANPHAM set SL -= '" + sl + "' where MASP = '" + id + "'");
            if (check == 0)
                return false;
            else
                return true;
            return false;
        }

        public void IncreaseDaban(string sl, string id)
        {
            DataProvider.ExecuteNonQuery("update SANPHAM set DABAN += '" + sl + "' where MASP = '" + id + "'");
        }
        //public void update_SLSP(int SOHD)
        //{
        //    DataTable list_sp = DataProvider.ExcuseQuery1("select MASP, SL from CTHD where CTHD.SOHD = " + SOHD);

        //    foreach (DataRow row in list_sp.Rows)
        //    {
        //        int sl = (int)row["SL"];
        //        int masp = (int)row["MASP"];
        //        int soluong = 0;
        //        DataTable SL = DataProvider.ExcuseQuery1("select SL from SANPHAM where MASP = " + masp);
        //        foreach (DataRow row1 in SL.Rows)
        //        {
        //            soluong = (int)row1["SL"];
        //        }
        //        soluong -= sl;
        //        if (soluong >= 0)
        //        {
        //            DataProvider.ExcuseNonQuery1("update SANPHAM set SL = " + soluong + " where MASP =  " + masp);
        //        }
        //    }
        //}

        internal void SLSP_in_MASP(int MASP, int SL)
        {
            DataProvider.ExcuseNonQuery1("Update SANPHAM set SL += " + SL + " Where MASP = " + MASP);
        }

        public DataTable loadtopSP()
        {
            return DataProvider.ExcuseQuery1("select top 3 TEN,ANH, SUM(CTHD.SL) AS SL  " +
                "FROM SANPHAM, CTHD WHERE SANPHAM.MASP = CTHD.MASP  GROUP BY TEN, ANH order by sum(CTHD.SL) desc");
        }
        public DataTable loadSL()
        {
            return DataProvider.ExcuseQuery1("select TENLOAI, sum(SL) as SL " +
                "from LOAISP, SANPHAM " +
                "where IDLOAI = ID group by TENLOAI");
        }

        public int countSPsold()
        {
            DataTable tmp = DataProvider.ExcuseQuery1("select  count(CTHD.SL) as sl from CTHD, HOADON " +
                "where CTHD.SOHD = HOADON.SOHD and TRANG_THAI = 'Complete' and MOnth(NGHD) = MONTH(GETDATE())");
            foreach(DataRow x in tmp.Rows)
            {
                return (int)x["sl"];
            }
            return 0;
        }
    }
}
