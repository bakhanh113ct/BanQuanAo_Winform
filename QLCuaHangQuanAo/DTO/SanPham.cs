using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangQuanAo.DTO
{
    public class SANPHAM
    {
        //	CREATE TABLE SANPHAM
        //  (
        //	MASP INT PRIMARY KEY IDENTITY(1,1),
        //	TEN nvarchar(50),
        //	GIA real,
        //	SL int,
        //	DANHGIA real,
        //	DABAN int,
        //	MOTA nvarchar(100),
        //	IDLOAI int,
        //	ANH image
        //)    
        private int masp;
        private string tenSP;
        private int gia;
        private int gianhap;
        private float danhGia;
        private int daBan;
        private int sL;
        private string moTa;
        private int iDLoai;
        private byte[] anh;

        public SANPHAM(int masp, string ten, int gia, float danhGia, int daBan, string moTa, int iDLoai, byte[] anh, int gianhap)
        {
            this.masp = masp;
            this.tenSP = ten;
            this.gia = gia;
            this.danhGia = danhGia;
            this.daBan = daBan;
            this.moTa = moTa;
            this.iDLoai = iDLoai;
            this.Anh = anh;
            this.gianhap = gianhap;
        }

        public SANPHAM(DataRow row)
        {
            masp = (int)row["MASP"];
            tenSP = row["TEN"].ToString();
            gia = (int)row["GIA"];
            danhGia = (float)row["DANHGIA"];
            daBan = (int)row["DABAN"];
            sL = (int)row["SL"];
            moTa = row["MOTA"].ToString();
            iDLoai = (int)row["IDLOAI"];
            if (!row.IsNull("ANH"))
                anh = (byte[])row["ANH"];
            else
            {
                anh = null;
            }
            gianhap = (int)row["GIANHAP"];
        }
        
        
        public int Masp { get => masp; set => masp = value; }
        public string Ten { get => tenSP; set => tenSP = value; }
        public int Gia { get => gia; set => gia = value; }
        public float DanhGia { get => danhGia; set => danhGia = value; }
        public int DaBan { get => daBan; set => daBan = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public int IDLoai { get => iDLoai; set => iDLoai = value; }
        public byte[] Anh { get => anh; set => anh = value; }
        public int SL { get => sL; set => sL = value; }
        public int Gianhap { get => gianhap; set => gianhap = value; }

        public int get_SLSP(int x)
        {
            if (x == Masp)
                return sL;
            return -1;
        }
    }
}
