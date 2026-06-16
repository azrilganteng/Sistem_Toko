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
    public partial class UC_ProdukKeranjang : UserControl
    {
        private FormKasir _Parent;
        private FormKeranjang _halamanKeranjang;
        public Produk ProdukItem { get; private set; }
        public int JumlahBeli { get; private set; }

        public UC_ProdukKeranjang(FormKeranjang halamanKeranjang, FormKasir formInduk, Produk produk, int qty)
        {
            InitializeComponent();
            this._halamanKeranjang = halamanKeranjang;
            this._Parent = formInduk;
            this.ProdukItem = produk;
            this.JumlahBeli = qty;

            ItemKeranjang.Text = produk.NamaProduk;
            HargaKeranjang.Text = "Rp " + produk.Harga.ToString("N0");
            NumQty.Value = qty;

            // Calculate subtotal
            //HitungSubtotal();

            try
            {
                if (!string.IsNullOrEmpty(produk.Gambar))
                {
                    string folderPath = Path.Combine(Application.StartupPath, "Images");
                    string fullPath = Path.Combine(folderPath, produk.Gambar);

                    if (File.Exists(fullPath))
                    {
                        pictureBox1.Image = Image.FromFile(fullPath);
                    }
                    else
                    {
                        pictureBox1.Image = null; 
                    }
                }
                else
                {
                    pictureBox1.Image = null; 
                }
            }
            catch
            {
                pictureBox1.Image = null; 
            }
        }

        private void HitungSubtotal()
        {
            if (this.ProdukItem != null)
            {
                LblSubtotal.Text = "Rp " + (this.ProdukItem.Harga * NumQty.Value).ToString("N0");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (_halamanKeranjang != null && this.ProdukItem != null)
            {
                int newQty = (int)NumQty.Value;
                if (newQty <= 0)
                {
                    _halamanKeranjang.HapusItem(this.ProdukItem.NamaProduk);
                }
                else
                {
                    _halamanKeranjang.UbahQty(this.ProdukItem.NamaProduk, newQty);
                }
            }
        }

        private void BatalBtn_Click(object sender, EventArgs e)
        {
            if (this.ProdukItem == null) return;

            DialogResult result = MessageBox.Show($"Apakah Anda yakin ingin menghapus '{this.ProdukItem.NamaProduk}' dari keranjang?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (_halamanKeranjang != null)
                {
                    _halamanKeranjang.HapusItem(this.ProdukItem.NamaProduk);
                }
            }
        }
    }
}
