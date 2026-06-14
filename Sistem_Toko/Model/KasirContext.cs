using Npgsql;
using System;
using System.Data;
using Sistem_Toko.Helpers;

namespace Sistem_Toko.Model
{
    public class KasirContext
    {
        public static Kasir CekLoginKasir(string username, string password)
        {
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT * FROM data_kasir WHERE username = @username AND password = @password;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            SessionUser.Id = Convert.ToInt32(reader["id_user"]);
                            SessionUser.Username = reader["username"].ToString();
                            SessionUser.Nama = reader["nama"].ToString();
                            SessionUser.IdRole = 2;

                            return new Kasir(
                                SessionUser.Id,
                                SessionUser.Nama,
                                SessionUser.Username,
                                reader["password"].ToString()
                            );
                        }
                    }
                }
            }
            return null;
        }
    }
}