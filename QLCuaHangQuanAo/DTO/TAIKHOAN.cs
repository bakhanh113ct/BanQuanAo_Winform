using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangQuanAo.DTO
{
    public class TAIKHOAN
    {
        private int id;
        private string displayname;
        private string username;
        private string password;
        private int typetk;

        public TAIKHOAN(int id, string displayname, string username, string password, int typetk)
        {
            this.id = id;
            this.displayname = displayname;
            this.username = username;
            this.password = password;
            this.typetk = typetk;
        }
        public TAIKHOAN(DataRow row)
        {
            id = (int)row["ID"];
            displayname = row["TENHIENTHI"].ToString();
            username = row["TENDANGNHAP"].ToString();
            password = row["MATKHAU"].ToString();
            typetk = (int)row["LOAITK"];
        }

        public int Id { get => id; set => id = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Typetk { get => typetk; set => typetk = value; }
    }
}
