using Sistem_Toko.Helpers; // Tempat connectDB kamu
using Npgsql;
using Sistem_Toko.Model;

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

<<<<<<< HEAD
    public Admin LoginAdmin(string user, string pass)
    {
        Admin dataAdmin = null;

        using (NpgsqlConnection conn = connectDB.GetConn())
        {
            string sql = @"select * from admin
                        WHERE username = @u AND password = @p";
=======
    public kurir LoginKurir(string user, string pass)
    {
        kurir dataKurir = null;

        using (NpgsqlConnection conn = connectDB.GetConn())
        {
            string sql = @"select * from users u
                       join kewenangan k on u.id_user = k.id_user
                       where u.username = @u AND u.password = @p
                       AND k.id_role = 3";
>>>>>>> a92420899f7b67f66023c890f5449b4e1c336052

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("u", user);
                cmd.Parameters.AddWithValue("p", pass);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
<<<<<<< HEAD
                    {               
                            dataAdmin = new Admin(
                            Convert.ToInt32(reader["id_admin"]),
=======
                    {
                        dataKurir = new kurir(
                            Convert.ToInt32(reader["id_user"]),
>>>>>>> a92420899f7b67f66023c890f5449b4e1c336052
                            reader["nama"].ToString(),
                            reader["username"].ToString(),
                            reader["password"].ToString()
                        );
                    }
                }
            }
        }
<<<<<<< HEAD
        return dataAdmin;
=======
        return dataKurir;
>>>>>>> a92420899f7b67f66023c890f5449b4e1c336052
    }
}