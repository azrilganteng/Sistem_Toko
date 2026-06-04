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
        public Produk ProdukItem { get; private set; }
        public int Qty { get; private set; }
        public UC_ProdukKeranjang(FormKasir formInduk, Produk produk, int qty)
        {
            InitializeComponent();
            this._Parent = formInduk;
            this.ProdukItem = produk;
            this.Qty = qty;

            ProdNamaKeranjang.Text = produk.NamaProduk;
            HargaKeranjang.Text = "Harga Rp. " + produk.Harga.ToString();
            QtyKeranjang.Text = "Qty: " + qty.ToString();

            try
            {
                if (produk.Gambar != null && produk.Gambar.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(produk.Gambar))
                    {
                        ProdGambarKeranjang.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ProdGambarKeranjang.Image = null;
                }
            }
            catch { ProdGambarKeranjang.Image = null; }
        }

        private void BatalKeranjang_Click(object sender, EventArgs e)
        {

        }
        //private void btnBatal_Click(object sender, EventArgs e)
        //{
        //    // Panggil fungsi hapus item yang ada di FormKasir
        //    _Parent.HapusDariKeranjang(this.ProdukItem);
        //}
    }
}
