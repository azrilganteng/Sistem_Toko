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
            ItemKeranjang = new Label();
            HargaKeranjang = new Label();
            Qty = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ItemKeranjang
            // 
            ItemKeranjang.AutoSize = true;
            ItemKeranjang.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemKeranjang.Location = new Point(231, 22);
            ItemKeranjang.Name = "ItemKeranjang";
            ItemKeranjang.Size = new Size(92, 31);
            ItemKeranjang.TabIndex = 0;
            ItemKeranjang.Text = "Produk";
            // 
            // HargaKeranjang
            // 
            HargaKeranjang.AutoSize = true;
            HargaKeranjang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HargaKeranjang.Location = new Point(231, 63);
            HargaKeranjang.Name = "HargaKeranjang";
            HargaKeranjang.Size = new Size(65, 28);
            HargaKeranjang.TabIndex = 1;
            HargaKeranjang.Text = "Harga";
            // 
            // Qty
            // 
            Qty.AutoSize = true;
            Qty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Qty.Location = new Point(231, 109);
            Qty.Name = "Qty";
            Qty.Size = new Size(23, 28);
            Qty.TabIndex = 2;
            Qty.Text = "1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 121);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // UC_ProdukKeranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(Qty);
            Controls.Add(HargaKeranjang);
            Controls.Add(ItemKeranjang);
            Name = "UC_ProdukKeranjang";
            Size = new Size(750, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ItemKeranjang;
        private Label HargaKeranjang;
        private Label Qty;
        private PictureBox pictureBox1;
    }
}
