using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Customer_performance : Form
    {
        public static List<Control_User.list_order> dcm = new List<Control_User.list_order>();
        int index;//Đánh dấu đối tượng đang trỏ vào(SỐ hóa đơn)
        public Customer_performance()
        {
            InitializeComponent();
            load();
        }
        void load()//lấy thông tất cả hóa đơn
        {
            dcm = DAO.HoaDonDAO.Instance.load();
            foreach (Control_User.list_order x in dcm)
            {
                list_KH.Controls.Add(x);
                x.thao_tac.Click += show_chi_tiet;//them sự kiện click cho Control_user 
            }
            hide();
        }
        private void hide()//Ẩn những thứ không cần thiết 
        {
            loadBill.Visible = false;
            View.Visible = false;
            time.Visible = false;
            label2.Visible = false;
        }
        private void unhide()//Ẩn những thứ không cần thiết 
        {
            loadBill.Visible = true;
            View.Visible =     true;
            time.Visible =     true;
            label2.Visible =   true;
        }

        private void show_chi_tiet(object sender, EventArgs e)//Tìm kiếm đối tượng đang được trỏ đến
        {

            unhide();
            foreach (Control_User.list_order x in dcm)//TÌm kiếm đối tượng đang được trỏ đến
            {
                if (x.BackGround.FillColor == Color.FromArgb(174, 78, 191))//tìm được rồi nè
                {
                    index = x.SoHD;//Đánh dấu đối tượng đang được trỏ đến
                    showBill(x.SoHD);
                    getHSD(index);
                    //timeXN.Text = DAO.HoaDonDAO.Instance.getTimeXN(index);
                    return;//tìm thấy rồi thì không tim nữa load mất công
                }
            }
            
        }

        private void getHSD(int index)
        {
            time.Visible = true;
            string status = DAO.HoaDonDAO.Instance.gettt(index);
            DateTime xn = DAO.HoaDonDAO.Instance.getTimeXN(index);
            DateTime nghd = DAO.HoaDonDAO.Instance.getNGHD(index);
            switch (status)
            {
                case "Waiting":
                    NGHD.Text = nghd.ToString();
                    label3.Text = "Chờ xác nhận";
                    timeXN.Text = "";
                    label4.Text = "Thời gian chờ hiệu lực đến ngày: ";
                    hanHD.Text = nghd.AddDays(7).ToString();
                    hanHD.ForeColor = Color.Red;
                    break;
                case "Delivery":
                    NGHD.Text = nghd.ToString();
                    label3.Text = "Thời gian xác nhận đơn hàng:";
                    timeXN.Text = xn.ToString();
                    timeXN.ForeColor = Color.FromArgb(0, 192, 0);
                    label4.Text = "Thời gian dự kiến hoàn thành đơn hàng:";
                    hanHD.Text = xn.AddDays(2).ToString();
                    hanHD.ForeColor = Color.Goldenrod;
                    break;
                case "Cancel":
                    NGHD.Text = nghd.ToString();
                    label3.Text = "Thời gian hủy đơn hàng";
                    timeXN.Text = xn.ToString();
                    timeXN.ForeColor = Color.Red;
                    label4.Text = "";
                    hanHD.Text = "";
                    break;
                case "Complete":
                    NGHD.Text = nghd.ToString();
                    label3.Text = "Thời gian hoàn thành đơn hàng";
                    timeXN.Text = xn.AddDays(2).ToString();
                    timeXN.ForeColor = Color.Goldenrod;
                    label4.Text = "";
                    hanHD.Text = "";
                    break;
            }
        }

        private void showBill(int soHD)//load chi tiet san pham len Data grid view
        {
            DataTable Bill = DAO.HoaDonDAO.Instance.loadBill(soHD);
            loadBill.Rows.Clear();//Xóa để load lên lại kẻo trùng

            foreach (DataRow x in Bill.Rows)//Thêm vào từng hàng cho Data grid view
            {
                DTO.BillInfo temp = new DTO.BillInfo(x);
                loadBill.Rows.Add(temp.MaSP, temp.TenSP, temp.SL, temp.Gia.ToString());
            }
        }

        private void View_Click(object sender, EventArgs e)//Click vào để xem chi tiết hóa đơn
        {
            SubForm.BILL temp = new SubForm.BILL(index);//Tạo một cái bill mới
            DAO.Sound.Instance.sound_Click();
            temp.ShowDialog(this);//cái này để tránh thao tác trên chương trình chính
            //temp.Hide();
            foreach (Control_User.list_order x in dcm)//kiếm đối tượng đang trỏ vào
            {
                if (x.BackGround.FillColor == Color.FromArgb(174, 78, 191))
                {
                    x.set_tt(x.getStatus());//Đổi màu nếu trạng thái thay đổi
                    getHSD(index);
                    return;//Khỏi tìm
                }
            }
        }

       
    }
}
