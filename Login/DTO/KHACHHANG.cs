using System;
using System.Collections.Generic;
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

        public KHACHHANG(int maKH, string hoTen, string diaChi, string soDT, DateTime ngSinh)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDT = soDT;
            this.ngSinh = ngSinh;
        }

        public int MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public DateTime NgSinh { get => ngSinh; set => ngSinh = value; }
    }
}
