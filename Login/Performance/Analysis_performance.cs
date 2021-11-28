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
    public partial class Analysis_performance : Form
    {
        public Analysis_performance()
        {
            InitializeComponent();
            for(int i =0; i < 3; i++)
            {
                Control_User.topList temp = new Control_User.topList();
                flowLayoutPanel1.Controls.Add(temp);
            }
        }
    }
}
