using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangQuanAo.DTO
{
    public class KHACHHANG
    {
        /*
         CREATE TABLE KHACHHANG
        (
        	MAKH INT PRIMARY KEY identity(1,1),
        	HOTEN VARCHAR(40),
        	DCHI VARCHAR(50),
        	SODT VARCHAR(20),
        	NGSINH SMALLDATETIME
        )
         */
        private int maKH;
        private int idUsername;
        private string hoTen;
        private string diaChi;
        private string soDT;
        private string email;
        private string ngSinh;
        private int gioitinh;
        private byte[] anh;

        public KHACHHANG()
        {
        }

        public KHACHHANG(int maKH, int idUsername, string hoTen, string diaChi, string soDT, string ngSinh, int gioitinh, byte[] anh, string email)
        {
            this.maKH = maKH;
            this.idUsername = idUsername;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDT = soDT;
            this.ngSinh = ngSinh;
            this.gioitinh = gioitinh;
            this.anh = anh;
            this.Email = email;
        }

        public KHACHHANG(DataRow row)
        {
            maKH = (int)row["MAKH"];
            idUsername = (int)row["IDTK"];
            hoTen = row["HOTEN"].ToString();
            diaChi = row["DCHI"].ToString();
            soDT = row["SODT"].ToString();
            ngSinh = ((DateTime)row["NGSINH"]).ToString();
            gioitinh = (int)row["GIOITINH"];
            if (!row.IsNull("ANH"))
                anh = (byte[])row["ANH"];
            else
            {
                anh = null;
            }
            email = row["EMAIL"].ToString();
        }

        public int MaKH { get => maKH; set => maKH = value; }
        public int IdUsername { get => idUsername; set => idUsername = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string NgSinh { get => ngSinh; set => ngSinh = value; }
        public byte[] Anh { get => anh; set => anh = value; }
        public int Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Email { get => email; set => email = value; }
    }
}
