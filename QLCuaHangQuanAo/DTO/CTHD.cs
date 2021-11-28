using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangQuanAo.DTO
{
    class CTHD
    {
        /*
         CREATE TABLE CTHD
        (
        	SOHD INT, 
        	MASP INT,
        	SL INT,
        	PRIMARY KEY(SOHD,MASP)
        )
         */
        private int soHD;
        private int maSP;
        private int sL;

        public CTHD(int soHD, int maSP, int sL)
        {
            this.soHD = soHD;
            this.maSP = maSP;
            this.sL = sL;
        }

        public int SoHD { get => soHD; set => soHD = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int SL { get => sL; set => sL = value; }
    }
}
