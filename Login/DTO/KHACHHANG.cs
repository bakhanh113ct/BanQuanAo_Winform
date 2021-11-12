using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DTO
{
    class KHACHHANG
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
        private string hoTen;
        private string diaChi;
        private string soDT;
        private DateTime ngSinh;
        private byte[] anh;

        public KHACHHANG(DataRow row)
        {
            this.maKH = (int)row["MAKH"];
            this.hoTen = row["HOTEN"].ToString();
            this.diaChi = row["DIACHI"].ToString();
            this.soDT = row["SODT"].ToString();
            this.ngSinh = (DateTime)row["NGSINH"];
            
        }

        public int MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public DateTime NgSinh { get => ngSinh; set => ngSinh = value; }
        private byte[] Anh { get => anh; set => anh = value;}
    }
}
