using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangQuanAo.DAO
{
    class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set => instance = value;
        }

        public DTO.TAIKHOAN LoadTK(string username)
        {
            DTO.TAIKHOAN tk;
            DataTable data = DAO.DataProvider.ExecuteQuery("Select * from TAIKHOAN where TENDANGNHAP = '" + username + "'");
            DataRow row = data.Rows[0];
            tk = new DTO.TAIKHOAN(row);
            return tk;
        }
        public bool CheckUsername_Password(string username, string password)
        {
            int kq = (int)DAO.DataProvider.ExecuteScalar("select count(*) from TAIKHOAN where TENDANGNHAP = '" + username + "' and MATKHAU = '" + password + "'");
            if (kq != 0)
            {
                return true;
            }
            return false;
        }


        public bool CheckUserNameExists(string username)
        {
            int check = (int)DAO.DataProvider.ExecuteScalar("select count(TENDANGNHAP) from TAIKHOAN where TENDANGNHAP = '" + username + "' ");
            if (check != 0)
                return true;
            return false;
        }

        public bool InsertAccount(DTO.TAIKHOAN tk)
        {
            int kq = DAO.DataProvider.ExecuteNonQuery("insert into TAIKHOAN(TENHIENTHI, TENDANGNHAP, MATKHAU, LOAITK) values(N'" + tk.Displayname + "','" + tk.Username + "','" + tk.Password + "','" + tk.Typetk + "')");
            if (kq != 0)
                return true;
            return false;
        }

        public int Getid_UserName(string username)
        {
            return (int)DAO.DataProvider.ExecuteScalar("select ID from TAIKHOAN where TENDANGNHAP = '" + username + "'");
        }

        public int GetLoaiTK(string username)
        {
            return (int)DAO.DataProvider.ExecuteScalar("select LOAITK from TAIKHOAN where TENDANGNHAP = '" + username + "'");
        }

        public int GetIdMax()
        {
            object kq = DAO.DataProvider.ExecuteScalar("select max(id) from TAIKHOAN");
            if (kq is System.DBNull)
                return 0;
            return (int)kq;
        }

        public bool ChangePassword(string id, string newpassword)
        {
            int kq = DAO.DataProvider.ExecuteNonQuery("update TAIKHOAN set MATKHAU = '" + newpassword + "' where ID = '" + id + "'");
            if (kq != 0)
                return true;
            return false;
        }

        public bool DeleteAccount()
        {
            int id = GetIdMax();
            if(DAO.DataProvider.ExecuteNonQuery("delete from TAIKHOAN where ID = '" + id + "'") != 0)
                return true;
            return false;

        }
        public string LoadEmail(int SoHd)
        {
            return (string)DAO.DataProvider.ExecuteScalar("Select EMAIL from HOADON, KHACHHANG where HOADON.MAKH = KHACHHANG.MAKH and SOHD = '" + SoHd + "'");
        }
        
        public string LoadEmail_MaKH(string makh)
        {
            return (string)DAO.DataProvider.ExecuteScalar("Select EMAIL from KHACHHANG where MAKH = '" + makh + "'");
        }
    }
}
