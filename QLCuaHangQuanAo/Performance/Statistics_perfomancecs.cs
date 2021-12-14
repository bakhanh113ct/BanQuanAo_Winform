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
    public partial class Statistics_perfomancecs : Form
    {
        public Statistics_perfomancecs()
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
            addthanglencombobox();
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
        void loadSPbanDc(string month)
        {

            DataTable loadPieChart1 = DAO.SanPhamDAO.Instance.loadSLBanDc(month);
            sohang.Series["sohang"].Points.Clear();
            sohang.Titles.Clear();
            sohang.DataSource = loadPieChart1;
            sohang.Series["sohang"].XValueMember = "TENLOAI";
            sohang.Series["sohang"].YValueMembers = "SL";
        }
        private void Loadtoplist()
        {
            SLKH.Text = "Tổng: " + DAO.KhachHangDAO.Instance.SLKH().ToString() + " Khách hàng";
            DataTable loadtopKH = DAO.KhachHangDAO.Instance.loadtopKH();
            foreach(DataRow row in loadtopKH.Rows)
            {
                Control_User.topList temp = new Control_User.topList(row);
                top_list.Controls.Add(temp);
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
            Items.Text = "Số hàng: " + DAO.SanPhamDAO.Instance.countSPsold().ToString();
            Delivered.Text = "Đã vận chuyển: " + DAO.HoaDonDAO.Instance.SLHD_HOANTHANH().ToString();
            Sl_HD_huy.Text = DAO.HoaDonDAO.Instance.SLHD_huy().ToString();


        }
        int dem = 0;
        private void guna2Button1_Click(object sender, EventArgs e)
        {   
            if (dem == 0)
            {
                top_list.Controls.Clear();
                SLKH.Text = "Tổng: " + DAO.SanPhamDAO.Instance.SLSP().ToString() + " Sản phẩm";
                DataTable loadtopSP = DAO.SanPhamDAO.Instance.loadtopSP();
                foreach (DataRow row in loadtopSP.Rows)
                {
                    Control_User.topList temp = new Control_User.topList(row, "Knull");
                    top_list.Controls.Add(temp);
                }
                dem = 1;
            }else
            {
                top_list.Controls.Clear();
                Loadtoplist();
                dem = 0;
            }
        }
        void addthanglencombobox()
        {
            int month = 1;
            thang.Items.Add("Năm " + DateTime.Now.Year);
            while (month <= DateTime.Now.Month)
            {
                thang.Items.Add("Tháng " + month++.ToString());
            }
            thang.SelectedIndex = DateTime.Now.Month;
            //dem = 1;
        }

        private void thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (thang.SelectedIndex == 0)
            {
                loadSPbanDc("");
                Text = "Số hàng bán được trong năm 2021";
                sohang.Titles.Add(Text);
            }
            else
            {
                loadSPbanDc("and month(NGHD) = " + thang.SelectedIndex);
                Text = "Số hàng bán được trong tháng " + thang.SelectedIndex;
                sohang.Titles.Add(Text);
            }
        }
    }
}
