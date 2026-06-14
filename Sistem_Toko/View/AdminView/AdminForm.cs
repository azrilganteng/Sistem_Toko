using Sistem_Toko.Helpers;
using Sistem_Toko.Model;
using Sistem_Toko.Model;
using Sistem_Toko.View;
using Sistem_Toko.View.AdminView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistem_Toko
{
    public partial class AdminForm : Form
    {
        private Admin? _admin;

        // Constructor default (untuk Designer)
        public AdminForm()
        {
            InitializeComponent();
        }

        // Constructor utama yang menerima data Admin
        public AdminForm(Admin admin)
        {
            InitializeComponent();
            _admin = admin;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Tampilkan nama user yang sedang aktif
            if (_admin != null)
            {
                Lbl_User.Text = "Selamat datang, " + _admin.Nama + "!";
            }
        }

        private void Btn_Stok_Gudang_Click(object sender, EventArgs e)
        {
            StokGudang formStokGudang = new StokGudang();
            this.Hide();
            formStokGudang.ShowDialog();
            this.Show();
        }

        private void Btn_Daftar_Karyawan_Click(object sender, EventArgs e)
        {
            DaftarKaryawan formDaftarKaryawan = new DaftarKaryawan();
            this.Hide();
            formDaftarKaryawan.ShowDialog();
            this.Show();
        }

        private void Btn_Riwayat_Penjualan_Click(object sender, EventArgs e)
        {
            Riwayat_Stok formRiwayatPenjualan = new Riwayat_Stok();
            this.Hide();
            formRiwayatPenjualan.ShowDialog();
            this.Show();
        }

        private void Btn_Restock_Click(object sender, EventArgs e)
        {
            Restock formRestock = new Restock();
            this.Hide();
            formRestock.ShowDialog();
            this.Show();
        }

        private void Btn_Profil_Click(object sender, EventArgs e)
        {

            contextMenuStrip1.Show(Btn_Profil, new Point(-90, Btn_Profil.Height));

        }

        private void profilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Sistem_Toko.View.FormProfil halamanProfil = new Sistem_Toko.View.FormProfil();
            halamanProfil.ShowDialog();
            this.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                SessionUser.Id = 0;
                SessionUser.Nama = "";
                SessionUser.Username = "";

                Login halamanLogin = new Login();
                halamanLogin.Show();

                this.Hide();
            }
        }
    }
}