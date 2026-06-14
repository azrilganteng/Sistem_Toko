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
            ItemKeranjang = new Label();
            HargaKeranjang = new Label();
            lblQty = new Label();
            pictureBox1 = new PictureBox();
            PlusQty = new Button();
            BatalBtn = new Button();
            label1 = new Label();
            LblTotal = new Label();
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
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQty.Location = new Point(231, 107);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(23, 28);
            lblQty.TabIndex = 2;
            lblQty.Text = "1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 121);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // PlusQty
            // 
            PlusQty.BackColor = Color.Transparent;
            PlusQty.BackgroundImage = (Image)resources.GetObject("PlusQty.BackgroundImage");
            PlusQty.BackgroundImageLayout = ImageLayout.Stretch;
            PlusQty.Cursor = Cursors.Hand;
            PlusQty.FlatStyle = FlatStyle.Flat;
            PlusQty.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            PlusQty.ForeColor = Color.White;
            PlusQty.Location = new Point(276, 107);
            PlusQty.Name = "PlusQty";
            PlusQty.Size = new Size(47, 38);
            PlusQty.TabIndex = 4;
            PlusQty.UseVisualStyleBackColor = false;
            PlusQty.Click += PlusQty_Click;
            // 
            // BatalBtn
            // 
            BatalBtn.BackColor = Color.Transparent;
            BatalBtn.BackgroundImage = (Image)resources.GetObject("BatalBtn.BackgroundImage");
            BatalBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BatalBtn.Cursor = Cursors.Hand;
            BatalBtn.FlatStyle = FlatStyle.Flat;
            BatalBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BatalBtn.ForeColor = Color.White;
            BatalBtn.Location = new Point(618, 27);
            BatalBtn.Name = "BatalBtn";
            BatalBtn.Size = new Size(109, 93);
            BatalBtn.TabIndex = 5;
            BatalBtn.UseVisualStyleBackColor = false;
            BatalBtn.Click += BatalBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(436, 63);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 6;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTotal.Location = new Point(442, 66);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(0, 28);
            LblTotal.TabIndex = 7;
            // 
            // UC_ProdukKeranjang
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(LblTotal);
            Controls.Add(label1);
            Controls.Add(BatalBtn);
            Controls.Add(PlusQty);
            Controls.Add(pictureBox1);
            Controls.Add(lblQty);
            Controls.Add(HargaKeranjang);
            Controls.Add(ItemKeranjang);
            Font = new Font("Segoe UI", 10F);
            Name = "UC_ProdukKeranjang";
            Size = new Size(750, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ItemKeranjang;
        private Label HargaKeranjang;
        private Label lblQty;
        private PictureBox pictureBox1;
        private Button PlusQty;
        private Button BatalBtn;
        private Label label1;
        private Label LblTotal;
    }
}


