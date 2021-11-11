﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DTO
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
        private double triGia;

        public HOADON(int soHD, DateTime ngHD, int maKH, double triGia)
        {
            this.soHD = soHD;
            this.ngHD = ngHD;
            this.maKH = maKH;
            this.triGia = triGia;
        }

        public HOADON(DataRow row)
        {
            soHD = (int)row["SOHD"];
            ngHD = (DateTime)row["NGHD"];
            maKH = (int)row["GIA"];
            triGia = (double)row["TRIGIA"];
        }

        public int SoHD { get => soHD; set => soHD = value; }
        public DateTime NgHD { get => ngHD; set => ngHD = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public double TriGia { get => triGia; set => triGia = value; }
    }
}
