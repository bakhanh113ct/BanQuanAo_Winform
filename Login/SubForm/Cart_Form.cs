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
                dtgrvItem.Rows.Add(item.Anh, item.Ten,item.Loai,item.Sl,item.Gia);
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
            foreach(int i in list)
            {
                dtgrvItem.Rows.RemoveAt(i);
                Item_HD.item_HDs.RemoveAt(i);
            }
            Partner_performance.reload(UI_Home.i);
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgrvItem.Rows)
            {
                
            }
        }
    }
}
