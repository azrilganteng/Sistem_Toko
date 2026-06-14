using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using Sistem_Toko.Helpers;


namespace Sistem_Toko.Model
{
    public class KurirContext
    {
        public static List<Kurir> GetKurirReadyFromDatabase()
        {
            List<Kurir> list = new List<Kurir>();
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "SELECT id_user, nama FROM kurir_ready;";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id_user"]);
                        string namaKurir = reader["nama"].ToString();

                        list.Add(new Kurir(id, namaKurir));
                    }
                }
            }
            return list;
        }


            public static Kurir CekLoginKurir(string username, string password)
            {
                using (var conn = connectDB.GetConn())
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    string sql = @"SELECT u.id_user, u.username, u.password, u.nama, u.no_hp, u.email
                                FROM ""users"" u
                                WHERE u.username = @username AND u.password = @password;";

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
        }
    
}