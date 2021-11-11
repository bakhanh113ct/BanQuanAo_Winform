
namespace Login.SubForm
{
    partial class Cart_Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart_Form));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.dtgrvItem = new Guna.UI2.WinForms.Guna2DataGridView();
            this.anh = new System.Windows.Forms.DataGridViewImageColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tool3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.exit = new Guna.UI2.WinForms.Guna2Button();
            this.zooe_in_out = new Guna.UI2.WinForms.Guna2Button();
            this.minimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnXN = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvItem)).BeginInit();
            this.tool3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // dtgrvItem
            // 
            this.dtgrvItem.AllowUserToAddRows = false;
            this.dtgrvItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgrvItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvItem.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrvItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgrvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrvItem.ColumnHeadersHeight = 30;
            this.dtgrvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anh,
            this.ten,
            this.Loai,
            this.soluong,
            this.gia,
            this.chon});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrvItem.EnableHeadersVisualStyles = false;
            this.dtgrvItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvItem.Location = new System.Drawing.Point(0, 78);
            this.dtgrvItem.Name = "dtgrvItem";
            this.dtgrvItem.RowHeadersVisible = false;
            this.dtgrvItem.RowHeadersWidth = 40;
            this.dtgrvItem.RowTemplate.Height = 60;
            this.dtgrvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvItem.Size = new System.Drawing.Size(684, 283);
            this.dtgrvItem.TabIndex = 0;
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
            this.anh.HeaderText = "";
            this.anh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.anh.Name = "anh";
            this.anh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.anh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ten
            // 
            this.ten.FillWeight = 135F;
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // Loai
            // 
            this.Loai.FillWeight = 130F;
            this.Loai.HeaderText = "Loại";
            this.Loai.Name = "Loai";
            this.Loai.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soluong.FillWeight = 121.8274F;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.soluong.Width = 88;
            // 
            // gia
            // 
            this.gia.FillWeight = 135.388F;
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // chon
            // 
            this.chon.FillWeight = 40F;
            this.chon.HeaderText = "Chọn";
            this.chon.Name = "chon";
            this.chon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tool3
            // 
            this.tool3.BackColor = System.Drawing.Color.Transparent;
            this.tool3.Controls.Add(this.exit);
            this.tool3.Controls.Add(this.zooe_in_out);
            this.tool3.Controls.Add(this.minimize);
            this.tool3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.tool3.Location = new System.Drawing.Point(615, 1);
            this.tool3.Margin = new System.Windows.Forms.Padding(2);
            this.tool3.Name = "tool3";
            this.tool3.ShadowColor = System.Drawing.Color.Black;
            this.tool3.ShadowShift = 0;
            this.tool3.Size = new System.Drawing.Size(69, 24);
            this.tool3.TabIndex = 21;
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
            this.exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.HoverState.Parent = this.exit;
            this.exit.Image = global::Login.Properties.Resources.delete_64px;
            this.exit.ImageSize = new System.Drawing.Size(22, 22);
            this.exit.Location = new System.Drawing.Point(47, 2);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.ShadowDecoration.Parent = this.exit;
            this.exit.Size = new System.Drawing.Size(20, 21);
            this.exit.TabIndex = 2;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // zooe_in_out
            // 
            this.zooe_in_out.CheckedState.Parent = this.zooe_in_out;
            this.zooe_in_out.CustomImages.Parent = this.zooe_in_out;
            this.zooe_in_out.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.zooe_in_out.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.zooe_in_out.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.zooe_in_out.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.zooe_in_out.DisabledState.Parent = this.zooe_in_out;
            this.zooe_in_out.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.zooe_in_out.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.zooe_in_out.ForeColor = System.Drawing.Color.White;
            this.zooe_in_out.HoverState.Parent = this.zooe_in_out;
            this.zooe_in_out.Image = global::Login.Properties.Resources.toggle_full_screen_64px;
            this.zooe_in_out.ImageSize = new System.Drawing.Size(22, 22);
            this.zooe_in_out.Location = new System.Drawing.Point(25, 2);
            this.zooe_in_out.Margin = new System.Windows.Forms.Padding(2);
            this.zooe_in_out.Name = "zooe_in_out";
            this.zooe_in_out.ShadowDecoration.Parent = this.zooe_in_out;
            this.zooe_in_out.Size = new System.Drawing.Size(20, 21);
            this.zooe_in_out.TabIndex = 1;
            // 
            // minimize
            // 
            this.minimize.CheckedState.Parent = this.minimize;
            this.minimize.CustomImages.Parent = this.minimize;
            this.minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimize.DisabledState.Parent = this.minimize;
            this.minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.HoverState.Parent = this.minimize;
            this.minimize.Image = global::Login.Properties.Resources.minimize_window_64px2;
            this.minimize.ImageSize = new System.Drawing.Size(22, 22);
            this.minimize.Location = new System.Drawing.Point(2, 2);
            this.minimize.Margin = new System.Windows.Forms.Padding(2);
            this.minimize.Name = "minimize";
            this.minimize.ShadowDecoration.Parent = this.minimize;
            this.minimize.Size = new System.Drawing.Size(20, 21);
            this.minimize.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.DisabledState.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(561, 31);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(36, 41);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXN
            // 
            this.btnXN.CheckedState.Parent = this.btnXN;
            this.btnXN.CustomImages.Parent = this.btnXN;
            this.btnXN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXN.DisabledState.Parent = this.btnXN;
            this.btnXN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXN.ForeColor = System.Drawing.Color.White;
            this.btnXN.HoverState.Parent = this.btnXN;
            this.btnXN.Location = new System.Drawing.Point(24, 12);
            this.btnXN.Name = "btnXN";
            this.btnXN.ShadowDecoration.Parent = this.btnXN;
            this.btnXN.Size = new System.Drawing.Size(127, 34);
            this.btnXN.TabIndex = 23;
            this.btnXN.Text = "Xác nhận";
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // Cart_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.tool3);
            this.Controls.Add(this.dtgrvItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cart_Form";
            this.Load += new System.EventHandler(this.Cart_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvItem)).EndInit();
            this.tool3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgrvItem;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ShadowPanel tool3;
        private Guna.UI2.WinForms.Guna2Button exit;
        private Guna.UI2.WinForms.Guna2Button zooe_in_out;
        private Guna.UI2.WinForms.Guna2Button minimize;
        private System.Windows.Forms.DataGridViewImageColumn anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnXN;
    }
}