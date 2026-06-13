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
            Lbl_User = new Label();
            Btn_Stok_Gudang = new Button();
            Btn_Daftar_Karyawan = new Button();
            Btn_Riwayat_Penjualan = new Button();
            Btn_Restock = new Button();
            Btn_Profil = new Button();
            SuspendLayout();
            // 
            // LblToko
            // 
            LblToko.Anchor = System.Windows.Forms.AnchorStyles.None;
            LblToko.AutoSize = true;
            LblToko.Font = new Font("Book Antiqua", 45F);
            LblToko.Location = new Point(51, 42);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(465, 92);
            LblToko.TabIndex = 0;
            LblToko.Text = "Toko Taniku";
            // 
            // Lbl_User
            // 
            Lbl_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            Lbl_User.AutoSize = true;
            Lbl_User.Font = new Font("Book Antiqua", 15F);
            Lbl_User.Location = new Point(61, 134);
            Lbl_User.Name = "Lbl_User";
            Lbl_User.Size = new Size(192, 31);
            Lbl_User.TabIndex = 1;
            Lbl_User.Text = "Selamat datang ";
            // 
            // Btn_Stok_Gudang
            // 
            Btn_Stok_Gudang.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_Stok_Gudang.BackColor = Color.SeaGreen;
            Btn_Stok_Gudang.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Stok_Gudang.Cursor = Cursors.Hand;
            Btn_Stok_Gudang.FlatStyle = FlatStyle.Flat;
            Btn_Stok_Gudang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Stok_Gudang.ForeColor = Color.White;
            Btn_Stok_Gudang.Location = new Point(61, 200);
            Btn_Stok_Gudang.Name = "Btn_Stok_Gudang";
            Btn_Stok_Gudang.Size = new Size(262, 52);
            Btn_Stok_Gudang.TabIndex = 2;
            Btn_Stok_Gudang.Text = "Stok Gudang";
            Btn_Stok_Gudang.UseVisualStyleBackColor = false;
            Btn_Stok_Gudang.Click += Btn_Stok_Gudang_Click;
            // 
            // Btn_Daftar_Karyawan
            // 
            Btn_Daftar_Karyawan.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_Daftar_Karyawan.BackColor = Color.SeaGreen;
            Btn_Daftar_Karyawan.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Daftar_Karyawan.Cursor = Cursors.Hand;
            Btn_Daftar_Karyawan.FlatStyle = FlatStyle.Flat;
            Btn_Daftar_Karyawan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Daftar_Karyawan.ForeColor = Color.White;
            Btn_Daftar_Karyawan.Location = new Point(61, 275);
            Btn_Daftar_Karyawan.Name = "Btn_Daftar_Karyawan";
            Btn_Daftar_Karyawan.Size = new Size(262, 52);
            Btn_Daftar_Karyawan.TabIndex = 3;
            Btn_Daftar_Karyawan.Text = "Daftar Karyawan";
            Btn_Daftar_Karyawan.UseVisualStyleBackColor = false;
            Btn_Daftar_Karyawan.Click += Btn_Daftar_Karyawan_Click;
            // 
            // Btn_Riwayat_Penjualan
            // 
            Btn_Riwayat_Penjualan.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_Riwayat_Penjualan.BackColor = Color.SeaGreen;
            Btn_Riwayat_Penjualan.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Riwayat_Penjualan.Cursor = Cursors.Hand;
            Btn_Riwayat_Penjualan.FlatStyle = FlatStyle.Flat;
            Btn_Riwayat_Penjualan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Riwayat_Penjualan.ForeColor = Color.White;
            Btn_Riwayat_Penjualan.Location = new Point(61, 349);
            Btn_Riwayat_Penjualan.Name = "Btn_Riwayat_Penjualan";
            Btn_Riwayat_Penjualan.Size = new Size(262, 52);
            Btn_Riwayat_Penjualan.TabIndex = 4;
            Btn_Riwayat_Penjualan.Text = "Riwayat Penjualan";
            Btn_Riwayat_Penjualan.UseVisualStyleBackColor = false;
            Btn_Riwayat_Penjualan.Click += Btn_Riwayat_Penjualan_Click;
            // 
            // Btn_Restock
            // 
            Btn_Restock.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_Restock.BackColor = Color.SeaGreen;
            Btn_Restock.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Restock.Cursor = Cursors.Hand;
            Btn_Restock.FlatStyle = FlatStyle.Flat;
            Btn_Restock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Restock.ForeColor = Color.White;
            Btn_Restock.Location = new Point(61, 422);
            Btn_Restock.Name = "Btn_Restock";
            Btn_Restock.Size = new Size(262, 52);
            Btn_Restock.TabIndex = 5;
            Btn_Restock.Text = "Restock";
            Btn_Restock.UseVisualStyleBackColor = false;
            Btn_Restock.Click += Btn_Restock_Click;
            // 
            // Btn_Profil
            // 
            Btn_Profil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Profil.BackColor = Color.SeaGreen;
            Btn_Profil.BackgroundImage = (Image)resources.GetObject("Btn_Profil.BackgroundImage");
            Btn_Profil.BackgroundImageLayout = ImageLayout.Zoom;
            Btn_Profil.Cursor = Cursors.Hand;
            Btn_Profil.FlatStyle = FlatStyle.Flat;
            Btn_Profil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Profil.ForeColor = Color.White;
            Btn_Profil.Location = new Point(1006, 25);
            Btn_Profil.Name = "Btn_Profil";
            Btn_Profil.Size = new Size(105, 98);
            Btn_Profil.TabIndex = 6;
            Btn_Profil.UseVisualStyleBackColor = false;
            Btn_Profil.Click += Btn_Profil_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1168, 568);
            Controls.Add(Btn_Profil);
            Controls.Add(Btn_Restock);
            Controls.Add(Btn_Riwayat_Penjualan);
            Controls.Add(Btn_Daftar_Karyawan);
            Controls.Add(Btn_Stok_Gudang);
            Controls.Add(Lbl_User);
            Controls.Add(LblToko);
            Font = new Font("Segoe UI", 10F);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblToko;
        private Label Lbl_User;
        private Button Btn_Stok_Gudang;
        private Button Btn_Daftar_Karyawan;
        private Button Btn_Riwayat_Penjualan;
        private Button Btn_Restock;
        private Button Btn_Profil;
    }
}





