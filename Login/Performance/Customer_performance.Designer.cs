
namespace Login
{
    partial class Customer_performance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.list_KH = new System.Windows.Forms.FlowLayoutPanel();
            this.loadBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.thanh_toan = new Guna.UI2.WinForms.Guna2Button();
            this.tong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadBill)).BeginInit();
            this.SuspendLayout();
            // 
            // list_KH
            // 
            this.list_KH.AutoScroll = true;
            this.list_KH.Location = new System.Drawing.Point(0, 122);
            this.list_KH.Name = "list_KH";
            this.list_KH.Size = new System.Drawing.Size(430, 430);
            this.list_KH.TabIndex = 0;
            this.list_KH.Paint += new System.Windows.Forms.PaintEventHandler(this.list_KH_Paint);
            // 
            // loadBill
            // 
            this.loadBill.AllowDrop = true;
            this.loadBill.AllowUserToAddRows = false;
            this.loadBill.AllowUserToDeleteRows = false;
            this.loadBill.AllowUserToOrderColumns = true;
            this.loadBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.loadBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.loadBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.loadBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loadBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.loadBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(78)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(78)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.loadBill.ColumnHeadersHeight = 52;
            this.loadBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.loadBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TENSP,
            this.SL,
            this.GIA});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.loadBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.loadBill.EnableHeadersVisualStyles = false;
            this.loadBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.loadBill.Location = new System.Drawing.Point(473, 122);
            this.loadBill.Name = "loadBill";
            this.loadBill.ReadOnly = true;
            this.loadBill.RowHeadersVisible = false;
            this.loadBill.RowHeadersWidth = 51;
            this.loadBill.RowTemplate.Height = 24;
            this.loadBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loadBill.Size = new System.Drawing.Size(430, 238);
            this.loadBill.StandardTab = true;
            this.loadBill.TabIndex = 1;
            this.loadBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.loadBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.loadBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.loadBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.loadBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.loadBill.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.loadBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.loadBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.loadBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.loadBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.loadBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.loadBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.loadBill.ThemeStyle.HeaderStyle.Height = 52;
            this.loadBill.ThemeStyle.ReadOnly = true;
            this.loadBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.loadBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.loadBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.loadBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.loadBill.ThemeStyle.RowsStyle.Height = 24;
            this.loadBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.loadBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.loadBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadBill_CellContentClick);
            // 
            // MASP
            // 
            this.MASP.HeaderText = "MASP";
            this.MASP.MinimumWidth = 6;
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            // 
            // TENSP
            // 
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.MinimumWidth = 6;
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // GIA
            // 
            this.GIA.HeaderText = "Giá";
            this.GIA.MinimumWidth = 6;
            this.GIA.Name = "GIA";
            this.GIA.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // thanh_toan
            // 
            this.thanh_toan.BorderRadius = 10;
            this.thanh_toan.CheckedState.Parent = this.thanh_toan;
            this.thanh_toan.CustomImages.Parent = this.thanh_toan;
            this.thanh_toan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thanh_toan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thanh_toan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thanh_toan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thanh_toan.DisabledState.Parent = this.thanh_toan;
            this.thanh_toan.FillColor = System.Drawing.Color.Lime;
            this.thanh_toan.Font = new System.Drawing.Font("Quicksand SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanh_toan.ForeColor = System.Drawing.Color.SlateGray;
            this.thanh_toan.HoverState.Parent = this.thanh_toan;
            this.thanh_toan.Location = new System.Drawing.Point(741, 486);
            this.thanh_toan.Name = "thanh_toan";
            this.thanh_toan.ShadowDecoration.Parent = this.thanh_toan;
            this.thanh_toan.Size = new System.Drawing.Size(153, 45);
            this.thanh_toan.TabIndex = 3;
            this.thanh_toan.Text = "Thanh toán ";
            this.thanh_toan.Click += new System.EventHandler(this.thanh_toan_Click);
            // 
            // tong
            // 
            this.tong.AutoSize = true;
            this.tong.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tong.Location = new System.Drawing.Point(719, 383);
            this.tong.Name = "tong";
            this.tong.Size = new System.Drawing.Size(109, 30);
            this.tong.TabIndex = 4;
            this.tong.Text = "tong_tien";
            // 
            // Customer_performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(915, 543);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.thanh_toan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadBill);
            this.Controls.Add(this.list_KH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customer_performance";
            this.Text = "Customer_performance";
            ((System.ComponentModel.ISupportInitialize)(this.loadBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel list_KH;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button thanh_toan;
        private Guna.UI2.WinForms.Guna2DataGridView loadBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.Label tong;
    }
}