using Npgsql;
using System;
using System.Data;
using Sistem_Toko.Helpers; // Mengarah ke ConnectDB / TokoDbContext kamu

namespace Sistem_Toko.Model
{
    public class UserContext
    {
        public static User Login(string username, string password)
        {
            using (var conn = connectDB.GetConn()) 
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT id_user, nama, username, password 
                               FROM ""user"" 
                               WHERE username = @username AND password = @password;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idUser = Convert.ToInt32(reader["id_user"]);
                            string nama = reader["nama"].ToString();
                            string user = reader["username"].ToString();
                            string pass = reader["password"].ToString();

                            return new Kasir(idUser, nama, user, pass);
                        }
                    }
                }
            }
            return null; 
        }
    }
}