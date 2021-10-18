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
    public partial class Store_performence : Form
    {
        public Store_performence()
        {
            InitializeComponent();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Control_User.Item item = new Control_User.Item();
            flpnStore.Controls.Add(item);
        }
    }
}
