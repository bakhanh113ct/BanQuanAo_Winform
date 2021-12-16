using QLCuaHangQuanAo.Control_User;
using QLCuaHangQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set => instance = value;
        }

        static public List<HOADON> LoadHD()
        {
            List<HOADON> lll = new List<HOADON>();

            DataTable data = DataProvider.ExecuteQuery("select * from HOADON");
            foreach (DataRow item in data.Rows)
            {
                HOADON sanpham = new HOADON(item);
                lll.Add(sanpham);
            }
            return lll;
        }

        public DataTable LoadHDtoDatatable(string makh)
        {
            DataTable data = DataProvider.ExecuteQuery("select SOHD, NGHD, TRIGIA, TRANG_THAI from HOADON where MAKH = '"+makh+"'");
            return data;
        }

        static public bool InsertHD(string nghd, string makh, string trigia, string tt)
        {
            int check = DAO.DataProvider.ExecuteNonQuery("insert into HOADON(NGHD,MAKH,TRIGIA,TRANG_THAI) values ( '"+nghd+ "' , " + makh + " , " + trigia + " , " + tt + " )");
            if (check == 0)
                return false;
            else
                return true;
        }

        internal List<HDcuaKH> load_HD_KH(int makh)
        {
            List<Control_User.HDcuaKH> loadInfoFromDB = new List<Control_User.HDcuaKH>();
            DataTable dt = DataProvider.ExcuseQuery1("select SOHD, NGHD, TRANG_THAI, TRIGIA from HOADON, KHACHHANG " +
                "where KHACHHANG.MAKH  = HOADON.MAKH and KHACHHANG.MAKH = " + makh);
            int stt = 1;
            foreach (DataRow row in dt.Rows)
            {
                Control_User.HDcuaKH temp = new Control_User.HDcuaKH(row, stt++);
                loadInfoFromDB.Add(temp);
            }
            return loadInfoFromDB;
        }

        public DateTime getTimeXN(int index)
        {   

            DataTable temp = DataProvider.ExcuseQuery1("Select NGXN FROM HOADON WHERE SOHD =  " + index);
            foreach (DataRow row in temp.Rows)
            {
                try
                {

                    return (DateTime)row["NGXN"];
                }
                catch
                {
                    return DateTime.Now;
                }
            }
            return DateTime.Now;
        }

        internal DateTime getNGHD(int index)
        {
            DataTable temp = DataProvider.ExcuseQuery1("Select NGHD FROM HOADON WHERE SOHD =  " + index);
            foreach (DataRow row in temp.Rows)
            {
                return (DateTime)row["NGHD"];
            }
            return DateTime.Now;
        }

        internal object SLHD_huy()
        {
            DataTable temp = DataProvider.ExcuseQuery1("Select COUNT(SOHD) as SL from HOADON where TRANG_THAI = N'Hủy' and MONTH(NGHD) = " + DateTime.Now.Month);
            foreach(DataRow row in temp.Rows)
            {
                return row["SL"];
            }
            return 1;
        }

        //static public bool UpdateSP(string ten, string gia, string SL, string mota, string loai, byte[] image, string old_Name)
        //{
        //    int check = DAO.DataProvider.ExecuteNonQuery("update SANPHAM set TEN = @Ten , GIA = @Gia , SL = @SoLuong , DANHGIA = @DanhGia , DABAN = @DaBan , MOTA = @MoTa , IDLOAI = @Loai , ANH = @Anh where MASP = '" + old_Name + "'",
        //                                                    new object[] { ten, gia, SL, "0", "0", mota, loai, image });
        //    if (check == 0)
        //    {
        //        MessageBox.Show("Cap nhat khong thanh cong.");
        //        return false;
        //    }
        //    else
        //    {
        //        DialogResult result = MessageBox.Show("Cap nhat thanh cong.");
        //        if (result == DialogResult.OK)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //static public bool DeleteSP(string id)
        //{
        //    int check = DAO.DataProvider.ExecuteNonQuery("delete from SANPHAM where MASP = '" + id + "'");
        //    if (check == 0)
        //    {
        //        MessageBox.Show("Xoa khong thanh cong.");
        //        return false;
        //    }
        //    else
        //    {
        //        DialogResult result = MessageBox.Show("Xoa thanh cong.");
        //        if (result == DialogResult.OK)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        static public int getSoHD_MAX()
        {
            return (int)DAO.DataProvider.ExecuteScalar("select max(SOHD) from HOADON");
        }

        public List<DTO.HOADON> LoadHD(string makh)
        {
            List<DTO.HOADON> kq = new List<DTO.HOADON>();
            DataTable data = DataProvider.ExecuteQuery("select SOHD, NGHD, TRIGIA, TRANG_THAI from HOADON where MAKH = '" + makh + "'");
            foreach (DataRow item in data.Rows)
            {
                DTO.HOADON sanpham = new DTO.HOADON(item);
                kq.Add(sanpham);
            }
            return kq;
            //List < SANPHAM > lll = new List<SANPHAM>();

            //DataTable data = DataProvider.ExecuteQuery("select * from SANPHAM");
            //foreach (DataRow item in data.Rows)
            //{
            //    SANPHAM sanpham = new SANPHAM(item);
            //    lll.Add(sanpham);
            //}
            //return lll;
        }
        public DataTable loadBill(int SOHD)//Lấy thông tin sản phảm từ hóa đơn
        {
            DataTable bill = DataProvider.ExcuseQuery1("select SANPHAM.MASP, TEN, CTHD.SL, CTHD.GIA " +
                "from SANPHAM, CTHD where SOHD =  " + SOHD +
                " and SANPHAM.MASP = CTHD.MASP");
            return bill;
        }
        //public bool thanh_toan(int index)
        //{
        //    foreach (Control_User.list_order x in Invoice_performance.dcm)
        //    {
        //        if (x.SoHD == index && x.Status == "Waiting")
        //        {
        //            DataProvider.ExcuseNonQuery1("Update HOADON set TRANG_THAI = 'Complete' where SOHD = " + index);
        //           // SanPhamDAO.Instance.update_SLSP(index);
        //            //x.change_trang_thai();
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        public List<Control_User.list_order> load(string month)//load tất cả hóa đơn vào một danh sách
        {
            List<Control_User.list_order> loadInfoFromDB = new List<Control_User.list_order>();
            DataTable dt = DataProvider.ExcuseQuery1("select KHACHHANG.MAKH, HOTEN, NGHD, HOADON.SOHD, TRANG_THAI, ANH, SUM(SL) as SOHANG " +
                "from KHACHHANG, HOADON, CTHD " +
                "where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD " + month + " "+
                //"and MONTH(NGHD) = " + month +
                "group by KHACHHANG.MAKH, HOTEN, NGHD, HOADON.SOHD, TRANG_THAI, ANH order by NGHD DESC ");

            foreach (DataRow row in dt.Rows)
            {
                Control_User.list_order temp = new Control_User.list_order(row);
                loadInfoFromDB.Add(temp);
            }
            return loadInfoFromDB;
        }
        public DataTable loadDoanhSo()
        {
            return DataProvider.ExcuseQuery1("select MOnth(NGHD) as THANG, sum(TRIGIA) as GIA " +
                "from HOADON group by MONTH(NGHD)");
        }

        public string SLHD()//lấy số lượng của tất cả hóa đơn
        {
            DataTable sl = DataProvider.ExcuseQuery1("select count(SOHD) as SLHD from HOADON");
            foreach (DataRow x in sl.Rows)
            {
                return x["SLHD"].ToString();
            }
            return null;
        }
         public int SLHD_CRmonth()//Lấy số lượng hóa đơn trong tháng 
         {
            DataTable sl = DataProvider.ExcuseQuery1("select count(SOHD) as SL from HOADON " +
                "where MONTH(NGHD) = MONTH(GETDATE()) and (TRANG_THAI = N'Vận chuyển' or TRANG_THAI = N'Hoàn thành')");
            foreach (DataRow x in sl.Rows)
            {
                return (int)x["SL"];
            }
            return 0;
         }

        public DataTable getSlSP_inHD(int SOHD)
        {
            return DataProvider.ExcuseQuery1("select MASP, SL from CTHD, HOADON where CTHD.SOHD = HOADON.SOHD and CTHD.SOHD = " + SOHD);
        }

        public int SLHD_HOANTHANH()//Lấy số lượng hóa đơn trong tháng này trong trạng thái hoàn thành
        {
            DataTable sl = DataProvider.ExcuseQuery1("select count(SOHD) as SL from HOADON " +
                "where TRANG_THAI = N'Hoàn thành'" +
                "and MONTH(NGHD) = MONTH(GETDATE())");
            foreach (DataRow x in sl.Rows)
            {
                return (int)x["SL"];
            }
            return 0;
        }
        public float cmpHD()//So sánh số lượng hóa đơn so với tháng tước
        {
            int slfrompreM = 0;
            DataTable sl = DataProvider.ExcuseQuery1("select count(SOHD) as SL from HOADON " +
                "where (TRANG_THAI = N'Hoàn thành' or TRANG_THAI = N'Vận chuyển')" +
                "and MONTH(NGHD) = MONTH(GETDATE()) - 1");
            foreach (DataRow x in sl.Rows)
            {
                slfrompreM =  (int)x["SL"];
            }
             int slfromM = SLHD_CRmonth();
            float result = (((float)slfromM - (float)slfrompreM) / (float)slfrompreM) * 100;
            return result;
        }
        public string gettt(int SOHD)//Lấy trang thái hiện tại của đơn hàng
        {
            DataTable temp = DataProvider.ExcuseQuery1("Select TRANG_THAI FROM HOADON WHERE SOHD =  " + SOHD);
            foreach (DataRow row in temp.Rows)
            {
                return row["TRANG_THAI"].ToString();
            }
            return null;
        }

        public string CheckStatus(int SoHD)
        {
            return (string)DAO.DataProvider.ExecuteScalar("Select TRANG_THAI from HOADON where SOHD = '" + SoHD + "'");
        }

        public bool DeleteHD(string SoHd)
        {
            int check = DAO.DataProvider.ExecuteNonQuery("update HOADON set TRANG_THAI = N'Hủy' where SOHD = '" + SoHd + "'");
            if (check == 0)
                return false;
            else
                return true;
        }

        public bool ChangeStatus(string tt, string sohd)
        {
            int check = DAO.DataProvider.ExecuteNonQuery("update HOADON set TRANG_THAI = N'"+tt+"' where SOHD = '" + sohd + "'");
            if (check == 0)
                return false;
            else
                return true;
        }

    }
}
