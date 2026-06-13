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
        public Produk ProdukData { get; private set; }

        public UC_Produk(FormKasir formInduk, int id, byte[] gambar, string nama, int harga, int stok)
        {
            InitializeComponent();
            this._Parent = formInduk;

            this.ProdukData = new Produk
            {
                Id = id,
                Gambar = gambar,
                NamaProduk = nama,
                Harga = harga,
                Stok = stok
            };

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
                    Gambar.Image = null;
                }
            }
            catch (ArgumentException)
            {
                Gambar.Image = null;
            }

            LblProduk.Text = nama;
            LblHarga.Text = "Rp. " + harga.ToString("N0");
            LblStok.Text = "Stok: " + stok.ToString();
        }

        private void KeranjangBtn_Click(object sender, EventArgs e)
        {
            if (_Parent != null && this.ProdukData != null)
            {

                _Parent.Keranjang(this.ProdukData);
                MessageBox.Show($"{this.ProdukData.NamaProduk} berhasil dimasukkan ke keranjang!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BuyNowBtn_Click(object sender, EventArgs e)
        {

        }
    }
}