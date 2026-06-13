namespace Sistem_Toko
{
    partial class UC_Produk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Produk));
            Gambar = new PictureBox();
            LblProduk = new Label();
            KeranjangBtn = new Button();
            BuyNowBtn = new Button();
            LblHarga = new Label();
            LblStok = new Label();
            ((System.ComponentModel.ISupportInitialize)Gambar).BeginInit();
            SuspendLayout();
            // 
            // Gambar
            // 
            Gambar.Location = new Point(0, 0);
            Gambar.Name = "Gambar";
            Gambar.Size = new Size(259, 135);
            Gambar.SizeMode = PictureBoxSizeMode.StretchImage;
            Gambar.TabIndex = 0;
            Gambar.TabStop = false;
            // 
            // LblProduk
            // 
            LblProduk.AutoSize = true;
            LblProduk.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LblProduk.Location = new Point(5, 138);
            LblProduk.MaximumSize = new Size(250, 0);
            LblProduk.Name = "LblProduk";
            LblProduk.Size = new Size(143, 25);
            LblProduk.TabIndex = 1;
            LblProduk.Text = "Produk Name";
            // 
            // KeranjangBtn
            // 
            KeranjangBtn.BackColor = Color.SeaGreen;
            KeranjangBtn.Cursor = Cursors.Hand;
            KeranjangBtn.FlatAppearance.BorderSize = 0;
            KeranjangBtn.FlatStyle = FlatStyle.Flat;
            KeranjangBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            KeranjangBtn.ForeColor = Color.White;
            KeranjangBtn.Location = new Point(12, 205);
            KeranjangBtn.Name = "KeranjangBtn";
            KeranjangBtn.Size = new Size(110, 40);
            KeranjangBtn.TabIndex = 2;
            KeranjangBtn.Text = "+ Keranjang";
            KeranjangBtn.UseVisualStyleBackColor = false;
            KeranjangBtn.Click += KeranjangBtn_Click;
            // 
            // BuyNowBtn
            // 
            BuyNowBtn.BackColor = Color.DarkOrange;
            BuyNowBtn.Cursor = Cursors.Hand;
            BuyNowBtn.FlatAppearance.BorderSize = 0;
            BuyNowBtn.FlatStyle = FlatStyle.Flat;
            BuyNowBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuyNowBtn.ForeColor = Color.White;
            BuyNowBtn.Location = new Point(135, 205);
            BuyNowBtn.Name = "BuyNowBtn";
            BuyNowBtn.Size = new Size(110, 40);
            BuyNowBtn.TabIndex = 3;
            BuyNowBtn.Text = "Beli Langsung";
            BuyNowBtn.UseVisualStyleBackColor = false;
            BuyNowBtn.Click += BuyNowBtn_Click;
            // 
            // LblHarga
            // 
            LblHarga.AutoSize = true;
            LblHarga.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblHarga.ForeColor = Color.SeaGreen;
            LblHarga.Location = new Point(5, 170);
            LblHarga.Name = "LblHarga";
            LblHarga.Size = new Size(41, 23);
            LblHarga.TabIndex = 4;
            LblHarga.Text = "Price";
            // 
            // LblStok
            // 
            LblStok.AutoSize = true;
            LblStok.Font = new Font("Segoe UI", 9F);
            LblStok.ForeColor = Color.Gray;
            LblStok.Location = new Point(5, 190);
            LblStok.Name = "LblStok";
            LblStok.Size = new Size(38, 20);
            LblStok.TabIndex = 5;
            LblStok.Text = "Stok";
            // 
            // UC_Produk
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(LblStok);
            Controls.Add(LblHarga);
            Controls.Add(BuyNowBtn);
            Controls.Add(KeranjangBtn);
            Controls.Add(LblProduk);
            Controls.Add(Gambar);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10F);
            Name = "UC_Produk";
            Size = new Size(259, 261);
            ((System.ComponentModel.ISupportInitialize)Gambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Gambar;
        private Label LblProduk;
        private Button KeranjangBtn;
        private Button BuyNowBtn;
        private Label LblHarga;
        private Label LblStok;
    }
}





