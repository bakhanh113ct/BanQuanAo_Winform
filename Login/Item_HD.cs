using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Item_HD
    {
        public static List<Item_HD> item_HDs = new List<Item_HD>();
        private string ten;
        private string loai;
        private int sl;
        private double gia;
        private Image anh;

        public Item_HD(string ten, string loai, int sl, double gia, Image anh)
        {
            this.ten = ten;
            this.loai = loai;
            this.sl = sl;
            this.gia = gia;
            this.anh = anh;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Loai { get => loai; set => loai = value; }
        public int Sl { get => sl; set => sl = value; }
        public double Gia { get => gia; set => gia = value; }
        public Image Anh { get => anh; set => anh = value; }
    }

}
