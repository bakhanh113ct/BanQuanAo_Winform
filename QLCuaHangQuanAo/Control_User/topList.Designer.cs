
namespace QLCuaHangQuanAo.Control_User
{
    partial class topList
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
            this.hi = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.top = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.doanhso = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.Label();
            this.anhdd = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.hi.SuspendLayout();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhdd)).BeginInit();
            this.SuspendLayout();
            // 
            // hi
            // 
            this.hi.BackColor = System.Drawing.Color.Transparent;
            this.hi.Controls.Add(this.top);
            this.hi.Controls.Add(this.doanhso);
            this.hi.Controls.Add(this.hoten);
            this.hi.Controls.Add(this.anhdd);
            this.hi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hi.FillColor = System.Drawing.Color.White;
            this.hi.Location = new System.Drawing.Point(0, 0);
            this.hi.Name = "hi";
            this.hi.Radius = 5;
            this.hi.ShadowColor = System.Drawing.Color.Black;
            this.hi.ShadowShift = 2;
            this.hi.Size = new System.Drawing.Size(260, 60);
            this.hi.TabIndex = 0;
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Transparent;
            this.top.Controls.Add(this.label1);
            this.top.FillColor = System.Drawing.Color.Red;
            this.top.ForeColor = System.Drawing.Color.White;
            this.top.Location = new System.Drawing.Point(224, 0);
            this.top.Name = "top";
            this.top.Radius = 4;
            this.top.ShadowColor = System.Drawing.Color.Black;
            this.top.ShadowDepth = 0;
            this.top.ShadowShift = 0;
            this.top.Size = new System.Drawing.Size(33, 29);
            this.top.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doanhso
            // 
            this.doanhso.AutoSize = true;
            this.doanhso.Font = new System.Drawing.Font("Quicksand SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhso.Location = new System.Drawing.Point(63, 32);
            this.doanhso.Name = "doanhso";
            this.doanhso.Size = new System.Drawing.Size(51, 23);
            this.doanhso.TabIndex = 2;
            this.doanhso.Text = "9999$";
            // 
            // hoten
            // 
            this.hoten.AutoSize = true;
            this.hoten.Font = new System.Drawing.Font("Quicksand SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten.ForeColor = System.Drawing.Color.BlueViolet;
            this.hoten.Location = new System.Drawing.Point(62, 5);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(156, 25);
            this.hoten.TabIndex = 1;
            this.hoten.Text = "Nguyễn Đức Long";
            // 
            // anhdd
            // 
            this.anhdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anhdd.Image = global::QLCuaHangQuanAo.Properties.Resources.avatar_48px;
            this.anhdd.ImageRotate = 0F;
            this.anhdd.Location = new System.Drawing.Point(5, 5);
            this.anhdd.Name = "anhdd";
            this.anhdd.ShadowDecoration.BorderRadius = 0;
            this.anhdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.anhdd.ShadowDecoration.Parent = this.anhdd;
            this.anhdd.Size = new System.Drawing.Size(50, 50);
            this.anhdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anhdd.TabIndex = 0;
            this.anhdd.TabStop = false;
            // 
            // topList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hi);
            this.Name = "topList";
            this.Size = new System.Drawing.Size(260, 60);
            this.hi.ResumeLayout(false);
            this.hi.PerformLayout();
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel hi;
        private Guna.UI2.WinForms.Guna2CirclePictureBox anhdd;
        private System.Windows.Forms.Label doanhso;
        private System.Windows.Forms.Label hoten;
        private Guna.UI2.WinForms.Guna2ShadowPanel top;
        private System.Windows.Forms.Label label1;
    }
}
