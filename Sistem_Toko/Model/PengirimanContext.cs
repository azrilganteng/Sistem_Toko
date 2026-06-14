using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using Sistem_Toko.Helpers;

namespace Sistem_Toko.Model
{
    public class PengirimanContext
    {
        public static List<Pengiriman> GetStatusPengiriman(string status)
        {
            List<Pengiriman> list = new List<Pengiriman>();

            // Convert string status to boolean: "Selesai" = true, "Proses" = false
            bool statusBool = status.Equals("Selesai", StringComparison.OrdinalIgnoreCase);

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT * FROM v_status_pengiriman
                               WHERE status_pengiriman = @status;";

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
                                Alamat = reader["alamat"].ToString(),
                                StatusPengiriman = reader["status_pengiriman"].ToString(),
                                TanggalKirim = ((DateOnly)reader["tanggal_kirim"]).ToDateTime(TimeOnly.MinValue),
                                IdUser = HasColumn(reader, "id_user") ? Convert.ToInt32(reader["id_user"]) : 0
                            };
                            list.Add(p);
                        }
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

        public static int SimpanDataPengiriman(NpgsqlConnection conn, NpgsqlTransaction transaction, int idKurir)
        {
            string sqlPengiriman = @"CALL p_simpan_pengiriman(@idKurir);";

            using (var cmd = new NpgsqlCommand(sqlPengiriman, conn))
            {
                cmd.Parameters.AddWithValue("@idKurir", idKurir);

                cmd.ExecuteNonQuery();
            }

            // Ambil id_pengiriman yang baru dibuat
            string sqlGetId = "SELECT MAX(id_pengiriman) FROM pengiriman WHERE id_user = @idKurir;";
            using (var cmdGet = new NpgsqlCommand(sqlGetId, conn))
            {
                cmdGet.Parameters.AddWithValue("@idKurir", idKurir);
                return Convert.ToInt32(cmdGet.ExecuteScalar());
            }
        }
    }
}