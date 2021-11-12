using Login.DAO;
using Login.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.SubForm
{
    public partial class Cart_Form : Form
    {
        public Cart_Form()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cart_Form_Load(object sender, EventArgs e)
        {

            foreach (Item_HD item in Item_HD.item_HDs)
            {
                dtgrvItem.Rows.Add(item.Anh, item.Ten, item.Loai, item.Sl, item.Gia);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (DataGridViewRow row in dtgrvItem.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells[5] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(chk.Value) == true)
                    list.Add(row.Index);
            }
            list.Reverse();
            foreach (int i in list)
            {
                dtgrvItem.Rows.RemoveAt(i);
                Item_HD.item_HDs.RemoveAt(i);
            }
            Store_performence.reloadlb(Store_performence.slhangtronggio);
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            if (Item_HD.item_HDs.Count == 0)
            {
                MessageBox.Show("Chua co hang");
                return;
            }
            //Chưa có mã khách hàng
            double Trigia = 0;
            foreach (Item_HD item in Item_HD.item_HDs)
            {
                Trigia += Convert.ToDouble(item.Gia)*item.Sl;
            }
            if (HoaDonDAO.InsertHD(DateTime.Now.ToString(), "1", Trigia.ToString(), "Waiting"))
            {
                MessageBox.Show("Them thanh cong.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Them khong thanh cong.");
            }

            //Thêm CTHD
            int soHD = HoaDonDAO.getSoHD_MAX();
            foreach (Item_HD item in Item_HD.item_HDs)
            {
                if (item.Sl == 0)                               //chưa test
                    break;
                CTHDDAO.Instance.InsertCTHD((soHD).ToString(), item.MaSP, item.Sl.ToString());
            }
            //clear danh sach item_HD 
            if(Item_HD.item_HDs.Count != 0)
            {
                Item_HD.item_HDs.Clear();
                Store_performence.slhangtronggio = 0;
            }
            
        }
    }
}
