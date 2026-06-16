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
            Btn_Profil = new Button();
            LblToko = new Label();
            Lbl_User = new Label();
            Btn_Stok_Gudang = new Button();
            Btn_Daftar_Karyawan = new Button();
            Btn_Riwayat_Penjualan = new Button();
            Btn_Restock = new Button();
            SuspendLayout();
            // 
            // Btn_Profil
            // 
            Btn_Profil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Profil.BackColor = Color.Transparent;
            Btn_Profil.BackgroundImage = Properties.Resources.background;
            Btn_Profil.Cursor = Cursors.Hand;
            Btn_Profil.FlatAppearance.BorderColor = Color.SeaGreen;
            Btn_Profil.FlatAppearance.BorderSize = 2;
            Btn_Profil.FlatStyle = FlatStyle.Flat;
            Btn_Profil.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            Btn_Profil.ForeColor = Color.SeaGreen;
            Btn_Profil.Location = new Point(1080, 20);
            Btn_Profil.Name = "Btn_Profil";
            Btn_Profil.Size = new Size(70, 70);
            Btn_Profil.TabIndex = 6;
            Btn_Profil.Text = "Profil";
            Btn_Profil.TextImageRelation = TextImageRelation.ImageAboveText;
            Btn_Profil.UseVisualStyleBackColor = false;
            Btn_Profil.Click += Btn_Profil_Click;
            // 
            // LblToko
            // 
            LblToko.BackColor = System.Drawing.Color.Transparent;
            LblToko.Font = new Font("Book Antiqua", 42F);
            LblToko.Location = new Point(40, 30);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(433, 80);
            LblToko.TabIndex = 5;
            LblToko.Text = "Toko Taniku";
            LblToko.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_User
            // 
            Lbl_User.BackColor = System.Drawing.Color.Transparent;
            Lbl_User.Font = new Font("Book Antiqua", 12F);
            Lbl_User.Location = new Point(40, 110);
            Lbl_User.Name = "Lbl_User";
            Lbl_User.Size = new Size(260, 40);
            Lbl_User.TabIndex = 4;
            Lbl_User.Text = "Selamat datang ";
            Lbl_User.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Btn_Stok_Gudang
            // 
            Btn_Stok_Gudang.BackColor = Color.SeaGreen;
            Btn_Stok_Gudang.Cursor = Cursors.Hand;
            Btn_Stok_Gudang.FlatAppearance.BorderSize = 0;
            Btn_Stok_Gudang.FlatStyle = FlatStyle.Flat;
            Btn_Stok_Gudang.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Stok_Gudang.ForeColor = Color.White;
            Btn_Stok_Gudang.Location = new Point(40, 180);
            Btn_Stok_Gudang.Margin = new Padding(0, 10, 0, 0);
            Btn_Stok_Gudang.Name = "Btn_Stok_Gudang";
            Btn_Stok_Gudang.Size = new Size(260, 60);
            Btn_Stok_Gudang.TabIndex = 3;
            Btn_Stok_Gudang.Text = "Stok Gudang";
            Btn_Stok_Gudang.UseVisualStyleBackColor = false;
            Btn_Stok_Gudang.Click += Btn_Stok_Gudang_Click;
            // 
            // Btn_Daftar_Karyawan
            // 
            Btn_Daftar_Karyawan.BackColor = Color.SeaGreen;
            Btn_Daftar_Karyawan.Cursor = Cursors.Hand;
            Btn_Daftar_Karyawan.FlatAppearance.BorderSize = 0;
            Btn_Daftar_Karyawan.FlatStyle = FlatStyle.Flat;
            Btn_Daftar_Karyawan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Daftar_Karyawan.ForeColor = Color.White;
            Btn_Daftar_Karyawan.Location = new Point(40, 260);
            Btn_Daftar_Karyawan.Margin = new Padding(0, 10, 0, 0);
            Btn_Daftar_Karyawan.Name = "Btn_Daftar_Karyawan";
            Btn_Daftar_Karyawan.Size = new Size(260, 60);
            Btn_Daftar_Karyawan.TabIndex = 2;
            Btn_Daftar_Karyawan.Text = "Daftar Karyawan";
            Btn_Daftar_Karyawan.UseVisualStyleBackColor = false;
            Btn_Daftar_Karyawan.Click += Btn_Daftar_Karyawan_Click;
            // 
            // Btn_Riwayat_Penjualan
            // 
            Btn_Riwayat_Penjualan.BackColor = Color.SeaGreen;
            Btn_Riwayat_Penjualan.Cursor = Cursors.Hand;
            Btn_Riwayat_Penjualan.FlatAppearance.BorderSize = 0;
            Btn_Riwayat_Penjualan.FlatStyle = FlatStyle.Flat;
            Btn_Riwayat_Penjualan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Riwayat_Penjualan.ForeColor = Color.White;
            Btn_Riwayat_Penjualan.Location = new Point(40, 340);
            Btn_Riwayat_Penjualan.Margin = new Padding(0, 10, 0, 0);
            Btn_Riwayat_Penjualan.Name = "Btn_Riwayat_Penjualan";
            Btn_Riwayat_Penjualan.Size = new Size(260, 60);
            Btn_Riwayat_Penjualan.TabIndex = 1;
            Btn_Riwayat_Penjualan.Text = "Riwayat Penjualan";
            Btn_Riwayat_Penjualan.UseVisualStyleBackColor = false;
            Btn_Riwayat_Penjualan.Click += Btn_Riwayat_Penjualan_Click;
            // 
            // Btn_Restock
            // 
            Btn_Restock.BackColor = Color.SeaGreen;
            Btn_Restock.Cursor = Cursors.Hand;
            Btn_Restock.FlatAppearance.BorderSize = 0;
            Btn_Restock.FlatStyle = FlatStyle.Flat;
            Btn_Restock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Restock.ForeColor = Color.White;
            Btn_Restock.Location = new Point(40, 420);
            Btn_Restock.Margin = new Padding(0, 10, 0, 0);
            Btn_Restock.Name = "Btn_Restock";
            Btn_Restock.Size = new Size(260, 60);
            Btn_Restock.TabIndex = 0;
            Btn_Restock.Text = "Restock";
            Btn_Restock.UseVisualStyleBackColor = false;
            Btn_Restock.Click += Btn_Restock_Click;

            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1168, 600);
            Controls.Add(Btn_Profil);
            Controls.Add(Btn_Restock);
            Controls.Add(Btn_Riwayat_Penjualan);
            Controls.Add(Btn_Daftar_Karyawan);
            Controls.Add(Btn_Stok_Gudang);
            Controls.Add(Lbl_User);
            Controls.Add(LblToko);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10F);
            Name = "AdminForm";
            Text = "AdminForm";
            WindowState = FormWindowState.Maximized;
            Load += AdminForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button Btn_Profil;
        private Label LblToko;
        private Label Lbl_User;
        private Button Btn_Stok_Gudang;
        private Button Btn_Daftar_Karyawan;
        private Button Btn_Riwayat_Penjualan;
        private Button Btn_Restock;
    }
}
