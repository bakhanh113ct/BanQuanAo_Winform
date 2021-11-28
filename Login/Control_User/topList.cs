using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Login.Control_User
{
    public partial class topList : UserControl
    {
        private static int topp = 1;
        public topList()
        {
            InitializeComponent();
        }

        public topList(DataRow row)
        {
            InitializeComponent();
            label1.Text = topp++.ToString();
            hoten.Text = (string)row["HOTEN"];
            int DoanhSo = Convert.ToInt32(row["DOANHSO"]);
            doanhso.Text = DoanhSo.ToString() + "₫";
            byte[] anh = (byte[])row["ANH"];
            anhdd.Image = ConvertoImage(anh);
            if (topp == 3)
            {
                top.FillColor = Color.Orange;
            }
            else if (topp == 4)
                top.FillColor = Color.Blue;
            if(topp == 4)
            {
                topp = 1;
            }
        }
        public topList(DataRow row, string x)
        {
            InitializeComponent();
            label1.Text = topp++.ToString();
            hoten.Text = (string)row["TEN"];
            int DoanhSo = Convert.ToInt32(row["SL"]);
            doanhso.Text = "Bán được " + DoanhSo.ToString() + " SP";
            byte[] anh = (byte[])row["ANH"];
            anhdd.Image = ConvertoImage(anh);
            if (topp == 3)
            {
                top.FillColor = Color.Orange;
            }
            else if (topp == 4)
                top.FillColor = Color.Blue;
            if (topp == 4)
            {
                topp = 1;
            }
        }
        public Image ConvertoImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
