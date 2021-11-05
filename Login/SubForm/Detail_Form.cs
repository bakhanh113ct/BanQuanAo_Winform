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
        public Detail_Form()
        {
            InitializeComponent();
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
