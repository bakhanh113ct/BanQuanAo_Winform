using QLCuaHangQuanAo.DAO;
using QLCuaHangQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo.SubForm
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
        private string SetLoai(int idloai)
        {
            switch (idloai)
            {
                case 1:
                    return "Quần";
                    break;
                case 2:
                    return "Áo";
                    break;
                case 3:
                    return "Mũ";
                    break;
                case 4:
                    return "Giày";
                    break;
            }
            return "không xác định";
        }
        private void Cart_Form_Load(object sender, EventArgs e)
        {
            double Tongtien = 0;
            foreach (Item_HD item in Item_HD.item_HDs)
            {
                dtgrvItem.Rows.Add(item.Anh, item.Ten, SetLoai(item.Idloai), item.Sl, item.Gia);
                Tongtien += item.Sl * item.Gia;
            }
            txbTongTien.Text = Tongtien.ToString();
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
            Store_performence.reloadlb();
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            if (Item_HD.item_HDs.Count == 0)
            {
                MessageBox.Show("Chưa có hàng.");
                return;
            }
            double Trigia = 0;
            foreach (Item_HD item in Item_HD.item_HDs)
            {
                Trigia += Convert.ToDouble(item.Gia)*item.Sl;
            }
            if (HoaDonDAO.InsertHD(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"), Login.kh.MaKH.ToString(), Trigia.ToString(), "N'Chờ'"))
            {
                MessageBox.Show("Thêm thành công.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.");
            }

            //Thêm CTHD
            int soHD = HoaDonDAO.getSoHD_MAX();
            foreach (Item_HD item in Item_HD.item_HDs)
            {
                if (item.Sl == 0)                               //chưa test
                    break;
                CTHDDAO.Instance.InsertCTHD((soHD).ToString(), item.MaSP, item.Gia.ToString() ,item.Sl.ToString());
                //Giảm SL
                SanPhamDAO.Instance.ReduceSL(item.Sl.ToString(), item.MaSP);
                //Tăng đã bán 
                SanPhamDAO.Instance.IncreaseDaban(item.Sl.ToString(), item.MaSP);
            }
            //clear danh sach item_HD 
            if(Item_HD.item_HDs.Count != 0)
            {
                Item_HD.item_HDs.Clear();
            }
            //Load lại label số lượng hàng trong giỏ
            Store_performence.reloadlb();
            
        }
        private void dtgrvItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgrvItem.CurrentRow.Index;
            index = dtgrvItem.SelectedRows[0].Index;
            DataGridViewRow row = dtgrvItem.Rows[index];
            Item_HD.item_HDs[index].Sl = Convert.ToInt32(row.Cells[3].Value);
            foreach (Item_HD item in Item_HD.item_HDs)
            {
                txbTongTien.Text = (item.Sl * item.Gia).ToString();
            }
            
        }
    }
}
