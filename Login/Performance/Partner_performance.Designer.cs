
namespace Login
{
    partial class Partner_performance
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
            this.cbbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.flpnStore = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReload = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnCart = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
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
            this.cbbFilter.Location = new System.Drawing.Point(13, 6);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.ShadowDecoration.Parent = this.cbbFilter;
            this.cbbFilter.Size = new System.Drawing.Size(152, 36);
            this.cbbFilter.TabIndex = 10;
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
            this.txbSearch.Location = new System.Drawing.Point(518, 6);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderText = "Search";
            this.txbSearch.SelectedText = "";
            this.txbSearch.ShadowDecoration.Parent = this.txbSearch;
            this.txbSearch.Size = new System.Drawing.Size(156, 36);
            this.txbSearch.TabIndex = 11;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flpnStore
            // 
            this.flpnStore.AutoScroll = true;
            this.flpnStore.Location = new System.Drawing.Point(13, 52);
            this.flpnStore.Name = "flpnStore";
            this.flpnStore.Size = new System.Drawing.Size(661, 382);
            this.flpnStore.TabIndex = 12;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BackgroundImage = global::Login.Properties.Resources.reload1;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReload.CheckedState.Parent = this.btnReload;
            this.btnReload.CustomImages.Parent = this.btnReload;
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.DisabledState.Parent = this.btnReload;
            this.btnReload.FillColor = System.Drawing.Color.Transparent;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.HoverState.Parent = this.btnReload;
            this.btnReload.Location = new System.Drawing.Point(477, 7);
            this.btnReload.Name = "btnReload";
            this.btnReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReload.ShadowDecoration.Parent = this.btnReload;
            this.btnReload.Size = new System.Drawing.Size(35, 35);
            this.btnReload.TabIndex = 15;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.BackgroundImage = global::Login.Properties.Resources.shopping_cart;
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCart.CheckedState.Parent = this.btnCart;
            this.btnCart.CustomImages.Parent = this.btnCart;
            this.btnCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCart.DisabledState.Parent = this.btnCart;
            this.btnCart.FillColor = System.Drawing.Color.Transparent;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.HoverState.Parent = this.btnCart;
            this.btnCart.Location = new System.Drawing.Point(433, 5);
            this.btnCart.Name = "btnCart";
            this.btnCart.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCart.ShadowDecoration.Parent = this.btnCart;
            this.btnCart.Size = new System.Drawing.Size(39, 39);
            this.btnCart.TabIndex = 14;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // Partner_performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(686, 441);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.flpnStore);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.cbbFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Partner_performance";
            this.Text = "Partner_performance";
            this.Load += new System.EventHandler(this.Partner_performance_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbbFilter;
        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
        private System.Windows.Forms.FlowLayoutPanel flpnStore;
        private Guna.UI2.WinForms.Guna2CircleButton btnCart;
        private Guna.UI2.WinForms.Guna2CircleButton btnReload;
    }
}