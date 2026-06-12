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
        bool isSuccess = false;

        using (NpgsqlConnection conn = connectDB.GetConn())
        {
            string sql = @"SELECT u.id_user, u.username, u.password, u.nama, 
                      u.no_hp, u.email, u.is_ready,
                      kw.id_role
               FROM users u
               JOIN kewenangan kw ON u.id_user = kw.id_user
               WHERE u.username = @u AND u.password = @p
               AND kw.id_role = 3";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("u", user);
                cmd.Parameters.AddWithValue("p", pass);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
<<<<<<< HEAD
                    {               
                             dataKurir = new kurir(
                            //Convert.ToInt32(reader["id_admin"]),
=======
                    {
                      
                        SessionUser.IdUser = Convert.ToInt32(reader["id_user"]);
                        SessionUser.Username = reader["username"].ToString();
                        SessionUser.Nama = reader["nama"].ToString();
                        SessionUser.NoHp = reader["no_hp"].ToString();
                        SessionUser.Email = reader["email"].ToString();
                        SessionUser.IdRole = Convert.ToInt32(reader["id_role"]);
                        SessionUser.IsReady = Convert.ToBoolean(reader["is_ready"]); 
                        isSuccess = true;
                    }
                }
            }
        }
        return isSuccess;
>>>>>>> a92420899f7b67f66023c890f5449b4e1c336052
        }

    }