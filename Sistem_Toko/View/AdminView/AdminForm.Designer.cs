namespace Sistem_Toko
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            LblToko = new Label();
            label1 = new Label();
            Btn_Stok_Gudang = new Button();
            Btn_Daftar_Karyawan = new Button();
            Btn_Riwayat_Penjualan = new Button();
            Btn_Restock = new Button();
            Btn_Profil = new Button();
            SuspendLayout();
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.Font = new Font("Book Antiqua", 26F);
            LblToko.Location = new Point(51, 42);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(272, 54);
            LblToko.TabIndex = 0;
            LblToko.Text = "Toko Taniku";
            LblToko.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 15F);
            label1.Location = new Point(61, 109);
            label1.Name = "label1";
            label1.Size = new Size(192, 31);
            label1.TabIndex = 1;
            label1.Text = "Selamat datang ";
            label1.Click += label1_Click_1;
            // 
            // Btn_Stok_Gudang
            // 
            Btn_Stok_Gudang.BackgroundImage = (Image)resources.GetObject("Btn_Stok_Gudang.BackgroundImage");
            Btn_Stok_Gudang.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Stok_Gudang.Font = new Font("Book Antiqua", 10F);
            Btn_Stok_Gudang.Location = new Point(61, 183);
            Btn_Stok_Gudang.Name = "Btn_Stok_Gudang";
            Btn_Stok_Gudang.Size = new Size(192, 52);
            Btn_Stok_Gudang.TabIndex = 2;
            Btn_Stok_Gudang.Text = "Stok Gudang";
            Btn_Stok_Gudang.UseVisualStyleBackColor = true;
            // 
            // Btn_Daftar_Karyawan
            // 
            Btn_Daftar_Karyawan.BackgroundImage = (Image)resources.GetObject("Btn_Daftar_Karyawan.BackgroundImage");
            Btn_Daftar_Karyawan.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Daftar_Karyawan.Font = new Font("Book Antiqua", 10F);
            Btn_Daftar_Karyawan.Location = new Point(61, 241);
            Btn_Daftar_Karyawan.Name = "Btn_Daftar_Karyawan";
            Btn_Daftar_Karyawan.Size = new Size(192, 52);
            Btn_Daftar_Karyawan.TabIndex = 3;
            Btn_Daftar_Karyawan.Text = "Daftar Karyawan";
            Btn_Daftar_Karyawan.UseVisualStyleBackColor = true;
            // 
            // Btn_Riwayat_Penjualan
            // 
            Btn_Riwayat_Penjualan.BackgroundImage = (Image)resources.GetObject("Btn_Riwayat_Penjualan.BackgroundImage");
            Btn_Riwayat_Penjualan.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Riwayat_Penjualan.Font = new Font("Book Antiqua", 10F);
            Btn_Riwayat_Penjualan.Location = new Point(61, 299);
            Btn_Riwayat_Penjualan.Name = "Btn_Riwayat_Penjualan";
            Btn_Riwayat_Penjualan.Size = new Size(192, 52);
            Btn_Riwayat_Penjualan.TabIndex = 4;
            Btn_Riwayat_Penjualan.Text = "Riwayat Penjualan";
            Btn_Riwayat_Penjualan.UseVisualStyleBackColor = true;
            // 
            // Btn_Restock
            // 
            Btn_Restock.BackColor = Color.Transparent;
            Btn_Restock.BackgroundImage = (Image)resources.GetObject("Btn_Restock.BackgroundImage");
            Btn_Restock.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Restock.Font = new Font("Book Antiqua", 10F);
            Btn_Restock.Location = new Point(61, 357);
            Btn_Restock.Name = "Btn_Restock";
            Btn_Restock.Size = new Size(192, 52);
            Btn_Restock.TabIndex = 5;
            Btn_Restock.Text = "Restock";
            Btn_Restock.UseVisualStyleBackColor = false;
            // 
            // Btn_Profil
            // 
            Btn_Profil.BackColor = Color.Transparent;
            Btn_Profil.BackgroundImage = (Image)resources.GetObject("Btn_Profil.BackgroundImage");
            Btn_Profil.BackgroundImageLayout = ImageLayout.Zoom;
            Btn_Profil.ForeColor = Color.Transparent;
            Btn_Profil.Location = new Point(640, 42);
            Btn_Profil.Name = "Btn_Profil";
            Btn_Profil.Size = new Size(105, 98);
            Btn_Profil.TabIndex = 6;
            Btn_Profil.UseVisualStyleBackColor = false;
            Btn_Profil.Click += button5_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Profil);
            Controls.Add(Btn_Restock);
            Controls.Add(Btn_Riwayat_Penjualan);
            Controls.Add(Btn_Daftar_Karyawan);
            Controls.Add(Btn_Stok_Gudang);
            Controls.Add(label1);
            Controls.Add(LblToko);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblToko;
        private Label label1;
        private Button Btn_Stok_Gudang;
        private Button Btn_Daftar_Karyawan;
        private Button Btn_Riwayat_Penjualan;
        private Button Btn_Restock;
        private Button Btn_Profil;
    }
}