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

                string sql = "SELECT * FROM v_kartu_produk ORDER BY nama_produk";

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
                            Gambar = reader["gambar"] != DBNull.Value ? reader["gambar"].ToString() : null,
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

        public static List<Produk> GetAllProductAdmin()
        {
            List<Produk> list = new List<Produk>();

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Admin (Restock) perlu melihat semua produk, termasuk yang stoknya habis.
                // Oleh karena itu, kita query langsung ke tabel 'produk', bukan 'v_kartu_produk' 
                // karena kemungkinan v_kartu_produk menyembunyikan stok 0.
                string sql = "SELECT * FROM produk ORDER BY nama_produk";

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
                            //Gambar = ParseGambar(reader["gambar"]),
                            Gambar = HasColumn(reader, "gambar") && reader["gambar"] != DBNull.Value ? reader["gambar"].ToString() : null,
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

        public static int TambahProduk(string namaProduk, int harga, string deskripsi, int idKategori, string gambarPath)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            // Stok awal = 0, akan bertambah saat restock
            string sql = "SELECT fn_tambah_produk(@nama, @harga, @stok, @deskripsi, @gambar, @kategori);";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("nama", namaProduk);
            cmd.Parameters.AddWithValue("harga", harga);
            cmd.Parameters.AddWithValue("stok", 0);
            cmd.Parameters.AddWithValue("deskripsi", (object)deskripsi ?? DBNull.Value);
            cmd.Parameters.AddWithValue("gambar", (object)gambarPath ?? DBNull.Value);
            cmd.Parameters.AddWithValue("kategori", idKategori);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static List<(int Id, string Nama)> GetAllSupplier()
        {
            var list = new List<(int, string)>();
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sql = "SELECT id_supplier, nama FROM supplier ORDER BY nama;";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add((Convert.ToInt32(reader["id_supplier"]), reader["nama"].ToString() ?? ""));
            }
            return list;
        }

        public static int TambahSupplier(string nama, string alamat, string noHp, string email)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sql = "SELECT fn_tambah_supplier(@nama, @alamat, @noHp, @email);";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("nama", nama);
            cmd.Parameters.AddWithValue("alamat", (object)alamat ?? DBNull.Value);
            cmd.Parameters.AddWithValue("noHp", (object)noHp ?? DBNull.Value);
            cmd.Parameters.AddWithValue("email", (object)email ?? DBNull.Value);
            
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static void TambahSupplierProduk(int idSupplier, int idProduk)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sql = "INSERT INTO supplier_produk (id_supplier, id_produk) VALUES (@idSupplier, @idProduk);";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idSupplier", idSupplier);
            cmd.Parameters.AddWithValue("idProduk", idProduk);
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

                string sql = "SELECT * FROM v_kartu_produk WHERE id_kategori_produk = @id_kat;";

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
                                //Gambar = reader["gambar"] != DBNull.Value ? (byte[])reader["gambar"] : null,
                                Gambar = reader["gambar"] != DBNull.Value ? reader["gambar"].ToString() : null,
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