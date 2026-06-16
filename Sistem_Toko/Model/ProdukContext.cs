using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Sistem_Toko.Helpers; 

namespace Sistem_Toko.Model
{
    public class ProdukContext
    {
        public static List<Produk> GetProductFromDatabase()
        {
            List<Produk> list = new List<Produk>();

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "SELECT id_produk, nama_produk, harga, stok, deskripsi, gambar FROM produk ORDER BY nama_produk";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produk p = new Produk
                        {
                            Id = Convert.ToInt32(reader["id_produk"]),
                            NamaProduk = reader["nama_produk"].ToString(),
                            Harga = Convert.ToInt32(reader["harga"]),
                            Stok = Convert.ToInt32(reader["stok"]),
                            Gambar = ParseGambar(reader["gambar"]),
                            Deskripsi = HasColumn(reader, "deskripsi") && reader["deskripsi"] != DBNull.Value
                                ? reader["deskripsi"].ToString()
                                : ""
                        };

                        list.Add(p);
                    }
                }
            }
            return list;
        }

        private static byte[] ParseGambar(object value)
        {
            if (value == null || value == DBNull.Value) return null;
            if (value is byte[] bytes) return bytes;
            if (value is string str && !string.IsNullOrEmpty(str))
            {
                // File path (e.g. D:\Projek SQL & PBO\bibit_cabai.jpg)
                if (str.Contains("\\") || str.Contains("/"))
                {
                    try
                    {
                        if (File.Exists(str)) return File.ReadAllBytes(str);
                    }
                    catch { return null; }
                }
                // PostgreSQL bytea hex format: \x89504e...
                if (str.StartsWith("\\x", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        string hex = str.Substring(2);
                        byte[] result = new byte[hex.Length / 2];
                        for (int i = 0; i < result.Length; i++)
                            result[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                        return result;
                    }
                    catch { return null; }
                }
                // Base64 format
                try { return Convert.FromBase64String(str); }
                catch { return null; }
            }
            return null;
        }

        private static bool HasColumn(Npgsql.NpgsqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
                if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }

        public static void RestockProduk(int idProduk, int jumlah)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

            string sql = "UPDATE produk SET stok = stok + @jumlah WHERE id_produk = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("jumlah", jumlah);
            cmd.Parameters.AddWithValue("id", idProduk);
            cmd.ExecuteNonQuery();
        }

        public static void TambahProduk(string namaProduk, int harga, int stok, string deskripsi, int idKategori, string gambarPath)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sql = @"INSERT INTO produk (nama_produk, harga, stok, deskripsi, gambar, id_kategori_produk, status)
                           VALUES (@nama, @harga, @stok, @deskripsi, @gambar, @kategori, true)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("nama", namaProduk);
            cmd.Parameters.AddWithValue("harga", harga);
            cmd.Parameters.AddWithValue("stok", stok);
            cmd.Parameters.AddWithValue("deskripsi", (object)deskripsi ?? DBNull.Value);
            cmd.Parameters.AddWithValue("gambar", (object)gambarPath ?? DBNull.Value);
            cmd.Parameters.AddWithValue("kategori", idKategori);
            cmd.ExecuteNonQuery();
        }

        public static DataTable GetStokGudang()
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sql = @"SELECT * FROM v_stok_gudang";

            var adapter = new NpgsqlDataAdapter(sql, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static List<Produk> GetProductKategory(int idKategori)
        {
            List<Produk> list = new List<Produk>();

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "SELECT id_produk, nama_produk, harga, stok, gambar, id_kategori_produk, deskripsi FROM produk WHERE id_kategori_produk = @id_kat AND stok > 0;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id_kat", idKategori);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produk p = new Produk
                            {
                                Id = Convert.ToInt32(reader["id_produk"]),
                                NamaProduk = reader["nama_produk"].ToString(),
                                Harga = Convert.ToInt32(reader["harga"]),
                                Stok = Convert.ToInt32(reader["stok"]),
                                IdKategori = Convert.ToInt32(reader["id_kategori_produk"]),
                                //Status = reader["status"].ToString(),
                                Gambar = ParseGambar(reader["gambar"]),
                                Deskripsi = HasColumn(reader, "deskripsi") && reader["deskripsi"] != DBNull.Value
                                    ? reader["deskripsi"].ToString()
                                    : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;

        }
    }
}