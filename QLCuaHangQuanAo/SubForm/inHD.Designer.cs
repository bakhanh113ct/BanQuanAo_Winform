
namespace QLCuaHangQuanAo.SubForm
{
    partial class inHD
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
            this.cryinHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryinHD
            // 
            this.cryinHD.ActiveViewIndex = -1;
            this.cryinHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryinHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryinHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryinHD.Location = new System.Drawing.Point(0, 0);
            this.cryinHD.Name = "cryinHD";
            this.cryinHD.Size = new System.Drawing.Size(800, 450);
            this.cryinHD.TabIndex = 0;
            // 
            // inHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cryinHD);
            this.Name = "inHD";
            this.Text = "inHD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer cryinHD;
    }
}