
namespace QLCuaHangQuanAo.SubForm
{
    partial class frmInHoaDon
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
            this.cr_HOADON1 = new QLCuaHangQuanAo.SubForm.cr_HOADON();
            this.cryInHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryInHoaDon
            // 
            this.cryInHoaDon.ActiveViewIndex = -1;
            this.cryInHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryInHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryInHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryInHoaDon.Location = new System.Drawing.Point(0, 0);
            this.cryInHoaDon.Name = "cryInHoaDon";
            this.cryInHoaDon.Size = new System.Drawing.Size(800, 450);
            this.cryInHoaDon.TabIndex = 0;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cryInHoaDon);
            this.Name = "frmInHoaDon";
            this.Text = "InHOADON";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private cr_HOADON cr_HOADON1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer cryInHoaDon;
    }
}