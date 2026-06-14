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
        public int IdKategori { get; set; }
        public string Status { get; set; }

        public byte[] Gambar { get; set; }

        public Produk() { }
        public Produk(int id, string namaProduk, int harga, int stok, string deskripsi, int idKategori, string status, byte[] gambar)
        {
            this.Id = id;
            this.NamaProduk = namaProduk;
            this.Harga = harga;
            this.Stok = stok;
            this.Deskripsi = deskripsi;
            this.IdKategori = idKategori;
            this.Status = status;
            this.Gambar = gambar;
        }
    }
}