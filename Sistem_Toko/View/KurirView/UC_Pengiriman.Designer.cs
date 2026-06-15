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
            SelesaiBtn = new Button();
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
            lblAlamat.Location = new Point(15, 55);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(349, 20);
            lblAlamat.TabIndex = 1;
            lblAlamat.Text = "Alamat                                                                         ";
            // 
            // SelesaiBtn
            // 
            SelesaiBtn.Location = new Point(675, 37);
            SelesaiBtn.Name = "SelesaiBtn";
            SelesaiBtn.Size = new Size(94, 29);
            SelesaiBtn.TabIndex = 2;
            SelesaiBtn.Text = "button1";
            SelesaiBtn.UseVisualStyleBackColor = true;
            SelesaiBtn.Click += SelesaiBtn_Click;
            // 
            // UC_Pengiriman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(SelesaiBtn);
            Controls.Add(lblAlamat);
            Controls.Add(lblPesanan);
            Name = "UC_Pengiriman";
            Size = new Size(802, 105);
            Load += UC_Pengiriman_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPesanan;
        private Label lblAlamat;
        private Button SelesaiBtn;
    }
}
