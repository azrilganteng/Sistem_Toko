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
            NumQty = new NumericUpDown();
            pictureBox1 = new PictureBox();
            UpdateBtn = new Button();
            BatalBtn = new Button();
            LblSubtotal = new Label();
            ((System.ComponentModel.ISupportInitialize)NumQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ItemKeranjang
            // 
            ItemKeranjang.AutoSize = true;
            ItemKeranjang.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            ItemKeranjang.Location = new Point(195, 15);
            ItemKeranjang.Name = "ItemKeranjang";
            ItemKeranjang.BackColor = System.Drawing.Color.Transparent;
            ItemKeranjang.Size = new Size(92, 30);
            ItemKeranjang.TabIndex = 0;
            ItemKeranjang.Text = "Produk";
            // 
            // HargaKeranjang
            // 
            HargaKeranjang.AutoSize = true;
            HargaKeranjang.Font = new Font("Segoe UI", 11F);
            HargaKeranjang.ForeColor = Color.Gray;
            HargaKeranjang.Location = new Point(195, 50);
            HargaKeranjang.Name = "HargaKeranjang";
            HargaKeranjang.BackColor = System.Drawing.Color.Transparent;
            HargaKeranjang.Size = new Size(65, 25);
            HargaKeranjang.TabIndex = 1;
            HargaKeranjang.Text = "Harga";
            // 
            // NumQty
            // 
            NumQty.Font = new Font("Segoe UI", 11F);
            NumQty.Location = new Point(195, 90);
            NumQty.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            NumQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumQty.Name = "NumQty";
            NumQty.Size = new Size(70, 32);
            NumQty.TabIndex = 2;
            NumQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(15, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.SeaGreen;
            UpdateBtn.Cursor = Cursors.Hand;
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(290, 88);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(100, 35);
            UpdateBtn.TabIndex = 4;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            //UpdateBtn.Click += UpdateBtn_Click;
            // 
            // BatalBtn
            // 
            BatalBtn.BackColor = Color.Crimson;
            BatalBtn.Cursor = Cursors.Hand;
            BatalBtn.FlatAppearance.BorderSize = 0;
            BatalBtn.FlatStyle = FlatStyle.Flat;
            BatalBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BatalBtn.ForeColor = Color.White;
            BatalBtn.Location = new Point(630, 40);
            BatalBtn.Name = "BatalBtn";
            BatalBtn.Size = new Size(100, 55);
            BatalBtn.TabIndex = 5;
            BatalBtn.Text = "Hapus";
            BatalBtn.UseVisualStyleBackColor = false;
            BatalBtn.Click += BatalBtn_Click;
            // 
            // LblSubtotal
            // 
            LblSubtotal.AutoSize = true;
            LblSubtotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblSubtotal.ForeColor = Color.SeaGreen;
            LblSubtotal.Location = new Point(420, 50);
            LblSubtotal.Name = "LblSubtotal";
            LblSubtotal.BackColor = System.Drawing.Color.Transparent;
            LblSubtotal.Size = new Size(65, 23);
            LblSubtotal.TabIndex = 6;
            LblSubtotal.Text = "Subtotal";
            // 
            // UC_ProdukKeranjang
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(LblSubtotal);
            Controls.Add(BatalBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(pictureBox1);
            Controls.Add(NumQty);
            Controls.Add(HargaKeranjang);
            Controls.Add(ItemKeranjang);
            Font = new Font("Segoe UI", 10F);
            Name = "UC_ProdukKeranjang";
            Size = new Size(750, 140);
            ((System.ComponentModel.ISupportInitialize)NumQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ItemKeranjang;
        private Label HargaKeranjang;
        private NumericUpDown NumQty;
        private PictureBox pictureBox1;
        private Button UpdateBtn;
        private Button BatalBtn;
        private Label LblSubtotal;
    }
}