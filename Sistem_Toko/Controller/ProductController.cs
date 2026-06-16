using Npgsql;
using Sistem_Toko.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using Sistem_Toko.Model;

namespace Sistem_Toko.Controller
{
    public class ProductController
    {
        /// <summary>
        /// Ambil semua produk aktif (stok > 0) via v_kartu_produk.
        /// </summary>
        public List<Produk> GetAll()
        {
            return ProdukContext.GetProductFromDatabase();
        }

        public static List<Produk> GetProductFromDatabase()
        {
            return ProdukContext.GetProductFromDatabase();
        }

        /// <summary>
        /// Ambil produk berdasarkan kategori via v_kartu_produk.
        /// </summary>
        public List<Produk> GetProduct(int idKategori)
        {
            return ProdukContext.GetProductKategory(idKategori);
        }

        /// <summary>
        /// Ambil data stok gudang via v_stok_gudang.
        /// </summary>
        public DataTable GetStokGudang()
        {
            return ProdukContext.GetStokGudang();
        }

        /// <summary>
        /// Restock produk (UPDATE stok).
        /// Trigger trg_log_stok otomatis mencatat ke log_stok.
        /// </summary>
        public void RestockProduk(int idProduk, int jumlah)
        {
            ProdukContext.RestockProduk(idProduk, jumlah);
        }

        /// <summary>
        /// Tambah produk baru via fn_tambah_produk.
        /// Return id_produk yang baru dibuat.
        /// </summary>
        public int TambahProduk(string namaProduk, int harga, int stok,
                                 string deskripsi, int idKategori, string gambarPath)
        {
            return ProdukContext.TambahProduk(namaProduk, harga, stok, deskripsi, idKategori, gambarPath);
        }
    }
}
