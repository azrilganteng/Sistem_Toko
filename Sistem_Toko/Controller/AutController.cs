using Sistem_Toko.Helpers; // Tempat connectDB kamu
using Npgsql;
using Sistem_Toko.Model;
using System;

namespace Sistem_Toko.Controller;

public class AuthController
{
    public Kasir LoginKasir(string user, string pass)
    {
        Kasir dataKasir = null;

        using (NpgsqlConnection conn = connectDB.GetConn())
        {
            string sql = @"select * from data_kasir
                        WHERE username = @u AND password = @p";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("u", user);
                cmd.Parameters.AddWithValue("p", pass);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dataKasir = new Kasir(
                            Convert.ToInt32(reader["id_user"]),
                            reader["nama"].ToString(),
                            reader["username"].ToString(),
                            reader["password"].ToString()
                        );
                    }
                }
            }
        }
        return dataKasir;
    }

    public Admin LoginAdmin(string user, string pass)
    {
        Admin dataAdmin = null;

        using (NpgsqlConnection conn = connectDB.GetConn())
        {
            string sql = @"select * from data_admin
                        WHERE username = @u AND password = @p";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("u", user);
                cmd.Parameters.AddWithValue("p", pass);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dataAdmin = new Admin(
                            Convert.ToInt32(reader["id_user"]),
                            reader["nama"].ToString(),
                            reader["username"].ToString(),
                            reader["password"].ToString()
                        );
                    }
                }
            }
        }
        return dataAdmin;
    }

    public kurir LoginKurir(string user, string pass)
    {
        kurir dataKurir = null;

        using (NpgsqlConnection conn = connectDB.GetConn())
        {
            string sql = @"select * from users u
                       join kewenangan k on u.id_user = k.id_user
                       where u.username = @u AND u.password = @p
                       AND k.id_role = 3";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("u", user);
                cmd.Parameters.AddWithValue("p", pass);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dataKurir = new kurir(
                            Convert.ToInt32(reader["id_user"]),
                            reader["nama"].ToString(),
                            reader["username"].ToString(),
                            reader["password"].ToString()
                        );
                    }
                }
            }
        }
        return dataKurir;
    }
}