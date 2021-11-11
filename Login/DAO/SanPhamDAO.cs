using Login.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.DAO
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
            int check = DAO.DataProvider.ExecuteNonQuery("InsertSP @TEN , @GIA , @SL ,  @DABAN ,  @MOTA ,  @IDLOAI , @ANH ", 
                                             new object[] { ten, gia, SL, "0", mota, loai, image });
            if (check == 0)
            {
                MessageBox.Show("Them khong thanh cong.");
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Them thanh cong.");
                if (result == DialogResult.OK)
                {
                    return true;
                }
            }
            return false;
        }

        static public bool UpdateSP(string ten, string gia, string SL, string mota, string loai, byte[] image, string old_Name)
        {
            int check = DAO.DataProvider.ExecuteNonQuery("update SANPHAM set TEN = @Ten , GIA = @Gia , SL = @SoLuong , DANHGIA = @DanhGia , DABAN = @DaBan , MOTA = @MoTa , IDLOAI = @Loai , ANH = @Anh where MASP = '" + old_Name + "'",
                                                            new object[] { ten , gia , SL , "0" , "0" , mota , loai , image });
            if (check == 0)
            {
                MessageBox.Show("Cap nhat khong thanh cong.");
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Cap nhat thanh cong.");
                if (result == DialogResult.OK)
                {
                    return true;
                }
            }
            return false;
        }

        static public bool DeleteSP(string id)
        {
            int check = DAO.DataProvider.ExecuteNonQuery("delete from SANPHAM where MASP = '"+id+"'");
            if (check == 0)
            {
                MessageBox.Show("Xoa khong thanh cong.");
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Xoa thanh cong.");
                if (result == DialogResult.OK)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
