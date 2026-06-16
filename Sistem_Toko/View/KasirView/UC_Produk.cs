using Sistem_Toko.Model;
using Sistem_Toko.View.KasirView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Sistem_Toko
{
    public partial class UC_Produk : UserControl
    {
        private FormKasir _Parent;
        public Produk ProdukData { get; private set; }

        public UC_Produk(FormKasir formInduk, int id, string gambar, string nama, int harga, int stok, string deskripsi)
        {
            InitializeComponent();
            this._Parent = formInduk;

            this.ProdukData = new Produk
            {
                Id = id,
                Gambar = gambar,
                NamaProduk = nama,
                Harga = harga,
                Stok = stok,
                Deskripsi = deskripsi
            };

            try
            {
                if (!string.IsNullOrEmpty(gambar))
                {
                    string folderPath = Path.Combine(Application.StartupPath, "Images");
                    string fullPath = Path.Combine(folderPath, gambar);

                    if (File.Exists(fullPath))
                    {
                        Gambar.Image = Image.FromFile(fullPath);
                    }
                    else
                    {
                        Gambar.Image = null;
                    }
                }
                else
                {
                    Gambar.Image = null;
                    Gambar.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Gagal memuat gambar: " + ex.Message);
                Gambar.Image = null;
                Gambar.BackColor = Color.LightGray;
            }

            LblProduk.Text = nama;
            LblHarga.Text = "Rp " + harga.ToString("N0");
            LblStok.Text = stok > 0 ? $"Stok: {stok}" : "Stok Habis";

            // Disable buttons if out of stock
            if (stok <= 0)
            {
                KeranjangBtn.Enabled = false;
                KeranjangBtn.BackColor = Color.Gray;
                BuyNowBtn.Enabled = false;
                BuyNowBtn.BackColor = Color.Gray;
                LblStok.ForeColor = Color.Crimson;
                LblStok.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
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