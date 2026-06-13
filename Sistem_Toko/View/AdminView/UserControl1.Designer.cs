namespace Sistem_Toko.View.AdminView
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            LblStok = new Label();
            LblHarga = new Label();
            LblProduk = new Label();
            Gambar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Gambar).BeginInit();
            SuspendLayout();
            // 
            // LblStok
            // 
            LblStok.AutoSize = true;
            LblStok.BackColor = Color.Transparent;
            LblStok.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblStok.Location = new Point(201, 177);
            LblStok.Name = "LblStok";
            LblStok.Size = new Size(38, 20);
            LblStok.TabIndex = 11;
            LblStok.Text = "Stok";
            // 
            // LblHarga
            // 
            LblHarga.AutoSize = true;
            LblHarga.BackColor = Color.Transparent;
            LblHarga.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblHarga.Location = new Point(12, 177);
            LblHarga.Name = "LblHarga";
            LblHarga.Size = new Size(41, 20);
            LblHarga.TabIndex = 10;
            LblHarga.Text = "Price";
            // 
            // LblProduk
            // 
            LblProduk.AutoSize = true;
            LblProduk.BackColor = Color.Transparent;
            LblProduk.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblProduk.Location = new Point(12, 141);
            LblProduk.Name = "LblProduk";
            LblProduk.Size = new Size(143, 27);
            LblProduk.TabIndex = 7;
            LblProduk.Text = "Produk Name";
            // 
            // Gambar
            // 
            Gambar.BackColor = Color.Transparent;
            Gambar.Location = new Point(9, 3);
            Gambar.Name = "Gambar";
            Gambar.Size = new Size(259, 135);
            Gambar.TabIndex = 6;
            Gambar.TabStop = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(LblStok);
            Controls.Add(LblHarga);
            Controls.Add(LblProduk);
            Controls.Add(Gambar);
            DoubleBuffered = true;
            Name = "UserControl1";
            Size = new Size(277, 255);
            ((System.ComponentModel.ISupportInitialize)Gambar).EndInit();
            // INJECTED_MANUAL_UI
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblStok;
        private Label LblHarga;
        private Label LblProduk;
        private PictureBox Gambar;
    }
}





