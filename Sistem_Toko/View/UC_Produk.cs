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
        private Produk _produkDetail;
        public UC_Produk(FormKasir formInduk, byte[] gambar, string nama, int harga, int stok)
        {

            InitializeComponent();
            this._Parent = formInduk;
            this._produkDetail = new Produk
            {
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
            LblHarga.Text = "Rp. " + harga.ToString();
            LblStok.Text = "Stok: " + stok.ToString();
        }

        private void KeranjangBtn_Click(object sender, EventArgs e)
        {
            if (_Parent != null && this._produkDetail != null)
            {
                _Parent.Keranjang(this._produkDetail);
            }
            else
            {
                MessageBox.Show("Gagal menambahkan ke keranjang: Data produk tidak terinisialisasi dengan benar.", "Error");
            }
        }

    }
}
