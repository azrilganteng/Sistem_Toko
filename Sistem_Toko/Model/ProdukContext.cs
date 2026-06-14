using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using Sistem_Toko.Helpers; 

namespace Sistem_Toko.Model
{
    public class ProdukContext
    {
        public static List<Produk> GetAllProduct()
        {
            List<Produk> list = new List<Produk>();

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "select * from kartu_produk;";

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
                            Gambar = reader["gambar"] != DBNull.Value ? (byte[])reader["gambar"] : null,

                            Deskripsi = ""
                        };

                        list.Add(p);
                    }
                }
            }
            return list;
        }
        public static List<Produk> GetProductKategory(int idKategori)
        {
            List<Produk> list = new List<Produk>();

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "SELECT * FROM kartu_produk WHERE id_kategori_produk = @id_kat;";

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
                                Gambar = reader["gambar"] != DBNull.Value ? (byte[])reader["gambar"] : null,
                                Deskripsi = ""
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