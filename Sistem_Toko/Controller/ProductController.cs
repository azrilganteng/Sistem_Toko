using Npgsql;
using Sistem_Toko.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Sistem_Toko.Model;

namespace Sistem_Toko.Controller
{
    public  class ProductController
    {
        public List<Produk> GetProduct()
        {
         List<Produk> list = new List<Produk>();
         using (var conn = connectDB.GetConn())
            {
                string sql = "SELECT nama_produk,harga,stok,gambar FROM produk";
                var cmd = new NpgsqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Produk
                    {

                        NamaProduk = reader["nama_produk"].ToString(),
                        Harga = Convert.ToInt32(reader["harga"]),
                        Stok = Convert.ToInt32(reader["stok"]),
                        Gambar = reader["gambar"] != DBNull.Value ? (byte[])reader["gambar"] : null
                    });
                }
            }
            return list;
        }
    }
}
