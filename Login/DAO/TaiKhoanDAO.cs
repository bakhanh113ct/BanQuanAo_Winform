using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DAO
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
            DataTable data = DAO.DataProvider.ExecuteQuery("Select * from TAIKHOAN where USERNAME = '" + username + "'");
            DataRow row = data.Rows[0];
            tk = new DTO.TAIKHOAN(row);
            return tk;
        }
        public bool CheckUsername_Password(string username, string password)
        {
            int kq = (int)DAO.DataProvider.ExecuteScalar("select count(*) from TAIKHOAN where USERNAME = '" + username + "' and PASSWORD = '" + password + "'");
            if (kq != 0)
            {
                return true;
            }
            return false;
        }


        public bool CheckUserNameExists(string username)
        {
            int check = (int)DAO.DataProvider.ExecuteScalar("select count(USERNAME) from TAIKHOAN where USERNAME = '" + username + "' ");
            if (check != 0)
                return true;
            return false;
        }

        public bool InsertAccount(DTO.TAIKHOAN tk)
        {
            int kq = DAO.DataProvider.ExecuteNonQuery("insert into TAIKHOAN(DISPLAYNAME, USERNAME, PASSWORD, TYPETK) values('" + tk.Displayname + "','" + tk.Username + "','" + tk.Password + "','" + tk.Typetk + "')");
            if (kq != 0)
                return true;
            return false;
        }

        public int Getid_UserName(string username)
        {
            return (int)DAO.DataProvider.ExecuteScalar("select ID from TAIKHOAN where USERNAME = '" + username + "'");
        }

        public int GetLoaiTK(string username)
        {
            return (int)DAO.DataProvider.ExecuteScalar("select TYPETK from TAIKHOAN where USERNAME = '" + username + "'");
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
            int kq = DAO.DataProvider.ExecuteNonQuery("update TAIKHOAN set PASSWORD = '" + newpassword + "' where ID = '" + id + "'");
            if (kq != 0)
                return true;
            return false;
        }
    }
}
