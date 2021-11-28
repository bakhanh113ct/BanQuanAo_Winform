using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangQuanAo.DTO
{
    public class HOADON
    {
        /*
         CREATE TABLE HOADON
        (
        	SOHD INT PRIMARY KEY IDENTITY(1,1),
        	NGHD SMALLDATETIME,
        	MAKH INT,
        	TRIGIA MONEY
        )
         */
        private int soHD;
        private DateTime ngHD;
        private int maKH;
        private decimal triGia;
        private string trangthai;

        public HOADON(int soHD, DateTime ngHD, int maKH, decimal triGia, string trangthai)
        {
            this.soHD = soHD;
            this.ngHD = ngHD;
            this.MaKH = maKH;
            this.triGia = triGia;
            this.Trangthai = trangthai;
        }

        public HOADON(DataRow row)
        {
            soHD = (int)row["SOHD"];
            ngHD = (DateTime)row["NGHD"];
            MaKH = (int)row["MAKH"];
            triGia = (decimal)row["TRIGIA"];
            trangthai = row["TRANG_THAI"].ToString();
        }

        public int SoHD { get => soHD; set => soHD = value; }
        public DateTime NgHD { get => ngHD; set => ngHD = value; }
        public decimal TriGia { get => triGia; set => triGia = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int MaKH { get => maKH; set => maKH = value; }
    }
}
