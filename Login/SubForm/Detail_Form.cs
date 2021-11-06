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
    public partial class Detail_Form : Form
    {
        int i;
        public Control_User.Item item;
        public Detail_Form(Control_User.Item item)
        {
            InitializeComponent();
            this.item = item;
            i = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UI_Home.i++;
            Partner_performance.reload(UI_Home.i);
            Item_HD item_HD = new Item_HD(item.Ten, item.Loai,Convert.ToInt32(txbSLMua.Text), item.gia, item.picture.Image);

            Item_HD.item_HDs.Add(item_HD);
            MessageBox.Show("Them vao gio hang thanh cong");
            this.Hide();
        }

        private void btnAddSL_Click(object sender, EventArgs e)
        {
            if(i != 0)
                i = Convert.ToInt32(txbSLMua.Text);
            i++;
            txbSLMua.Text = i.ToString();
        }
    }
}
