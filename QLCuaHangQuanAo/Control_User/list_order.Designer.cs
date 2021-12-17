
namespace QLCuaHangQuanAo.Control_User
{
    partial class list_order
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
            this.BackGround = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.thao_tac = new Guna.UI2.WinForms.Guna2Panel();
            this.trang_thai = new Guna.UI2.WinForms.Guna2Button();
            this.so_luong_san_pham = new System.Windows.Forms.Label();
            this.ten_khach_hang = new System.Windows.Forms.Label();
            this.ngay_mua_hang = new System.Windows.Forms.Label();
            this.avt_khachhang = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BackGround.SuspendLayout();
            this.thao_tac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avt_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.BackColor = System.Drawing.Color.Transparent;
            this.BackGround.Controls.Add(this.thao_tac);
            this.BackGround.Controls.Add(this.so_luong_san_pham);
            this.BackGround.Controls.Add(this.ten_khach_hang);
            this.BackGround.Controls.Add(this.ngay_mua_hang);
            this.BackGround.Controls.Add(this.avt_khachhang);
            this.BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGround.FillColor = System.Drawing.Color.White;
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackGround.Name = "BackGround";
            this.BackGround.Radius = 7;
            this.BackGround.ShadowColor = System.Drawing.Color.BlueViolet;
            this.BackGround.ShadowDepth = 80;
            this.BackGround.ShadowShift = 2;
            this.BackGround.Size = new System.Drawing.Size(301, 65);
            this.BackGround.TabIndex = 0;
            // 
            // thao_tac
            // 
            this.thao_tac.CausesValidation = false;
            this.thao_tac.Controls.Add(this.trang_thai);
            this.thao_tac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thao_tac.Location = new System.Drawing.Point(0, 0);
            this.thao_tac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thao_tac.Name = "thao_tac";
            this.thao_tac.ShadowDecoration.Parent = this.thao_tac;
            this.thao_tac.Size = new System.Drawing.Size(301, 65);
            this.thao_tac.TabIndex = 5;
            this.thao_tac.UseTransparentBackground = true;
            this.thao_tac.Click += new System.EventHandler(this.thao_tac_Click);
            this.thao_tac.MouseLeave += new System.EventHandler(this.thao_tac_MouseLeave);
            this.thao_tac.MouseHover += new System.EventHandler(this.thao_tac_MouseHover);
            // 
            // trang_thai
            // 
            this.trang_thai.BorderRadius = 7;
            this.trang_thai.CheckedState.Parent = this.trang_thai;
            this.trang_thai.CustomImages.Parent = this.trang_thai;
            this.trang_thai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.trang_thai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.trang_thai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.trang_thai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.trang_thai.DisabledState.Parent = this.trang_thai;
            this.trang_thai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.trang_thai.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.trang_thai.ForeColor = System.Drawing.Color.White;
            this.trang_thai.HoverState.Parent = this.trang_thai;
            this.trang_thai.Location = new System.Drawing.Point(176, 0);
            this.trang_thai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.ShadowDecoration.Parent = this.trang_thai;
            this.trang_thai.Size = new System.Drawing.Size(124, 27);
            this.trang_thai.TabIndex = 4;
            this.trang_thai.Text = "Vận chuyển";
            // 
            // so_luong_san_pham
            // 
            this.so_luong_san_pham.AutoSize = true;
            this.so_luong_san_pham.Font = new System.Drawing.Font("Quicksand Medium", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so_luong_san_pham.ForeColor = System.Drawing.Color.Goldenrod;
            this.so_luong_san_pham.Location = new System.Drawing.Point(64, 45);
            this.so_luong_san_pham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.so_luong_san_pham.Name = "so_luong_san_pham";
            this.so_luong_san_pham.Size = new System.Drawing.Size(73, 15);
            this.so_luong_san_pham.TabIndex = 3;
            this.so_luong_san_pham.Text = "4 Sản phẩm";
            // 
            // ten_khach_hang
            // 
            this.ten_khach_hang.AutoSize = true;
            this.ten_khach_hang.Font = new System.Drawing.Font("Quicksand SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_khach_hang.Location = new System.Drawing.Point(63, 20);
            this.ten_khach_hang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ten_khach_hang.Name = "ten_khach_hang";
            this.ten_khach_hang.Size = new System.Drawing.Size(142, 24);
            this.ten_khach_hang.TabIndex = 2;
            this.ten_khach_hang.Text = "Nguyễn Đức Long";
            // 
            // ngay_mua_hang
            // 
            this.ngay_mua_hang.AutoSize = true;
            this.ngay_mua_hang.Font = new System.Drawing.Font("Quicksand Medium", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay_mua_hang.Location = new System.Drawing.Point(64, 0);
            this.ngay_mua_hang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ngay_mua_hang.Name = "ngay_mua_hang";
            this.ngay_mua_hang.Size = new System.Drawing.Size(63, 15);
            this.ngay_mua_hang.TabIndex = 1;
            this.ngay_mua_hang.Text = "01,01,2021";
            // 
            // avt_khachhang
            // 
            this.avt_khachhang.BackColor = System.Drawing.Color.White;
            this.avt_khachhang.BorderRadius = 7;
            this.avt_khachhang.Image = global::QLCuaHangQuanAo.Properties.Resources.add;
            this.avt_khachhang.ImageRotate = 0F;
            this.avt_khachhang.Location = new System.Drawing.Point(7, 6);
            this.avt_khachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avt_khachhang.Name = "avt_khachhang";
            this.avt_khachhang.ShadowDecoration.Parent = this.avt_khachhang;
            this.avt_khachhang.Size = new System.Drawing.Size(45, 49);
            this.avt_khachhang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avt_khachhang.TabIndex = 0;
            this.avt_khachhang.TabStop = false;
            // 
            // list_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.BackGround);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "list_order";
            this.Size = new System.Drawing.Size(301, 65);
            this.BackGround.ResumeLayout(false);
            this.BackGround.PerformLayout();
            this.thao_tac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avt_khachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox avt_khachhang;
        private System.Windows.Forms.Label so_luong_san_pham;
        private System.Windows.Forms.Label ten_khach_hang;
        private System.Windows.Forms.Label ngay_mua_hang;
        public Guna.UI2.WinForms.Guna2Panel thao_tac;
        public Guna.UI2.WinForms.Guna2ShadowPanel BackGround;
        public Guna.UI2.WinForms.Guna2Button trang_thai;
    }
}
