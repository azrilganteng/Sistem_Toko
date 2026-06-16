using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using Sistem_Toko.Helpers;

namespace Sistem_Toko.Model
{
    public class PengirimanContext
    {
        // Convert boolean to display string: true = "Selesai", false = "Proses"
        private static string BoolToStatus(object dbValue)
        {
            if (dbValue is bool b) return b ? "Selesai" : "Proses";
            return dbValue?.ToString() ?? "Proses";
        }

        public static List<Pengiriman> GetStatusPengiriman(string status)
        {
            List<Pengiriman> list = new List<Pengiriman>();

            bool statusBool = status.Equals("Selesai", StringComparison.OrdinalIgnoreCase);

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT p.id_pengiriman, p.status_pengiriman, p.tanggal_kirim, p.id_user,
                                      o.id_order, c.alamat
                               FROM pengiriman p
                               LEFT JOIN orders o ON o.id_pengiriman = p.id_pengiriman
                               LEFT JOIN customer c ON o.id_customer = c.id_customer
                               WHERE p.status_pengiriman = @status";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("status", statusBool);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pengiriman p = new Pengiriman
                            {
                                IdPengiriman = Convert.ToInt32(reader["id_pengiriman"]),
                                Alamat = reader["alamat"]?.ToString() ?? "",
                                StatusPengiriman = BoolToStatus(reader["status_pengiriman"]),
                                TanggalKirim = ((DateOnly)reader["tanggal_kirim"]).ToDateTime(TimeOnly.MinValue),
                                IdOrder = HasColumn(reader, "id_order") && reader["id_order"] != DBNull.Value ? Convert.ToInt32(reader["id_order"]) : 0,
                                IdUser = HasColumn(reader, "id_user") ? Convert.ToInt32(reader["id_user"]) : 0
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }

        public static List<Pengiriman> GetAll()
        {
            List<Pengiriman> list = new List<Pengiriman>();

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sql = @"SELECT p.id_pengiriman, p.status_pengiriman, p.tanggal_kirim, p.id_user,
                                      o.id_order, c.alamat
                               FROM pengiriman p
                               LEFT JOIN orders o ON o.id_pengiriman = p.id_pengiriman
                               LEFT JOIN customer c ON o.id_customer = c.id_customer";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pengiriman p = new Pengiriman
                        {
                            IdPengiriman = Convert.ToInt32(reader["id_pengiriman"]),
                            Alamat = reader["alamat"]?.ToString() ?? "",
                            StatusPengiriman = BoolToStatus(reader["status_pengiriman"]),
                            TanggalKirim = reader["tanggal_kirim"] is DateOnly d 
                                ? d.ToDateTime(TimeOnly.MinValue) 
                                : Convert.ToDateTime(reader["tanggal_kirim"]),
                            IdOrder = reader["id_order"] != DBNull.Value ? Convert.ToInt32(reader["id_order"]) : 0,
                            IdUser = Convert.ToInt32(reader["id_user"])
                        };

                        list.Add(p);
                    }
                }
            }

            return list;
        }

        private static bool HasColumn(NpgsqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
                if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }

        public static List<Pengiriman> GetPengirimanByKurir(int idKurir)
        {
            List<Pengiriman> list = new List<Pengiriman>();

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT p.id_pengiriman, p.status_pengiriman, p.tanggal_kirim, p.id_user,
                                      o.id_order, c.alamat
                               FROM pengiriman p
                               LEFT JOIN orders o ON o.id_pengiriman = p.id_pengiriman
                               LEFT JOIN customer c ON o.id_customer = c.id_customer
                               WHERE p.id_user = @id_kurir AND p.status_pengiriman = false
                               ORDER BY p.id_pengiriman DESC;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id_kurir", idKurir);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var tanggalRaw = reader["tanggal_kirim"];
                            DateTime tanggalHasil;

                            if (tanggalRaw is DateOnly dateOnlyVal)
                            { 
                                tanggalHasil = dateOnlyVal.ToDateTime(TimeOnly.MinValue);
                            }
                            else
                            {
                                tanggalHasil = Convert.ToDateTime(tanggalRaw);
                            }

                            Pengiriman p = new Pengiriman
                            {
                                IdPengiriman = Convert.ToInt32(reader["id_pengiriman"]),
                                Alamat = reader["alamat"]?.ToString() ?? "",
                                StatusPengiriman = BoolToStatus(reader["status_pengiriman"]),
                                TanggalKirim = tanggalHasil, // Menggunakan tanggal yang sudah aman
                                IdOrder = Convert.ToInt32(reader["id_order"]),
                                IdUser = Convert.ToInt32(reader["id_user"])
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }
        public static DataTable GetDetailBarangOrder(int idOrder)
        {
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT p.nama_produk, do.jumlah, do.harga, (do.jumlah * do.harga) AS subtotal
                               FROM detail_order do
                               JOIN produk p ON do.id_produk = p.id_produk
                               WHERE do.id_order = @idOrder;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("idOrder", idOrder);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}