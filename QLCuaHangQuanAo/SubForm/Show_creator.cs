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
    public partial class Show_creator : Form
    {
        public Show_creator()
        {
            InitializeComponent();
            
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100010585110164");
            this.Close();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Library.sound_Click();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
            Library.sound_Click();

        }
    }
}
