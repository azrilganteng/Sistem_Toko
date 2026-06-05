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

        // --- PERBAIKAN 1: Ganti nama properti int agar tidak bentrok dengan nama Label 'Qty' ---
        public int JumlahBeli { get; private set; }

        public UC_ProdukKeranjang(FormKasir formInduk, Produk produk, int qty)
        {
            InitializeComponent();
            this._Parent = formInduk;
            this.ProdukItem = produk;
            this.JumlahBeli = qty; 

        
            ItemKeranjang.Text = produk.NamaProduk;  
            HargaKeranjang.Text = "Harga Rp. " + produk.Harga.ToString("N0"); 
            this.Qty.Text = "Qty: " + qty.ToString();        
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

        private void BatalKeranjang_Click(object sender, EventArgs e)
        {

        }
    }
}