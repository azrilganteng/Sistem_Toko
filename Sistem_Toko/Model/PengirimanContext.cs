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

        private static bool HasColumn(NpgsqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
                if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }

        public static List<Pengiriman> GetStatusPengiriman(string status)
        {
            List<Pengiriman> list = new List<Pengiriman>();
            bool statusBool = status.Equals("Selesai", StringComparison.OrdinalIgnoreCase);

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT * FROM v_status_pengiriman
                               WHERE status_pengiriman = @status";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("status", statusBool);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Pengiriman
                            {
                                IdPengiriman     = Convert.ToInt32(reader["id_pengiriman"]),
                                Alamat           = reader["alamat"]?.ToString() ?? "",
                                StatusPengiriman = BoolToStatus(reader["status_pengiriman"]),
                                TanggalKirim     = ((DateOnly)reader["tanggal_kirim"]).ToDateTime(TimeOnly.MinValue),
                                IdOrder          = HasColumn(reader, "id_order") && reader["id_order"] != DBNull.Value ? Convert.ToInt32(reader["id_order"]) : 0,
                                IdUser           = HasColumn(reader, "id_user") ? Convert.ToInt32(reader["id_user"]) : 0
                            });
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
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT * FROM v_status_pengiriman";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Pengiriman
                        {
                            IdPengiriman     = Convert.ToInt32(reader["id_pengiriman"]),
                            Alamat           = reader["alamat"]?.ToString() ?? "",
                            StatusPengiriman = BoolToStatus(reader["status_pengiriman"]),
                            TanggalKirim     = reader["tanggal_kirim"] is DateOnly d
                                               ? d.ToDateTime(TimeOnly.MinValue)
                                               : Convert.ToDateTime(reader["tanggal_kirim"]),
                            IdOrder          = reader["id_order"] != DBNull.Value ? Convert.ToInt32(reader["id_order"]) : 0,
                            IdUser           = Convert.ToInt32(reader["id_user"])
                        });
                    }
                }
            }
            return list;
        }

        public static List<Pengiriman> GetPengirimanByKurir(int idKurir)
        {
            List<Pengiriman> list = new List<Pengiriman>();

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Menggunakan view v_status_pengiriman dengan filter id_user (kurir)
                // NULL status = belum dikirim (sama dengan false)
                // CATATAN: view tidak punya kolom id_kurir, gunakan id_user
                string sql = @"SELECT * FROM v_status_pengiriman
                               WHERE id_user = @id_kurir
                                 AND (status_pengiriman = false OR status_pengiriman IS NULL)
                               ORDER BY id_pengiriman DESC;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id_kurir", idKurir);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime tanggalHasil;
                            var tanggalRaw = reader["tanggal_kirim"];
                            if (tanggalRaw is DateOnly dateOnly)
                                tanggalHasil = dateOnly.ToDateTime(TimeOnly.MinValue);
                            else if (tanggalRaw == DBNull.Value || tanggalRaw == null)
                                tanggalHasil = DateTime.Today;
                            else
                                tanggalHasil = Convert.ToDateTime(tanggalRaw);

                            // View bisa punya id_kurir atau id_user, keduanya sama nilainya
                            int idUserKurir = HasColumn(reader, "id_user")
                                ? Convert.ToInt32(reader["id_user"])
                                : (HasColumn(reader, "id_kurir") ? Convert.ToInt32(reader["id_kurir"]) : idKurir);

                            list.Add(new Pengiriman
                            {
                                IdPengiriman     = Convert.ToInt32(reader["id_pengiriman"]),
                                Alamat           = HasColumn(reader, "alamat") ? reader["alamat"]?.ToString() ?? "" : "",
                                StatusPengiriman = BoolToStatus(reader["status_pengiriman"]),
                                TanggalKirim     = tanggalHasil,
                                IdOrder          = HasColumn(reader, "id_order") && reader["id_order"] != DBNull.Value
                                                   ? Convert.ToInt32(reader["id_order"]) : 0,
                                IdUser           = idUserKurir
                            });
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

                string sql = @"SELECT * FROM v_detail_order WHERE id_order = @idOrder;";

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