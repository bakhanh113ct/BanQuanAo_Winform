using Login.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.DAO
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

        static public bool InsertHD(string nghd, string makh, string trigia, string tt)
        {
            int check = DAO.DataProvider.ExecuteNonQuery("insert into HOADON(NGHD,MAKH,TRIGIA,TRANG_THAI) values ( @NGHD , @MAKH , @TRIGIA , @TRANG_THAI )", new object[] { nghd, makh, trigia, tt });
            if (check == 0)
                return false;
            else
                return true;
            return true;
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
    }
}
