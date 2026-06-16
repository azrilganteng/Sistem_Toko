namespace Sistem_Toko.View.KurirView
{
    partial class UC_Pengiriman
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblPesanan = new Label();
            lblAlamat = new Label();
            SelesaiBtn = new Button();
            lblAlamatHeader = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblPesanan
            // 
            lblPesanan.AutoSize = true;
            lblPesanan.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPesanan.ForeColor = Color.SeaGreen;
            lblPesanan.Location = new Point(20, 15);
            lblPesanan.Name = "lblPesanan";
            lblPesanan.Size = new Size(130, 30);
            lblPesanan.TabIndex = 0;
            lblPesanan.Text = "Pesanan #1";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.DarkOrange;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(20, 50);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(8, 3, 8, 3);
            lblStatus.Size = new Size(70, 26);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Proses";
            // 
            // lblAlamatHeader
            // 
            lblAlamatHeader.AutoSize = true;
            lblAlamatHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAlamatHeader.ForeColor = Color.Gray;
            lblAlamatHeader.Location = new Point(20, 85);
            lblAlamatHeader.Name = "lblAlamatHeader";
            lblAlamatHeader.Size = new Size(110, 20);
            lblAlamatHeader.TabIndex = 4;
            lblAlamatHeader.Text = "Alamat Tujuan:";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Font = new Font("Segoe UI", 11F);
            lblAlamat.ForeColor = Color.FromArgb(51, 51, 51);
            lblAlamat.Location = new Point(20, 108);
            lblAlamat.MaximumSize = new Size(500, 0);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(200, 25);
            lblAlamat.TabIndex = 1;
            lblAlamat.Text = "Alamat pengiriman";
            // 
            // SelesaiBtn
            // 
            SelesaiBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SelesaiBtn.BackColor = Color.SeaGreen;
            SelesaiBtn.Cursor = Cursors.Hand;
            SelesaiBtn.FlatAppearance.BorderSize = 0;
            SelesaiBtn.FlatStyle = FlatStyle.Flat;
            SelesaiBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            SelesaiBtn.ForeColor = Color.White;
            SelesaiBtn.Location = new Point(630, 50);
            SelesaiBtn.Name = "SelesaiBtn";
            SelesaiBtn.Size = new Size(140, 45);
            SelesaiBtn.TabIndex = 2;
            SelesaiBtn.Text = "Selesai";
            SelesaiBtn.UseVisualStyleBackColor = false;
            SelesaiBtn.Click += SelesaiBtn_Click;
            // 
            // UC_Pengiriman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(SelesaiBtn);
            Controls.Add(lblAlamatHeader);
            Controls.Add(lblAlamat);
            Controls.Add(lblStatus);
            Controls.Add(lblPesanan);
            Cursor = Cursors.Hand;
            Name = "UC_Pengiriman";
            Size = new Size(790, 150);
            Load += UC_Pengiriman_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPesanan;
        private Label lblAlamat;
        private Button SelesaiBtn;
        private Label lblAlamatHeader;
        private Label lblStatus;
    }
}
