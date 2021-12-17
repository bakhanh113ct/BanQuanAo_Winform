
namespace QLCuaHangQuanAo.SubForm
{
    partial class Product_Bill
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgrvItem = new Guna.UI2.WinForms.Guna2DataGridView();
            this.anh = new System.Windows.Forms.DataGridViewImageColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tool3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.exit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuyDon = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXN = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvItem)).BeginInit();
            this.tool3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrvItem
            // 
            this.dtgrvItem.AllowUserToAddRows = false;
            this.dtgrvItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgrvItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvItem.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrvItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgrvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Quicksand Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgrvItem.ColumnHeadersHeight = 30;
            this.dtgrvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anh,
            this.ten,
            this.Loai,
            this.soluong,
            this.gia});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvItem.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgrvItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrvItem.EnableHeadersVisualStyles = false;
            this.dtgrvItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvItem.Location = new System.Drawing.Point(0, 59);
            this.dtgrvItem.Name = "dtgrvItem";
            this.dtgrvItem.RowHeadersVisible = false;
            this.dtgrvItem.RowHeadersWidth = 40;
            this.dtgrvItem.RowTemplate.Height = 60;
            this.dtgrvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvItem.Size = new System.Drawing.Size(684, 302);
            this.dtgrvItem.TabIndex = 1;
            this.dtgrvItem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgrvItem.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgrvItem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgrvItem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgrvItem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgrvItem.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgrvItem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvItem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgrvItem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgrvItem.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgrvItem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgrvItem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgrvItem.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgrvItem.ThemeStyle.ReadOnly = false;
            this.dtgrvItem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgrvItem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgrvItem.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgrvItem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgrvItem.ThemeStyle.RowsStyle.Height = 60;
            this.dtgrvItem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvItem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // anh
            // 
            this.anh.DataPropertyName = "ANH";
            this.anh.HeaderText = "";
            this.anh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.anh.Name = "anh";
            this.anh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.anh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "TEN";
            this.ten.FillWeight = 135F;
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "TENLOAI";
            this.Loai.FillWeight = 130F;
            this.Loai.HeaderText = "Loại";
            this.Loai.Name = "Loai";
            this.Loai.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soluong.DataPropertyName = "SL";
            this.soluong.FillWeight = 121.8274F;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.soluong.Width = 105;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "GIA";
            this.gia.FillWeight = 135.388F;
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // tool3
            // 
            this.tool3.BackColor = System.Drawing.Color.Transparent;
            this.tool3.Controls.Add(this.exit);
            this.tool3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.tool3.Location = new System.Drawing.Point(660, 0);
            this.tool3.Margin = new System.Windows.Forms.Padding(2);
            this.tool3.Name = "tool3";
            this.tool3.ShadowColor = System.Drawing.Color.Black;
            this.tool3.ShadowShift = 0;
            this.tool3.Size = new System.Drawing.Size(24, 24);
            this.tool3.TabIndex = 22;
            // 
            // exit
            // 
            this.exit.CheckedState.Parent = this.exit;
            this.exit.CustomImages.Parent = this.exit;
            this.exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exit.DisabledState.Parent = this.exit;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.HoverState.Parent = this.exit;
            this.exit.Image = global::QLCuaHangQuanAo.Properties.Resources.delete_64px;
            this.exit.ImageSize = new System.Drawing.Size(22, 22);
            this.exit.Location = new System.Drawing.Point(4, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.ShadowDecoration.Parent = this.exit;
            this.exit.Size = new System.Drawing.Size(20, 24);
            this.exit.TabIndex = 2;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(121)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(13, 37);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(35, 4);
            this.guna2GradientPanel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand SemiBold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 34);
            this.label1.TabIndex = 36;
            this.label1.Text = "Đơn hàng";
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.BorderRadius = 8;
            this.btnHuyDon.CheckedState.Parent = this.btnHuyDon;
            this.btnHuyDon.CustomImages.Parent = this.btnHuyDon;
            this.btnHuyDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyDon.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuyDon.DisabledState.Parent = this.btnHuyDon;
            this.btnHuyDon.FillColor = System.Drawing.Color.LightCoral;
            this.btnHuyDon.FillColor2 = System.Drawing.Color.Red;
            this.btnHuyDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHuyDon.ForeColor = System.Drawing.Color.White;
            this.btnHuyDon.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnHuyDon.HoverState.Parent = this.btnHuyDon;
            this.btnHuyDon.Location = new System.Drawing.Point(545, 19);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.ShadowDecoration.Parent = this.btnHuyDon;
            this.btnHuyDon.Size = new System.Drawing.Size(100, 34);
            this.btnHuyDon.TabIndex = 65;
            this.btnHuyDon.Text = "Hủy đơn";
            this.btnHuyDon.Click += new System.EventHandler(this.btnHuyDon_Click);
            // 
            // btnXN
            // 
            this.btnXN.BorderRadius = 8;
            this.btnXN.CheckedState.Parent = this.btnXN;
            this.btnXN.CustomImages.Parent = this.btnXN;
            this.btnXN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXN.DisabledState.Parent = this.btnXN;
            this.btnXN.FillColor = System.Drawing.Color.Green;
            this.btnXN.FillColor2 = System.Drawing.Color.Lime;
            this.btnXN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXN.ForeColor = System.Drawing.Color.White;
            this.btnXN.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnXN.HoverState.Parent = this.btnXN;
            this.btnXN.Location = new System.Drawing.Point(377, 19);
            this.btnXN.Name = "btnXN";
            this.btnXN.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnXN.ShadowDecoration.Parent = this.btnXN;
            this.btnXN.Size = new System.Drawing.Size(162, 34);
            this.btnXN.TabIndex = 67;
            this.btnXN.Text = "Xác nhận hoàn thành";
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // Product_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.btnHuyDon);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tool3);
            this.Controls.Add(this.dtgrvItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_HoaDon";
            this.Load += new System.EventHandler(this.Product_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvItem)).EndInit();
            this.tool3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtgrvItem;
        private Guna.UI2.WinForms.Guna2ShadowPanel tool3;
        private Guna.UI2.WinForms.Guna2Button exit;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private Guna.UI2.WinForms.Guna2GradientButton btnHuyDon;
        private Guna.UI2.WinForms.Guna2GradientButton btnXN;
    }
}