
namespace QLCuaHangQuanAo.Control_User
{
    partial class Customer
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
            this.nen = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.thaotac = new Guna.UI2.WinForms.Guna2Panel();
            this.gia = new System.Windows.Forms.Label();
            this.sl = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.nen.SuspendLayout();
            this.SuspendLayout();
            // 
            // nen
            // 
            this.nen.BackColor = System.Drawing.Color.Transparent;
            this.nen.Controls.Add(this.thaotac);
            this.nen.Controls.Add(this.gia);
            this.nen.Controls.Add(this.sl);
            this.nen.Controls.Add(this.name);
            this.nen.Controls.Add(this.id);
            this.nen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nen.FillColor = System.Drawing.Color.White;
            this.nen.Location = new System.Drawing.Point(0, 0);
            this.nen.Name = "nen";
            this.nen.Radius = 5;
            this.nen.ShadowColor = System.Drawing.Color.Black;
            this.nen.ShadowDepth = 0;
            this.nen.ShadowShift = 0;
            this.nen.Size = new System.Drawing.Size(800, 75);
            this.nen.TabIndex = 0;
            // 
            // thaotac
            // 
            this.thaotac.Location = new System.Drawing.Point(0, 0);
            this.thaotac.Name = "thaotac";
            this.thaotac.ShadowDecoration.Parent = this.thaotac;
            this.thaotac.Size = new System.Drawing.Size(800, 75);
            this.thaotac.TabIndex = 4;
            this.thaotac.UseTransparentBackground = true;
            this.thaotac.Click += new System.EventHandler(this.thaotac_Click);
            // 
            // gia
            // 
            this.gia.AutoSize = true;
            this.gia.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gia.Location = new System.Drawing.Point(596, 17);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(51, 35);
            this.gia.TabIndex = 3;
            this.gia.Text = "gia";
            // 
            // sl
            // 
            this.sl.AutoSize = true;
            this.sl.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl.Location = new System.Drawing.Point(424, 17);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(42, 35);
            this.sl.TabIndex = 2;
            this.sl.Text = "SL";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(108, 17);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(80, 35);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(19, 17);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(39, 35);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.nen);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(800, 75);
            this.nen.ResumeLayout(false);
            this.nen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel thaotac;
        private System.Windows.Forms.Label gia;
        private System.Windows.Forms.Label sl;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        public Guna.UI2.WinForms.Guna2ShadowPanel nen;
    }
}
