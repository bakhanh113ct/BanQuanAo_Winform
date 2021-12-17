using QLCuaHangQuanAo.Performance;
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
    public partial class Customer : UserControl
    {
        private int mAKH;
        private string tenkh = "";
        int slkh = DAO.KhachHangDAO.Instance.SLKH();
        public string Tenkh {get =>tenkh; set =>tenkh = value;}

        public int MAKH { get => mAKH; set => mAKH = value; }

        public Customer()
        {
            InitializeComponent();
        }
        public Customer(DataRow row, int stt)
        {
            InitializeComponent();
            id.Text = stt.ToString();
            mAKH = (int)row["MAKH"];
            name.Text = tenkh = row["HOTEN"].ToString();
            sl.Text = row["Sl"].ToString();
            int giax = (int)row["GIA"];
            gia.Text = String.Format("{0:n0}", giax) + " VND";
        }

        private void thaotac_Click(object sender, EventArgs e)
        {
            change();
            Library.sound_Click();
            //Customer_perfomances.xem.Visible = true;
        }
        void change()
        {
            foreach (Customer item in Customer_perfomances.kh)
            {
                item.nen.FillColor = Color.White;
                item.id.ForeColor = Color.Black;
                item.sl.ForeColor = Color.Black;   
                item.gia.ForeColor = Color.Black;
            }

            nen.FillColor = Color.FromArgb(174, 78, 191);
            id.ForeColor = Color.White;
            sl.ForeColor = Color.White;
            gia.ForeColor =Color.White;
        }
    }
}
