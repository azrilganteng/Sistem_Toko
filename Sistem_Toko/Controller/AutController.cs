using Sistem_Toko.Helpers; // Tempat connectDB kamu
using Npgsql;
using Sistem_Toko.Model;

namespace Sistem_Toko.Controller;

public class AuthController
{
    public Kasir LoginKasir(string username, string password) 
    { 

        return KasirContext.CekLoginKasir(username, password);
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

    public Kurir LoginKurir(string username, string password)
    {
        return KurirContext.CekLoginKurir(username, password);
    }


}