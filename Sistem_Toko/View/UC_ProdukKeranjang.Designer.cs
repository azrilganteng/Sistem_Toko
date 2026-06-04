namespace Sistem_Toko
{
    partial class UC_ProdukKeranjang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ProdukKeranjang));
            ProdGambarKeranjang = new PictureBox();
            ProdNamaKeranjang = new Label();
            HargaKeranjang = new Label();
            QtyKeranjang = new Label();
            plusQty = new Button();
            BatalKeranjang = new Button();
            ((System.ComponentModel.ISupportInitialize)ProdGambarKeranjang).BeginInit();
            SuspendLayout();
            // 
            // ProdGambarKeranjang
            // 
            ProdGambarKeranjang.Location = new Point(19, 16);
            ProdGambarKeranjang.Name = "ProdGambarKeranjang";
            ProdGambarKeranjang.Size = new Size(145, 90);
            ProdGambarKeranjang.TabIndex = 1;
            ProdGambarKeranjang.TabStop = false;
            // 
            // ProdNamaKeranjang
            // 
            ProdNamaKeranjang.AutoSize = true;
            ProdNamaKeranjang.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProdNamaKeranjang.Location = new Point(170, 0);
            ProdNamaKeranjang.Name = "ProdNamaKeranjang";
            ProdNamaKeranjang.Size = new Size(198, 38);
            ProdNamaKeranjang.TabIndex = 2;
            ProdNamaKeranjang.Text = "Nama Produk";
            // 
            // HargaKeranjang
            // 
            HargaKeranjang.AutoSize = true;
            HargaKeranjang.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HargaKeranjang.Location = new Point(179, 38);
            HargaKeranjang.Name = "HargaKeranjang";
            HargaKeranjang.Size = new Size(57, 25);
            HargaKeranjang.TabIndex = 3;
            HargaKeranjang.Text = "harga";
            // 
            // QtyKeranjang
            // 
            QtyKeranjang.AutoSize = true;
            QtyKeranjang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QtyKeranjang.Location = new Point(191, 75);
            QtyKeranjang.Name = "QtyKeranjang";
            QtyKeranjang.Size = new Size(23, 28);
            QtyKeranjang.TabIndex = 4;
            QtyKeranjang.Text = "1";
            // 
            // plusQty
            // 
            plusQty.BackColor = Color.Transparent;
            plusQty.BackgroundImage = (Image)resources.GetObject("plusQty.BackgroundImage");
            plusQty.BackgroundImageLayout = ImageLayout.Stretch;
            plusQty.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plusQty.Location = new Point(243, 65);
            plusQty.Name = "plusQty";
            plusQty.Size = new Size(42, 41);
            plusQty.TabIndex = 5;
            plusQty.UseVisualStyleBackColor = false;
            // 
            // BatalKeranjang
            // 
            BatalKeranjang.BackColor = Color.IndianRed;
            BatalKeranjang.BackgroundImage = (Image)resources.GetObject("BatalKeranjang.BackgroundImage");
            BatalKeranjang.BackgroundImageLayout = ImageLayout.Stretch;
            BatalKeranjang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BatalKeranjang.Location = new Point(452, 16);
            BatalKeranjang.Name = "BatalKeranjang";
            BatalKeranjang.Size = new Size(101, 87);
            BatalKeranjang.TabIndex = 6;
            BatalKeranjang.UseVisualStyleBackColor = false;
            BatalKeranjang.Click += BatalKeranjang_Click;
            // 
            // UC_ProdukKeranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(BatalKeranjang);
            Controls.Add(plusQty);
            Controls.Add(QtyKeranjang);
            Controls.Add(HargaKeranjang);
            Controls.Add(ProdNamaKeranjang);
            Controls.Add(ProdGambarKeranjang);
            Name = "UC_ProdukKeranjang";
            Size = new Size(572, 122);
            ((System.ComponentModel.ISupportInitialize)ProdGambarKeranjang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ProdGambarKeranjang;
        private Label ProdNamaKeranjang;
        private Label HargaKeranjang;
        private Label QtyKeranjang;
        private Button plusQty;
        private Button BatalKeranjang;
    }
}
