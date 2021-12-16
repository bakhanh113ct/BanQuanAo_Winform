using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo.Control_User
{
    public partial class HDcuaKH : UserControl
    {
        static int STT = 0;
        
        public HDcuaKH()
        {
            InitializeComponent();
        }
        public HDcuaKH(DataRow row, int stt)
        {   
            InitializeComponent();
            ST.Text = stt.ToString();
            SOHD.Text = row["SOHD"].ToString();
            DateTime x = (DateTime)row["NGHD"];
            NGHD.Text = x.ToShortDateString();
            TRANG_THAI.Text = row["TRANG_THAI"].ToString();
            int giax = (int)row["TRIGIA"];
            GIA.Text = String.Format("{0:n0}", giax) + " VND";
        }
    }
}
