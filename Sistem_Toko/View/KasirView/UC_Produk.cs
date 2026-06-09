using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Sistem_Toko.Model;

namespace Sistem_Toko
{
    public partial class UC_Produk : UserControl
    {
        private FormKasir _Parent;

        // Satukan saja penampung produknya ke properti ProdukData agar tidak membingungkan
        public Produk ProdukData { get; private set; }

        // PERBAIKAN: Tambahkan parameter 'int id' di constructor agar ID dari database bisa masuk
        public UC_Produk(FormKasir formInduk, int id, byte[] gambar, string nama, int harga, int stok)
        {
            InitializeComponent();
            this._Parent = formInduk;

            // PERBAIKAN SINTAKSIS: Cara membuat objek Produk baru yang benar di C#
            this.ProdukData = new Produk
            {
                Id = id, // KUNCI UTAMA: ID sekarang disimpan dengan aman!
                Gambar = gambar,
                NamaProduk = nama,
                Harga = harga,
                Stok = stok
            };

            // Mengatur tampilan gambar produk
            try
            {
                if (gambar != null && gambar.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(gambar))
                    {
                        Gambar.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    Gambar.Image = null; // Ganti dengan gambar default jika ada
                }
            }
            catch (ArgumentException)
            {
                Gambar.Image = null;
            }

            // Tampilkan data ke label UI
            LblProduk.Text = nama;
            LblHarga.Text = "Rp. " + harga.ToString("N0"); // "N0" agar ada pemisah ribuan otomatis (cth: Rp. 35.000)
            LblStok.Text = "Stok: " + stok.ToString();
        }

        private void KeranjangBtn_Click(object sender, EventArgs e)
        {
            // PERBAIKAN: Gunakan this.ProdukData yang sudah menyimpan ID dengan benar
            if (_Parent != null && this.ProdukData != null)
            {
                _Parent._kasirActive.Keranjang(this.ProdukData);
                MessageBox.Show("Berhasil Menambahkan ke keranjang", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
