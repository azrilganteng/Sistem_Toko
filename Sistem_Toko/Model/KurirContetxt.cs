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

                string sql = "SELECT u.id_user, u.nama FROM users u JOIN kewenangan k ON u.id_user = k.id_user WHERE k.id_role = 3 AND k.is_ready = true;";
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
        public static bool CekLoginKurir(string user, string pass)
        {
            bool isSuccess = false;
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT u.id_user, u.username, u.nama, u.no_hp, u.email
                               FROM users u
                               WHERE u.username = @u AND u.password = @p;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("u", user);
                    cmd.Parameters.AddWithValue("p", pass);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            SessionUser.Id = Convert.ToInt32(reader["id_user"]);
                            SessionUser.Username = reader["username"].ToString();
                            SessionUser.Nama = reader["nama"].ToString();
                            SessionUser.IdRole = 3;

                            isSuccess = true;
                        }
                    }
                }
            }
            return isSuccess;
        }
    }
}