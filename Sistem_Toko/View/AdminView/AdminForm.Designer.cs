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
            components = new System.ComponentModel.Container();
            LblToko = new Label();
            Lbl_User = new Label();
            Btn_Stok_Gudang = new Button();
            Btn_Daftar_Karyawan = new Button();
            Btn_Riwayat_Penjualan = new Button();
            Btn_Restock = new Button();
            Btn_Profil = new Button();
            Panel_Sidebar = new Panel();
            Panel_Sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Sidebar
            // 
            Panel_Sidebar.Dock = DockStyle.Left;
            Panel_Sidebar.BackColor = Color.WhiteSmoke;
            Panel_Sidebar.Width = 340;
            Panel_Sidebar.Padding = new Padding(40, 30, 40, 30);
            Panel_Sidebar.Controls.Add(Btn_Restock);
            Panel_Sidebar.Controls.Add(Btn_Riwayat_Penjualan);
            Panel_Sidebar.Controls.Add(Btn_Daftar_Karyawan);
            Panel_Sidebar.Controls.Add(Btn_Stok_Gudang);
            Panel_Sidebar.Controls.Add(Lbl_User);
            Panel_Sidebar.Controls.Add(LblToko);
            // 
            // LblToko
            // 
            LblToko.Dock = DockStyle.Top;
            LblToko.AutoSize = false;
            LblToko.Height = 80;
            LblToko.Font = new Font("Book Antiqua", 28F, FontStyle.Bold);
            LblToko.TextAlign = ContentAlignment.MiddleLeft;
            LblToko.Text = "Toko Taniku";
            // 
            // Lbl_User
            // 
            Lbl_User.Dock = DockStyle.Top;
            Lbl_User.AutoSize = false;
            Lbl_User.Height = 40;
            Lbl_User.Font = new Font("Book Antiqua", 12F);
            Lbl_User.TextAlign = ContentAlignment.MiddleLeft;
            Lbl_User.Text = "Selamat datang ";
            // 
            // Btn_Stok_Gudang
            // 
            Btn_Stok_Gudang.Dock = DockStyle.Top;
            Btn_Stok_Gudang.Height = 60;
            Btn_Stok_Gudang.Margin = new Padding(0, 10, 0, 0);
            Btn_Stok_Gudang.BackColor = Color.SeaGreen;
            Btn_Stok_Gudang.Cursor = Cursors.Hand;
            Btn_Stok_Gudang.FlatStyle = FlatStyle.Flat;
            Btn_Stok_Gudang.FlatAppearance.BorderSize = 0;
            Btn_Stok_Gudang.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Stok_Gudang.ForeColor = Color.White;
            Btn_Stok_Gudang.Text = "Stok Gudang";
            Btn_Stok_Gudang.UseVisualStyleBackColor = false;
            Btn_Stok_Gudang.Click += Btn_Stok_Gudang_Click;
            // 
            // Btn_Daftar_Karyawan
            // 
            Btn_Daftar_Karyawan.Dock = DockStyle.Top;
            Btn_Daftar_Karyawan.Height = 60;
            Btn_Daftar_Karyawan.Margin = new Padding(0, 10, 0, 0);
            Btn_Daftar_Karyawan.BackColor = Color.SeaGreen;
            Btn_Daftar_Karyawan.Cursor = Cursors.Hand;
            Btn_Daftar_Karyawan.FlatStyle = FlatStyle.Flat;
            Btn_Daftar_Karyawan.FlatAppearance.BorderSize = 0;
            Btn_Daftar_Karyawan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Daftar_Karyawan.ForeColor = Color.White;
            Btn_Daftar_Karyawan.Text = "Daftar Karyawan";
            Btn_Daftar_Karyawan.UseVisualStyleBackColor = false;
            Btn_Daftar_Karyawan.Click += Btn_Daftar_Karyawan_Click;
            // 
            // Btn_Riwayat_Penjualan
            // 
            Btn_Riwayat_Penjualan.Dock = DockStyle.Top;
            Btn_Riwayat_Penjualan.Height = 60;
            Btn_Riwayat_Penjualan.Margin = new Padding(0, 10, 0, 0);
            Btn_Riwayat_Penjualan.BackColor = Color.SeaGreen;
            Btn_Riwayat_Penjualan.Cursor = Cursors.Hand;
            Btn_Riwayat_Penjualan.FlatStyle = FlatStyle.Flat;
            Btn_Riwayat_Penjualan.FlatAppearance.BorderSize = 0;
            Btn_Riwayat_Penjualan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Riwayat_Penjualan.ForeColor = Color.White;
            Btn_Riwayat_Penjualan.Text = "Riwayat Penjualan";
            Btn_Riwayat_Penjualan.UseVisualStyleBackColor = false;
            Btn_Riwayat_Penjualan.Click += Btn_Riwayat_Penjualan_Click;
            // 
            // Btn_Restock
            // 
            Btn_Restock.Dock = DockStyle.Top;
            Btn_Restock.Height = 60;
            Btn_Restock.Margin = new Padding(0, 10, 0, 0);
            Btn_Restock.BackColor = Color.SeaGreen;
            Btn_Restock.Cursor = Cursors.Hand;
            Btn_Restock.FlatStyle = FlatStyle.Flat;
            Btn_Restock.FlatAppearance.BorderSize = 0;
            Btn_Restock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Restock.ForeColor = Color.White;
            Btn_Restock.Text = "Restock";
            Btn_Restock.UseVisualStyleBackColor = false;
            Btn_Restock.Click += Btn_Restock_Click;
            // 
            // Btn_Profil
            // 
            Btn_Profil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Profil.BackColor = Color.White;
            Btn_Profil.Cursor = Cursors.Hand;
            Btn_Profil.FlatStyle = FlatStyle.Flat;
            Btn_Profil.FlatAppearance.BorderColor = Color.SeaGreen;
            Btn_Profil.FlatAppearance.BorderSize = 2;
            Btn_Profil.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            Btn_Profil.ForeColor = Color.SeaGreen;
            Btn_Profil.Location = new Point(1080, 20);
            Btn_Profil.Name = "Btn_Profil";
            Btn_Profil.Size = new Size(70, 70);
            Btn_Profil.TabIndex = 6;
            Btn_Profil.Text = "Profil";
            Btn_Profil.TextImageRelation = TextImageRelation.ImageAboveText;
            Btn_Profil.ImageAlign = ContentAlignment.MiddleCenter;
            Btn_Profil.UseVisualStyleBackColor = false;
            Btn_Profil.Click += Btn_Profil_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1168, 600);
            WindowState = FormWindowState.Maximized;
            Controls.Add(Btn_Profil);
            Controls.Add(Panel_Sidebar);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10F);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            Panel_Sidebar.ResumeLayout(false);
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
        private Panel Panel_Sidebar;
    }
}
