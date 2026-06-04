using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem_Toko.Model
{
    public class Produk
    {
        public int Id { get; set; }
        public string NamaProduk { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }
        public string Deskripsi { get; set; }
        public int id_Kategori { get; set; }
        public string status { get; set; }
        public byte[] Gambar { get; set; }
    }
}
