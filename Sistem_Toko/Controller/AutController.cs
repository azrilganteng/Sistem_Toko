using Sistem_Toko.Helpers; // Tempat connectDB kamu
using Npgsql;
using Sistem_Toko.Model;

namespace Sistem_Toko.Controller;

public class AuthController
{
    public Kasir ProsesLoginKasir(string user, string pass)
    {
        Kasir dataKasir = null;

        using (NpgsqlConnection conn = connectDB.GetConn())
        {
            string sql = @"
                SELECT u.*, r.nama_role 
                FROM ""users"" u
                JOIN kewenangan k using(id_user)
                JOIN roles r using(id_role)
                WHERE u.username = @u AND u.password = @p AND r.nama_role = 'Kasir'";

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
                            reader["password"].ToString(),
                            "KSR-" + reader["id_user"] 
                        );
                    }
                }
            }
        }
        return dataKasir;
    }
}