using Sistem_Toko.Controller;
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

        public FormKasir(Kasir data)
        {
            InitializeComponent();
            _kasirActive = data;

            TampilanKasir();
            ShowProduk();
    
        }

        public void TampilanKasir()
        {
            LblToko.Text = "TOKO TANI SAMUDRA\n";
            LblKasir.Text = "Selamat Datang Kasir: " + _kasirActive.Nama;
        }

        private void ShowProduk()
        {
            ProductController pc = new ProductController();
            var listProduk = pc.GetProduct();
            FlpProduk.Controls.Clear();

            foreach (var item in listProduk)
            {
                UC_Produk ucProduk = new UC_Produk(this, item.Id,item.Gambar, item.NamaProduk, item.Harga, item.Stok);
                FlpProduk.Controls.Add(ucProduk);
            }

        }

        private void FormKasir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void Keranjang(Produk PilProduk)
        { 
            _kasirActive.Keranjang(PilProduk);
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
    }
}