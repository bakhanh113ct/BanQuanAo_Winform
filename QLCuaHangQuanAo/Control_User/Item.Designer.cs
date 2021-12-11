
using System.Drawing;
using System.Windows.Forms;

namespace QLCuaHangQuanAo.Control_User
{
    public class CustomLabel : Label
    {
        public CustomLabel()
        {
            this.SetStyle(ControlStyles.UserPaint, true); //Call in constructor, Use UserPaint
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if (Enabled)
            {
                //use normal realization
                base.OnPaint(e);
                return;
            }
            //custom drawing
            using (Brush aBrush = new SolidBrush(Color.Black))
            {
                Rectangle rect1 = new Rectangle(75, 10, 0, 0);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(Text, Font, aBrush, rect1, stringFormat);
            }
        }
    }
    partial class Item
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.lbDaBan = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.btnItem = new Guna.UI2.WinForms.Guna2Button();
            this.picture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBuy = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnTinhTrang = new Guna.UI2.WinForms.Guna2Button();
            this.lbGia = new QLCuaHangQuanAo.Control_User.CustomLabel();
            this.btnItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.picture.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(3, 119);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(57, 21);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "abcxyz";
            this.lbName.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // lbDaBan
            // 
            this.lbDaBan.AutoSize = true;
            this.lbDaBan.Font = new System.Drawing.Font("Quicksand SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDaBan.ForeColor = System.Drawing.Color.Black;
            this.lbDaBan.Location = new System.Drawing.Point(5, 164);
            this.lbDaBan.Margin = new System.Windows.Forms.Padding(0);
            this.lbDaBan.Name = "lbDaBan";
            this.lbDaBan.Size = new System.Drawing.Size(46, 18);
            this.lbDaBan.TabIndex = 4;
            this.lbDaBan.Text = "DaBan";
            this.lbDaBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Font = new System.Drawing.Font("Quicksand SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lbSoLuong.Location = new System.Drawing.Point(84, 163);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(66, 19);
            this.lbSoLuong.TabIndex = 5;
            this.lbSoLuong.Text = "SoLuong";
            this.lbSoLuong.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnItem
            // 
            this.btnItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.btnItem.BorderRadius = 5;
            this.btnItem.BorderThickness = 1;
            this.btnItem.CheckedState.Parent = this.btnItem;
            this.btnItem.Controls.Add(this.picture);
            this.btnItem.Controls.Add(this.lbSoLuong);
            this.btnItem.Controls.Add(this.lbDaBan);
            this.btnItem.Controls.Add(this.lbName);
            this.btnItem.Controls.Add(this.lbGia);
            this.btnItem.CustomImages.Parent = this.btnItem;
            this.btnItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnItem.DisabledState.Parent = this.btnItem;
            this.btnItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.btnItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnItem.ForeColor = System.Drawing.Color.White;
            this.btnItem.HoverState.Parent = this.btnItem;
            this.btnItem.Location = new System.Drawing.Point(0, 0);
            this.btnItem.Name = "btnItem";
            this.btnItem.ShadowDecoration.Parent = this.btnItem;
            this.btnItem.Size = new System.Drawing.Size(155, 185);
            this.btnItem.TabIndex = 8;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.BorderRadius = 5;
            this.picture.Controls.Add(this.btnBuy);
            this.picture.Controls.Add(this.btnTinhTrang);
            this.picture.FillColor = System.Drawing.Color.Silver;
            this.picture.ImageRotate = 0F;
            this.picture.Location = new System.Drawing.Point(3, 3);
            this.picture.Name = "picture";
            this.picture.ShadowDecoration.Parent = this.picture;
            this.picture.Size = new System.Drawing.Size(149, 113);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 7;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackgroundImage = global::QLCuaHangQuanAo.Properties.Resources.add;
            this.btnBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuy.CheckedState.Parent = this.btnBuy;
            this.btnBuy.CustomImages.Parent = this.btnBuy;
            this.btnBuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuy.DisabledState.Parent = this.btnBuy;
            this.btnBuy.FillColor = System.Drawing.Color.Transparent;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.HoverState.Parent = this.btnBuy;
            this.btnBuy.Location = new System.Drawing.Point(115, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBuy.ShadowDecoration.Parent = this.btnBuy;
            this.btnBuy.Size = new System.Drawing.Size(32, 32);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnTinhTrang
            // 
            this.btnTinhTrang.BorderRadius = 7;
            this.btnTinhTrang.CheckedState.Parent = this.btnTinhTrang;
            this.btnTinhTrang.CustomImages.Parent = this.btnTinhTrang;
            this.btnTinhTrang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhTrang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhTrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTinhTrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTinhTrang.DisabledState.Parent = this.btnTinhTrang;
            this.btnTinhTrang.FillColor = System.Drawing.Color.Red;
            this.btnTinhTrang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTinhTrang.ForeColor = System.Drawing.Color.White;
            this.btnTinhTrang.HoverState.Parent = this.btnTinhTrang;
            this.btnTinhTrang.Location = new System.Drawing.Point(2, 2);
            this.btnTinhTrang.Name = "btnTinhTrang";
            this.btnTinhTrang.ShadowDecoration.Parent = this.btnTinhTrang;
            this.btnTinhTrang.Size = new System.Drawing.Size(49, 20);
            this.btnTinhTrang.TabIndex = 9;
            this.btnTinhTrang.Text = "Hết";
            // 
            // lbGia
            // 
            this.lbGia.BackColor = System.Drawing.Color.Transparent;
            this.lbGia.Enabled = false;
            this.lbGia.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.ForeColor = System.Drawing.Color.Black;
            this.lbGia.Location = new System.Drawing.Point(3, 138);
            this.lbGia.Margin = new System.Windows.Forms.Padding(0);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(149, 26);
            this.lbGia.TabIndex = 9;
            this.lbGia.Text = "10.000";
            this.lbGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbGia.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnItem);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(155, 185);
            this.btnItem.ResumeLayout(false);
            this.btnItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.picture.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public CustomLabel lbGia;
        public Label lbName;
        public Label lbDaBan;
        public Label lbSoLuong;
        public Guna.UI2.WinForms.Guna2PictureBox picture;
        public Guna.UI2.WinForms.Guna2CircleButton btnBuy;
        public Guna.UI2.WinForms.Guna2Button btnTinhTrang;
        public Guna.UI2.WinForms.Guna2Button btnItem;
    }
}
