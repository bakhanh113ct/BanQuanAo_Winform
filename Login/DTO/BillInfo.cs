using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DTO
{
    public class BillInfo
    {
        private int sL;
        private string tenSP;
        private int gia;
        private int maSP;

        public BillInfo(DataRow row)
        {   

            this.sL = (int)row["SL"];
            this.tenSP = row["TEN"].ToString();
            this.gia = (int)row["GIA"] * this.sL;
            this.MaSP = (int)row["MASP"];
        }

        public int SL { get => sL; set => sL = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int Gia { get => gia; set => gia = value; }
        public int MaSP { get => maSP; set => maSP = value; }
    }
}
