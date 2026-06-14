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

        public UC_ProdukKeranjang(FormKeranjang halamanKeranjang,FormKasir formInduk, Produk produk, int qty)
        {
            InitializeComponent();
            this._halamanKeranjang = halamanKeranjang;
            this._Parent = formInduk;
            this.ProdukItem = produk;
            this.JumlahBeli = qty;


            ItemKeranjang.Text = produk.NamaProduk;
            HargaKeranjang.Text = "Harga Rp. " + produk.Harga.ToString("N0");
            this.lblQty.Text = qty.ToString();
            try
            {
                if (produk.Gambar != null && produk.Gambar.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(produk.Gambar))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
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

        private void PlusQty_Click(object sender, EventArgs e)
        {
            if (_halamanKeranjang != null && this.ProdukItem != null)
            { 
                _halamanKeranjang.TmbhQty(this.ProdukItem.NamaProduk);
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
