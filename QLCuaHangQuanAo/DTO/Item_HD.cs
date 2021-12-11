using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangQuanAo
{
    public class Item_HD
    {
        public static List<Item_HD> item_HDs = new List<Item_HD>();
        private string masp;
        private string ten;
        private int idloai;
        private int sl;
        private double gia;
        private Image anh;

        public Item_HD(string masp, string ten, int idloai, int sl, double gia, Image anh)
        {
            this.masp = masp;
            this.ten = ten;
            this.idloai = idloai;
            this.sl = sl;
            this.gia = gia;
            this.anh = anh;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Idloai { get => idloai; set => idloai = value; }
        public int Sl { get => sl; set => sl = value; }
        public double Gia { get => gia; set => gia = value; }
        public Image Anh { get => anh; set => anh = value; }
        public string MaSP { get => masp; set => masp = value; }
    }

}
