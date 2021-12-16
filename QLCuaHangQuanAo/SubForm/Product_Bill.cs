using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo.SubForm
{
    public partial class Product_Bill : Form
    {
        string SoHD;
        public Product_Bill(string SoHD)
        {
            InitializeComponent();
            this.SoHD = SoHD;
        }

        private void Product_Bill_Load(object sender, EventArgs e)
        {
            DataTable table = DAO.CTHDDAO.Instance.LoadCTHD(SoHD);
            dtgrvItem.DataSource = table;
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            

            if (DAO.HoaDonDAO.Instance.CheckStatus(int.Parse(SoHD)) == "Chờ")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy đơn hàng không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    if (DAO.HoaDonDAO.Instance.DeleteHD(SoHD))
                        MessageBox.Show("Đơn hàng của bạn đã được hủy thành công.");
                    else MessageBox.Show("Hủy đơn hàng thất bại liên hệ cửa hàng thông qua email ở phần liên hệ để biết thêm chi tiết.");
                }

            }
            else if (DAO.HoaDonDAO.Instance.CheckStatus(int.Parse(SoHD)) == "Vận chuyển")
                MessageBox.Show("Đơn hàng đang được vận chuyển, nếu muốn hủy đơn vui lòng liên hệ với cửa hàng qua email ở phần liên hệ.");
            else
                MessageBox.Show("Đơn hàng của bạn đã bị hủy, vui lòng kiểm tra email để biết lý do, rất tiết vì sự bất tiện này.");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
