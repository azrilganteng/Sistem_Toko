using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem_Toko.Model
{
    public class Produk
    {
        public string NamaProduk { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }
        public byte[] Gambar { get; set; }
    }
}
