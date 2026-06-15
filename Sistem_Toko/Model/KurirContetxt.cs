using Npgsql;
using System;
using System.Data;
using Sistem_Toko.Helpers;

namespace Sistem_Toko.Model
{
    public class KurirContext
    {
        public static Kurir CekLoginKurir(string username, string password)
        {
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT id_user, username, password, nama, no_hp, email, alamat 
                               FROM ""users"" 
                               WHERE username = @username AND password = @password;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

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
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"UPDATE pengiriman 
                               SET status_pengiriman = @status 
                               WHERE id_pengiriman = @id;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("status", statusBaru);
                    cmd.Parameters.AddWithValue("id", idPengiriman);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
       
    }
}