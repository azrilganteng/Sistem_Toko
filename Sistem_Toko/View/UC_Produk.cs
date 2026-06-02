using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Sistem_Toko
{
    public partial class UC_Produk : UserControl
    {
        public UC_Produk(byte[] gambar,string nama,int harga,int stok)
        {
            InitializeComponent();
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
    }
}
