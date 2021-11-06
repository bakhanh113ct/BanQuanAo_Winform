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
                
                dtgrvItem.Rows.Add(item.Anh, item.Ten,item.Loai,item.Sl,item.Gia,"");

            }
        }
    }
}
