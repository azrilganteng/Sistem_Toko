namespace Sistem_Toko.View.KurirView
{
    partial class UC_Pengiriman
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
            lblPesanan = new Label();
            lblAlamat = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblPesanan
            // 
            lblPesanan.AutoSize = true;
            lblPesanan.Location = new Point(15, 14);
            lblPesanan.Name = "lblPesanan";
            lblPesanan.Size = new Size(62, 20);
            lblPesanan.TabIndex = 0;
            lblPesanan.Text = "Pesanan";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(15, 45);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(349, 20);
            lblAlamat.TabIndex = 1;
            lblAlamat.Text = "Alamat                                                                         ";
            lblAlamat.Click += lblAlamat_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(15, 74);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // UC_Pengiriman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblStatus);
            Controls.Add(lblAlamat);
            Controls.Add(lblPesanan);
            Name = "UC_Pengiriman";
            Size = new Size(802, 105);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPesanan;
        private Label lblAlamat;
        private Label lblStatus;
    }
}
