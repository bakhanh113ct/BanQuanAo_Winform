﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DTO
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
        private float gia;
        private float danhGia;
        private int daBan;
        private int sL;
        private string moTa;
        private int iDLoai;
        private byte[] anh;

        public SANPHAM(int masp, string ten, float gia, float danhGia, int daBan, string moTa, int iDLoai, byte[] anh)
        {
            this.masp = masp;
            this.tenSP = ten;
            this.gia = gia;
            this.danhGia = danhGia;
            this.daBan = daBan;
            this.moTa = moTa;
            this.iDLoai = iDLoai;
            this.Anh = anh;
        }

        public SANPHAM(DataRow row)
        {
            masp = (int)row["MASP"];
            tenSP = row["TEN"].ToString();
            gia = (float)row["GIA"];
            danhGia = (float)row["DANHGIA"];
            daBan = (int)row["DABAN"];
            sL = (int)row["SL"];
            moTa = row["DABAN"].ToString();
            iDLoai = (int)row["IDLOAI"];
            anh = (byte[])row["ANH"];
        }
        

        public int Masp { get => masp; set => masp = value; }
        public string Ten { get => tenSP; set => tenSP = value; }
        public float Gia { get => gia; set => gia = value; }
        public float DanhGia { get => danhGia; set => danhGia = value; }
        public int DaBan { get => daBan; set => daBan = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public int IDLoai { get => iDLoai; set => iDLoai = value; }
        public byte[] Anh { get => anh; set => anh = value; }
        public int SL { get => sL; set => sL = value; }
    }
}