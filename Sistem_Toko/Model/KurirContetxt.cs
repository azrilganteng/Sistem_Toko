using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using Sistem_Toko.Helpers;

namespace Sistem_Toko.Model
{
    public class KurirContext
    {
        public static Kurir CekLoginKurir(string user, string pass)
        {
            bool isSuccess = false;
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT * FROM v_data_kurir
                               WHERE username = @username AND password = @password;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("username", user);
                    cmd.Parameters.AddWithValue("password", pass);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // ISI SESSION SECARA LENGKAP LAYAKNYA KASIR
                            SessionUser.Id = Convert.ToInt32(reader["id_user"]);
                            SessionUser.Username = reader["username"].ToString();
                            SessionUser.Nama = reader["nama"].ToString();
                            SessionUser.Email = reader["email"].ToString();
                            SessionUser.Alamat = reader["alamat"].ToString();
                            SessionUser.Role = "Kurir";
                            SessionUser.IdRole = 3;
                            try { SessionUser.NoHp = reader["no_hp"].ToString(); } catch { }

                            return new Kurir(
                                SessionUser.Id,
                                SessionUser.Nama,
                                SessionUser.Username,
                                reader["password"].ToString(),
                                true
                            );
                        }
                    }
                }
            }
            return null;
        }

        public static bool UpdateStatusKeDatabase(int idPengiriman, string statusBaru)
        {
            // Convert string status to boolean: "Selesai" = true, "Proses" = false
            bool statusBool = statusBaru.Equals("Selesai", StringComparison.OrdinalIgnoreCase)
                           || statusBaru.Equals("True", StringComparison.OrdinalIgnoreCase);

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"UPDATE pengiriman 
                               SET status_pengiriman = @status 
                               WHERE id_pengiriman = @id;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("status", statusBool);
                    cmd.Parameters.AddWithValue("id", idPengiriman);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static List<Kurir> GetKurirReady()
        {
            List<Kurir> list = new List<Kurir>();
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "SELECT * FROM v_kurir_ready;";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Kurir(
                            Convert.ToInt32(reader["id_user"]),
                            reader["nama"].ToString(),
                            "",
                            "",
                            true
                        ));
                    }
                }
            }
            return list;
        }
    }
}