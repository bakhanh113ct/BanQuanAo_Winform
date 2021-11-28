using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo
{
    public partial class Home_perfomancecs : Form
    {
        public Home_perfomancecs()
        {
            InitializeComponent();
            loadAll();
            
        }
        private void loadAll()
        {
            Loadtoplist();
            loadPieChart();
            LoadBarChar();
            LoadTime();
            loadSLHD();
        }

        private void LoadTime()
        {
            ngaythang.Text = DateTime.Now.ToLongDateString();
            thoigian.Text = DateTime.Now.ToLongTimeString();
        }

        private void LoadBarChar()
        {
            DataTable loadBarChar = DAO.HoaDonDAO.Instance.loadDoanhSo();
            doanhso.DataSource = loadBarChar;
            doanhso.Series["doanhso"].XValueMember = "THANG";
            doanhso.Series["doanhso"].YValueMembers = "GIA";
        }

        private void loadPieChart()
        {
            DataTable loadPieChart = DAO.SanPhamDAO.Instance.loadSL();
            hangtrongkho.DataSource = loadPieChart;
            hangtrongkho.Series["sohang"].XValueMember = "TENLOAI";
            hangtrongkho.Series["sohang"].YValueMembers = "SL";
        }
        private void Loadtoplist()
        {
            SLKH.Text = "Total: " + DAO.KhachHangDAO.Instance.SLKH().ToString() + " Khách hàng";
            DataTable loadtopKH = DAO.KhachHangDAO.Instance.loadtopKH();
            foreach(DataRow row in loadtopKH.Rows)
            {
                Control_User.topList temp = new Control_User.topList(row);
                top_list.Controls.Add(temp);
            }
            SLSP.Text = "Total: " + DAO.SanPhamDAO.Instance.SLSP().ToString() + " Sản phẩm";
            DataTable loadtopSP = DAO.SanPhamDAO.Instance.loadtopSP();
            foreach (DataRow row in loadtopSP.Rows)
            {
                Control_User.topList temp = new Control_User.topList(row, "Knull");
                top_listSP.Controls.Add(temp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            thoigian.Text = DateTime.Now.ToLongTimeString();
        }
        private void loadSLHD()
        {
            SLHD_delevery.Text = DAO.HoaDonDAO.Instance.SLHD_CRmonth().ToString();
            if(DAO.HoaDonDAO.Instance.cmpHD() > 0)
            {
                Muiten.Text = "🠉";
                Muiten.ForeColor = Color.FromArgb(0, 192, 0);
            }
            else
            {
                Muiten.Text = "🠋";
                Muiten.ForeColor = Color.Red;
            }
            cmp.Text = DAO.HoaDonDAO.Instance.cmpHD().ToString() + "%";
            Items.Text = "Items: " + DAO.SanPhamDAO.Instance.countSPsold().ToString();
            Delivered.Text = "Delivered: " + DAO.HoaDonDAO.Instance.SLHD_HOANTHANH().ToString();


        }
    }
}
