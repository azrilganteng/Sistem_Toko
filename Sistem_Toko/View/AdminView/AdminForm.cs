using Sistem_Toko.Helpers;
using Sistem_Toko.Model;
using Sistem_Toko.View.AdminView;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistem_Toko
{
    public partial class AdminForm : Form
    {
        private Admin? _admin;

        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(Admin admin)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _admin = admin;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
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
            this.Hide();
            Sistem_Toko.View.FormProfil halamanProfil = new Sistem_Toko.View.FormProfil();
            halamanProfil.Owner = this;
            halamanProfil.ShowDialog();
            if (halamanProfil.IsLoggedOut)
                this.Close();
            else
                this.Show();
        }
    }
}