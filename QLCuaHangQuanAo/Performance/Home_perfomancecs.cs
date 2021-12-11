using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QLCuaHangQuanAo.Performance
{
    public partial class Home_perfomancecs : Form
    {
        UI_Home home;
        Store_performence store;
        public Home_perfomancecs(UI_Home home, Store_performence store)
        {
            this.home = home;
            this.store = store;
            InitializeComponent();
            listpanel.Add(panelGiay);
            listpanel.Add(panelAo);
            listpanel.Add(panelQuan);
            listpanel.Add(panelMu);
            listbutton.Add(btnGiay);
            listbutton.Add(btnAo);
            listbutton.Add(btnQuan);
            listbutton.Add(btnMu);
            foreach (Guna.UI2.WinForms.Guna2GradientPanel i in listpanel)
            {
                i.Visible = false;
            }
            panelGiay.Visible = true;
            foreach (Guna.UI2.WinForms.Guna2Button i in listbutton)
            {
                i.Visible = false;
            }
            panelGiay.Visible = true;
            btnGiay.Visible = true;
        }
        List<Guna.UI2.WinForms.Guna2Button> listbutton = new List<Guna.UI2.WinForms.Guna2Button>();
        List<Guna.UI2.WinForms.Guna2GradientPanel> listpanel = new List<Guna.UI2.WinForms.Guna2GradientPanel>();
        int i = 0;
        private void ChangePage()
        {
            int k = i;
            if (i == 3)
                i = -1;
            i++;
            listpanel[i].BringToFront();
            listbutton[i].BringToFront();
            guna2Transition1.ShowSync(listpanel[i]);
            listbutton[i].Visible = true;
            listpanel[k].Visible = false;
            listbutton[k].Visible = false;
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangePage();
        }


        private void btnBuy_Click(object sender, EventArgs e)
        {
            home.StoreOpenPerformance(store);
        }
        //public void Saveimage()
        //{
        //    //HttpContext.Current.Server.MapPath(path);
        //    var filePath = HttpContext.Current.Server.MapPath("D:\\HK3\\icons8-logout-64.png");
        //    if (File.Exists(filePath))
        //    {
        //        File.Delete(filePath);
        //    }
        //    //myImage.Save(path, ImageFormat.Jpeg);
        //    //img
        //}

        //private void guna2Button1_Click(object sender, EventArgs e)
        //{
        //    Saveimage();
        //}
    }
}
