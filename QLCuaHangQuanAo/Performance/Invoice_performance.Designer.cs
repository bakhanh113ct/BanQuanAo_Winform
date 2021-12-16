
namespace QLCuaHangQuanAo
{
    partial class Invoice_performance
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
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRIGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.thang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timeXN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hanHD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NGHD = new System.Windows.Forms.Label();
            this.time = new Guna.UI2.WinForms.Guna2Panel();
            this.tim_theo_ten = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSendEmail = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.time.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_KH
            // 
            this.list_KH.AutoScroll = true;
            this.list_KH.Location = new System.Drawing.Point(0, 59);
            this.list_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_KH.Name = "list_KH";
            this.list_KH.Size = new System.Drawing.Size(429, 486);
            this.list_KH.TabIndex = 0;
            // 
            // loadBill
            // 
            this.loadBill.AllowDrop = true;
            this.loadBill.AllowUserToAddRows = false;
            this.loadBill.AllowUserToDeleteRows = false;
            this.loadBill.AllowUserToOrderColumns = true;
            this.loadBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.loadBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.loadBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.loadBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loadBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.loadBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(78)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.loadBill.ColumnHeadersHeight = 52;
            this.loadBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.loadBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENSP,
            this.SL,
            this.GIA,
            this.TRIGIA});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.loadBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.loadBill.EnableHeadersVisualStyles = false;
            this.loadBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.loadBill.Location = new System.Drawing.Point(435, 58);
            this.loadBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadBill.Name = "loadBill";
            this.loadBill.ReadOnly = true;
            this.loadBill.RowHeadersVisible = false;
            this.loadBill.RowHeadersWidth = 51;
            this.loadBill.RowTemplate.Height = 24;
            this.loadBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loadBill.Size = new System.Drawing.Size(467, 240);
            this.loadBill.StandardTab = true;
            this.loadBill.TabIndex = 1;
            this.loadBill.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            this.loadBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.loadBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.loadBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.loadBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.loadBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.loadBill.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.loadBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.loadBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.loadBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.loadBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.loadBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.loadBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.loadBill.ThemeStyle.HeaderStyle.Height = 52;
            this.loadBill.ThemeStyle.ReadOnly = true;
            this.loadBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.loadBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.loadBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.loadBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.loadBill.ThemeStyle.RowsStyle.Height = 24;
            this.loadBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.loadBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            // TRIGIA
            // 
            this.TRIGIA.HeaderText = "Thành tiền";
            this.TRIGIA.MinimumWidth = 6;
            this.TRIGIA.Name = "TRIGIA";
            this.TRIGIA.ReadOnly = true;
            // 
            // View
            // 
            this.View.BorderRadius = 10;
            this.View.CheckedState.Parent = this.View;
            this.View.CustomImages.Parent = this.View;
            this.View.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.View.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.View.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.View.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.View.DisabledState.Parent = this.View;
            this.View.FillColor = System.Drawing.Color.DarkViolet;
            this.View.Font = new System.Drawing.Font("Quicksand SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ForeColor = System.Drawing.Color.Azure;
            this.View.HoverState.Parent = this.View;
            this.View.Location = new System.Drawing.Point(757, 2);
            this.View.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.View.Name = "View";
            this.View.ShadowDecoration.Parent = this.View;
            this.View.Size = new System.Drawing.Size(145, 46);
            this.View.TabIndex = 3;
            this.View.Text = "Xem";
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(436, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chi Tiết";
            // 
            // thang
            // 
            this.thang.BackColor = System.Drawing.Color.Transparent;
            this.thang.BorderColor = System.Drawing.Color.BlueViolet;
            this.thang.BorderRadius = 6;
            this.thang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thang.FocusedState.Parent = this.thang;
            this.thang.Font = new System.Drawing.Font("Quicksand SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.thang.HoverState.Parent = this.thang;
            this.thang.ItemHeight = 30;
            this.thang.ItemsAppearance.Parent = this.thang;
            this.thang.Location = new System.Drawing.Point(45, 7);
            this.thang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thang.Name = "thang";
            this.thang.ShadowDecoration.Parent = this.thang;
            this.thang.Size = new System.Drawing.Size(143, 36);
            this.thang.TabIndex = 5;
            this.thang.SelectedIndexChanged += new System.EventHandler(this.thang_SelectedIndexChanged_1);
            this.thang.Click += new System.EventHandler(this.thang_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::QLCuaHangQuanAo.Properties.Resources.filter_50px;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 7);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 39);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // timeXN
            // 
            this.timeXN.AutoSize = true;
            this.timeXN.Font = new System.Drawing.Font("Quicksand SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeXN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.timeXN.Location = new System.Drawing.Point(3, 86);
            this.timeXN.Name = "timeXN";
            this.timeXN.Size = new System.Drawing.Size(59, 25);
            this.timeXN.TabIndex = 7;
            this.timeXN.Text = "NGXN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thời gian xác nhận:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(3, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thời giự kiến hoàn thành";
            // 
            // hanHD
            // 
            this.hanHD.AutoSize = true;
            this.hanHD.Font = new System.Drawing.Font("Quicksand SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hanHD.ForeColor = System.Drawing.Color.Goldenrod;
            this.hanHD.Location = new System.Drawing.Point(5, 146);
            this.hanHD.Name = "hanHD";
            this.hanHD.Size = new System.Drawing.Size(67, 25);
            this.hanHD.TabIndex = 10;
            this.hanHD.Text = "hanHD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thời gian khởi tạo đơn hàng:";
            // 
            // NGHD
            // 
            this.NGHD.AutoSize = true;
            this.NGHD.Font = new System.Drawing.Font("Quicksand SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGHD.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NGHD.Location = new System.Drawing.Point(3, 25);
            this.NGHD.Name = "NGHD";
            this.NGHD.Size = new System.Drawing.Size(60, 25);
            this.NGHD.TabIndex = 11;
            this.NGHD.Text = "NGHD";
            // 
            // time
            // 
            this.time.Controls.Add(this.label5);
            this.time.Controls.Add(this.timeXN);
            this.time.Controls.Add(this.NGHD);
            this.time.Controls.Add(this.label3);
            this.time.Controls.Add(this.hanHD);
            this.time.Controls.Add(this.label4);
            this.time.Location = new System.Drawing.Point(436, 304);
            this.time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.time.Name = "time";
            this.time.ShadowDecoration.Parent = this.time;
            this.time.Size = new System.Drawing.Size(399, 178);
            this.time.TabIndex = 13;
            // 
            // tim_theo_ten
            // 
            this.tim_theo_ten.BorderColor = System.Drawing.Color.BlueViolet;
            this.tim_theo_ten.BorderRadius = 5;
            this.tim_theo_ten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tim_theo_ten.DefaultText = "";
            this.tim_theo_ten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tim_theo_ten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tim_theo_ten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tim_theo_ten.DisabledState.Parent = this.tim_theo_ten;
            this.tim_theo_ten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tim_theo_ten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tim_theo_ten.FocusedState.Parent = this.tim_theo_ten;
            this.tim_theo_ten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tim_theo_ten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tim_theo_ten.HoverState.Parent = this.tim_theo_ten;
            this.tim_theo_ten.Location = new System.Drawing.Point(209, 7);
            this.tim_theo_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tim_theo_ten.Name = "tim_theo_ten";
            this.tim_theo_ten.PasswordChar = '\0';
            this.tim_theo_ten.PlaceholderText = "Tìm theo tên";
            this.tim_theo_ten.SelectedText = "";
            this.tim_theo_ten.ShadowDecoration.Parent = this.tim_theo_ten;
            this.tim_theo_ten.Size = new System.Drawing.Size(200, 43);
            this.tim_theo_ten.TabIndex = 14;
            this.tim_theo_ten.TextChanged += new System.EventHandler(this.tim_theo_ten_TextChanged);
            this.tim_theo_ten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tim_theo_ten_KeyPress);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BorderRadius = 10;
            this.btnSendEmail.CheckedState.Parent = this.btnSendEmail;
            this.btnSendEmail.CustomImages.Parent = this.btnSendEmail;
            this.btnSendEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendEmail.DisabledState.Parent = this.btnSendEmail;
            this.btnSendEmail.FillColor = System.Drawing.Color.DarkViolet;
            this.btnSendEmail.Font = new System.Drawing.Font("Quicksand SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.Azure;
            this.btnSendEmail.HoverState.Parent = this.btnSendEmail;
            this.btnSendEmail.Location = new System.Drawing.Point(607, 2);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.ShadowDecoration.Parent = this.btnSendEmail;
            this.btnSendEmail.Size = new System.Drawing.Size(145, 46);
            this.btnSendEmail.TabIndex = 15;
            this.btnSendEmail.Text = "Gửi Mail";
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // Invoice_performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(915, 543);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.tim_theo_ten);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.thang);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.View);
            this.Controls.Add(this.loadBill);
            this.Controls.Add(this.list_KH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Invoice_performance";
            this.Text = "Customer_performance";
            ((System.ComponentModel.ISupportInitialize)(this.loadBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.time.ResumeLayout(false);
            this.time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button View;
        private Guna.UI2.WinForms.Guna2DataGridView loadBill;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox thang;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label timeXN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hanHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NGHD;
        private Guna.UI2.WinForms.Guna2Panel time;
        private Guna.UI2.WinForms.Guna2TextBox tim_theo_ten;
        private Guna.UI2.WinForms.Guna2Button btnSendEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRIGIA;
        public System.Windows.Forms.FlowLayoutPanel list_KH;
    }
}