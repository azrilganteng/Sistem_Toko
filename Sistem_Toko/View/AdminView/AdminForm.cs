using Sistem_Toko.Model;
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
            formStokGudang.Show();
        }

        private void Btn_Daftar_Karyawan_Click(object sender, EventArgs e)
        {
            DaftarKaryawan formDaftarKaryawan = new DaftarKaryawan();
            formDaftarKaryawan.Show();
        }

        private void Btn_Riwayat_Penjualan_Click(object sender, EventArgs e)
        {
            Riwayat_Stok formRiwayatPenjualan = new Riwayat_Stok();
            formRiwayatPenjualan.Show();
        }

        private void Btn_Restock_Click(object sender, EventArgs e)
        {
            Restock formRestock = new Restock();
            formRestock.Show();
        }

        private void Btn_Profil_Click(object sender, EventArgs e)
        {
            if (_admin == null) return;

            string pesan = $"Nama     : {_admin.Nama}\nUsername : {_admin.Username}";

            DialogResult result = MessageBox.Show(
                pesan + "\n\nApakah Anda ingin Logout?",
                "Profil Admin",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }
    }
}