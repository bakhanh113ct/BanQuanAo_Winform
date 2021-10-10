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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.Blue;
        }


    }
}
