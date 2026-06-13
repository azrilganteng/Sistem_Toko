using Sistem_Toko.Controller;
using Sistem_Toko.Helpers;
using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistem_Toko
{
    public partial class FormKasir : Form
    {
        public Kasir _kasirActive;
        public Dictionary<string, int> ItemQty = new Dictionary<string, int>();

        public FormKasir()
        {
            InitializeComponent();
            _kasirActive = new Kasir(
                SessionUser.Id,
                SessionUser.Nama,
                SessionUser.Username,
                ""
            );

            TampilanKasir();
            ShowProduk();
        }

        public void TampilanKasir()
        {
            LblToko.Text = "TOKO TANI SAMUDRA\n";
            LblKasir.Text = "Selamat Datang Kasir: " + SessionUser.Nama;
        }
        public void ShowProduk()
        {
            ProductController pc = new ProductController();
            var listProduk = pc.GetProduct();
            FlpProduk.Controls.Clear();

            foreach (var item in listProduk)
            {
                UC_Produk ucProduk = new UC_Produk(this, item.Id, item.Gambar, item.NamaProduk, item.Harga, item.Stok);
                FlpProduk.Controls.Add(ucProduk);
            }
        }

        private void FormKasir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        public void Keranjang(Produk PilProduk)
        {
            // Memanggil fungsi baru di Model Kasir yang merespons status dalam bentuk teks string
            string hasilValidasi = _kasirActive.TambahKeKeranjang(PilProduk);

            if (hasilValidasi != "SUKSES")
            {
                MessageBox.Show(hasilValidasi, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListKeranjangBtn_Click(object sender, EventArgs e)
        {
            var keranjang = _kasirActive.GetListKeranjang();
            if (keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang belanja masih kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormKeranjang halamanKeranjang = new FormKeranjang(this, keranjang);

            this.Hide();
            halamanKeranjang.ShowDialog();

            ShowProduk();
        }


        private void StatusKirimBtn_Click_1(object sender, EventArgs e)
        {
            View.KasirView.FormStatusPengiriman halamanStatus = new View.KasirView.FormStatusPengiriman(this);

            this.Hide();
            halamanStatus.ShowDialog();
        }
    }
}