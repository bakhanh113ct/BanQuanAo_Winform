﻿
namespace Login
{
    partial class Store_performence
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
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.cbbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.flpnStore = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReload = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(373, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(103, 26);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbFilter
            // 
            this.cbbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbbFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.cbbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbFilter.FocusedState.Parent = this.cbbFilter;
            this.cbbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbFilter.HoverState.Parent = this.cbbFilter;
            this.cbbFilter.ItemHeight = 30;
            this.cbbFilter.Items.AddRange(new object[] {
            "Áo",
            "Quần",
            "Giày, Dép",
            "Mũ",
            "Tất cả"});
            this.cbbFilter.ItemsAppearance.Parent = this.cbbFilter;
            this.cbbFilter.Location = new System.Drawing.Point(13, 5);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.ShadowDecoration.Parent = this.cbbFilter;
            this.cbbFilter.Size = new System.Drawing.Size(152, 36);
            this.cbbFilter.TabIndex = 5;
            this.cbbFilter.SelectedIndexChanged += new System.EventHandler(this.cbbFilter_SelectedIndexChanged);
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.DefaultText = "";
            this.txbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.DisabledState.Parent = this.txbSearch;
            this.txbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.FocusedState.Parent = this.txbSearch;
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.HoverState.Parent = this.txbSearch;
            this.txbSearch.Location = new System.Drawing.Point(518, 5);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderText = "Search";
            this.txbSearch.SelectedText = "";
            this.txbSearch.ShadowDecoration.Parent = this.txbSearch;
            this.txbSearch.Size = new System.Drawing.Size(156, 36);
            this.txbSearch.TabIndex = 6;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flpnStore
            // 
            this.flpnStore.AutoScroll = true;
            this.flpnStore.Location = new System.Drawing.Point(13, 47);
            this.flpnStore.Name = "flpnStore";
            this.flpnStore.Size = new System.Drawing.Size(661, 382);
            this.flpnStore.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.CheckedState.Parent = this.btnReload;
            this.btnReload.CustomImages.Parent = this.btnReload;
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.DisabledState.Parent = this.btnReload;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.HoverState.Parent = this.btnReload;
            this.btnReload.Location = new System.Drawing.Point(482, 1);
            this.btnReload.Name = "btnReload";
            this.btnReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReload.ShadowDecoration.Parent = this.btnReload;
            this.btnReload.Size = new System.Drawing.Size(30, 30);
            this.btnReload.TabIndex = 8;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Store_performence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(686, 441);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.flpnStore);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.cbbFilter);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Store_performence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store_performence";
            this.Load += new System.EventHandler(this.Store_performence_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbbFilter;
        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
        private System.Windows.Forms.FlowLayoutPanel flpnStore;
        private Guna.UI2.WinForms.Guna2CircleButton btnReload;
    }
}