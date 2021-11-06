﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Login.SubForm
{
    public partial class Edit_Form : Form
    {
        public bool check_save_click;
        public bool check_delete_click;
        string old_Name;
        public Edit_Form()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] imgbyte = ConvertoByte(picture.Image);
            if (imgbyte != null)
                if(DBA.Update(txbTen.Text, txbGiaTien.Text, txbSoLuong.Text, txbMota.Text, txbLoai.Text, imgbyte, old_Name))
                {
                    check_save_click = true;
                    this.Hide();
                }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DBA.Delete(txbTen.Text))
            { 
                check_delete_click = true;
                this.Hide();
            }
        }
        byte[] ConvertoByte(Image img)
        {
            if (img != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Chua them anh");
            }
            return null;

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picture.Image = Image.FromFile(ofd.FileName);
            }
            picture.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void Edit_Form_Load(object sender, EventArgs e)
        {
            old_Name = txbTen.Text;
            check_save_click = false;
            check_delete_click = false;
        }
    }
}
