using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo
{
    public partial class Invoice_performance : Form
    {
        public static List<Control_User.list_order> dcm = new List<Control_User.list_order>();
        int index;//Đánh dấu đối tượng đang trỏ vào(SỐ hóa đơn)
        int dem = 0;
        public Invoice_performance()
        {
            InitializeComponent();
            addthanglencombobox();
        }
        void load(string thang)//lấy thông tất cả hóa đơn
        {
            dcm = DAO.HoaDonDAO.Instance.load(thang);
            foreach (Control_User.list_order x in dcm)
            {
                list_KH.Controls.Add(x);
                x.thao_tac.Click += show_chi_tiet;//them sự kiện click cho Control_user 
            }
            hide();

        }
        void addthanglencombobox()
        {
            int month = 1;
            thang.Items.Add("All");
            while (month <= DateTime.Now.Month)
            {
                thang.Items.Add("Tháng " + month++.ToString());
            }
            thang.SelectedIndex = DateTime.Now.Month;
            dem = 1;
        }
        private void hide()//Ẩn những thứ không cần thiết 
        {
            loadBill.Visible = false;
            View.Visible = false;
            time.Visible = false;
            label2.Visible = false;
            btnSendEmail.Visible = false;
        }
        private void unhide()//Ẩn những thứ không cần thiết 
        {
            loadBill.Visible = true;
            View.Visible = true;
            time.Visible = true;
            label2.Visible = true;
            btnSendEmail.Visible = true;
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
                case "Chờ":
                    NGHD.Text = nghd.ToString();
                    label3.Text = "Chờ xác nhận";
                    timeXN.Text = "";
                    label4.Text = "Thời gian chờ hiệu lực đến ngày: ";
                    hanHD.Text = nghd.AddDays(7).ToString();
                    hanHD.ForeColor = Color.Red;
                    break;
                case "Vận chuyển":
                    NGHD.Text = nghd.ToString();
                    label3.Text = "Thời gian xác nhận đơn hàng:";
                    timeXN.Text = xn.ToString();
                    timeXN.ForeColor = Color.FromArgb(0, 192, 0);
                    label4.Text = "Thời gian dự kiến hoàn thành đơn hàng:";
                    hanHD.Text = xn.AddDays(2).ToString();
                    hanHD.ForeColor = Color.Goldenrod;
                    break;
                case "Hủy":
                    NGHD.Text = nghd.ToString();
                    label3.Text = "Thời gian hủy đơn hàng";
                    timeXN.Text = xn.ToString();
                    timeXN.ForeColor = Color.Red;
                    label4.Text = "";
                    hanHD.Text = "";
                    break;
                case "Hoàn thành":
                    NGHD.Text = nghd.ToString();
                    label3.Text = "Thời gian vận chuyển đơn hàng";
                    timeXN.Text = xn.ToString();
                    timeXN.ForeColor = Color.FromArgb(0, 192, 0);
                    label4.Text = "Thời gian hoàn thành đơn hàng";
                    hanHD.Text = xn.AddDays(2).ToString();
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
                loadBill.Rows.Add(temp.TenSP, temp.SL, temp.Gia.ToString(), temp.Trigia);
            }
        }

        private void View_Click(object sender, EventArgs e)//Click vào để xem chi tiết hóa đơn
        {
            SubForm.BILL temp = new SubForm.BILL(index);//Tạo một cái bill mới
            Library.sound_Click();
            temp.ShowDialog(this);//cái này để tránh thao tác trên chương trình chính
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
        private void thang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            list_KH.Controls.Clear();
            if (thang.SelectedIndex == 0)
            {
                load("");
                Library.load_click();
            }
            else
            {
                load("and MONTH(NGHD) = " + (int)thang.SelectedIndex);
                if (dem != 0)
                {
                    if (list_KH.Controls.Count > 0)
                        Library.load_click();
                    else
                    {
                        Label tb = new Label();
                        tb.AutoSize = true;
                        tb.Font = new System.Drawing.Font("Quicksand SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        tb.ForeColor = System.Drawing.Color.Red;
                        tb.Location = new System.Drawing.Point(0, 0);
                        tb.Name = "label1";
                        tb.Size = new System.Drawing.Size(179, 57);
                        tb.TabIndex = 2;
                        tb.Text = "Không có dữ liệu";
                        //Font = new System.Drawing.Font("Quicksand SemiBold", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        list_KH.Controls.Add(tb);
                        Library.Noload_click();
                        //MessageBox.Show("Khong co du lieu");
                    }
                }
            }

        }

        private void thang_Click(object sender, EventArgs e)
        {
            Library.sound_Click();
        }

        private void tim_theo_ten_TextChanged(object sender, EventArgs e)
        {
            int k = 0;
            foreach (Control_User.list_order i in dcm)
            {
                //ie i = (item.btnItem.Tag as SANPHAM);
                if (i.TenKH.Contains(tim_theo_ten.Text))
                {
                    k++;
                    if (k == 1)
                        list_KH.Controls.Clear();
                    list_KH.Controls.Add(i);
                }
            }
        }

        private void tim_theo_ten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                int k = 0;
                foreach (Control_User.list_order item in dcm)
                {
                    //SANPHAM i = (item.btnItem.Tag as SANPHAM);
                    if (item.TenKH.Contains(tim_theo_ten.Text))
                    {
                        k++;
                        if (k == 1)
                            list_KH.Controls.Clear();
                        list_KH.Controls.Add(item);
                    }
                }
                if (k == 0)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            SubForm.SendEmail send = new SubForm.SendEmail(index);
            send.Show();
        }
    }
}
