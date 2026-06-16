using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using Sistem_Toko.Helpers;

namespace Sistem_Toko.Model
{
    public class UserContext
    {
        /// <summary>
        /// Cek username & password via v_profil_user.
        /// Return (id_user, nama, roles[]) jika valid, null jika salah.
        /// </summary>
        public static (int IdUser, string Nama, string Username, List<string> Roles)? CekCredentials(string username, string password)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            // Validasi credentials dari tabel users langsung
            string sqlCek = "SELECT * FROM v_profil_user WHERE username = @u AND password = @p AND is_active = true;";
            using var cmdCek = new NpgsqlCommand(sqlCek, conn);
            cmdCek.Parameters.AddWithValue("u", username);
            cmdCek.Parameters.AddWithValue("p", password);

            int idUser; string nama; string uname;
            using (var r = cmdCek.ExecuteReader())
            {
                if (!r.Read()) return null;
                idUser = Convert.ToInt32(r["id_user"]);
                nama = r["nama"].ToString();
                uname = r["username"].ToString();
            }

            // Ambil semua role user tersebut
            var roles = new List<string>();
            string sqlRoles = @"SELECT r.nama_role FROM kewenangan k 
                                JOIN roles r ON r.id_role = k.id_role
                                WHERE k.id_user = @id;";
            using var cmdRoles = new NpgsqlCommand(sqlRoles, conn);
            cmdRoles.Parameters.AddWithValue("id", idUser);
            using (var r = cmdRoles.ExecuteReader())
                while (r.Read()) roles.Add(r["nama_role"].ToString());

            return (idUser, nama, uname, roles);
        }

        public static User Login(string username, string password)
        {
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT * FROM v_profil_user
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

        public static Admin LoginAdmin(string user, string pass)
        {
            Admin dataAdmin = null;

            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"select * from v_data_admin WHERE username = @u AND password = @p";

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

                            SessionUser.Id = dataAdmin.ID;
                            SessionUser.Username = dataAdmin.Username;
                            SessionUser.Nama = dataAdmin.Nama;
                            SessionUser.Role = "Admin";
                            SessionUser.IdRole = 1;
                            try { SessionUser.Email = reader["email"].ToString(); } catch { }
                            try { SessionUser.Alamat = reader["alamat"].ToString(); } catch { }
                            try { SessionUser.NoHp = reader["no_hp"].ToString(); } catch { }
                        }
                    }
                }
            }
            return dataAdmin;
        }

        public static DataTable GetDaftarKaryawan()
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sql = @"SELECT * FROM v_daftar_karyawan WHERE is_active = true";
            var adapter = new NpgsqlDataAdapter(sql, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static Dictionary<string, string> GetKaryawanById(int userId)
        {
            var data = new Dictionary<string, string>();
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sqlUser = "SELECT * FROM v_profil_user WHERE id_user = @id";
            using (var cmdUser = new NpgsqlCommand(sqlUser, conn))
            {
                cmdUser.Parameters.AddWithValue("id", userId);
                using var r = cmdUser.ExecuteReader();
                if (r.Read())
                {
                    data["username"] = r["username"].ToString();
                    data["password"] = r["password"].ToString();
                    data["nama"] = r["nama"].ToString();
                    data["no_hp"] = r["no_hp"].ToString();
                    data["alamat"] = r["alamat"].ToString();
                    data["email"] = r["email"].ToString();
                }
            }
            return data;
        }

        public static List<string> GetRolesKaryawan(int userId)
        {
            List<string> roles = new List<string>();
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sqlRoles = "SELECT r.nama_role FROM kewenangan k JOIN roles r ON k.id_role = r.id_role WHERE k.id_user = @id";
            using (var cmdRoles = new NpgsqlCommand(sqlRoles, conn))
            {
                cmdRoles.Parameters.AddWithValue("id", userId);
                using var r = cmdRoles.ExecuteReader();
                while (r.Read())
                {
                    roles.Add(r["nama_role"].ToString());
                }
            }
            return roles;
        }

        public static void UpdateKaryawan(int userId, string username, string password, string nama, string no_hp, string alamat, string email)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sqlUpdate = @"
                UPDATE users 
                SET username = @username, password = @password, nama = @nama, 
                    no_hp = @no_hp, alamat = @alamat, email = @email
                WHERE id_user = @id";

            using (var cmdUpdate = new NpgsqlCommand(sqlUpdate, conn))
            {
                cmdUpdate.Parameters.AddWithValue("username", username);
                cmdUpdate.Parameters.AddWithValue("password", password);
                cmdUpdate.Parameters.AddWithValue("nama", nama);
                cmdUpdate.Parameters.AddWithValue("no_hp", no_hp);
                cmdUpdate.Parameters.AddWithValue("alamat", alamat);
                cmdUpdate.Parameters.AddWithValue("email", email);
                cmdUpdate.Parameters.AddWithValue("id", userId);
                cmdUpdate.ExecuteNonQuery();
            }
        }

        public static void HapusKewenanganKaryawan(int userId)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            using (var cmdDel = new NpgsqlCommand("DELETE FROM kewenangan WHERE id_user = @id", conn))
            {
                cmdDel.Parameters.AddWithValue("id", userId);
                cmdDel.ExecuteNonQuery();
            }
        }

        public static void InsertRoleKaryawan(int idUser, string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName) || roleName.ToLower() == "tidak ada") return;

            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sqlRole = @"
                INSERT INTO kewenangan (id_user, id_role)
                SELECT @id_user, id_role FROM roles WHERE nama_role ILIKE @role";

            using var cmd = new NpgsqlCommand(sqlRole, conn);
            cmd.Parameters.AddWithValue("id_user", idUser);
            cmd.Parameters.AddWithValue("role", roleName);
            cmd.ExecuteNonQuery();
        }

        public static void NonaktifkanKaryawan(int userId)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            using (var cmdUser = new NpgsqlCommand("UPDATE users SET is_active = false, is_ready = false WHERE id_user = @id", conn))
            {
                cmdUser.Parameters.AddWithValue("id", userId);
                cmdUser.ExecuteNonQuery();
            }
        }

        public static int TambahKaryawan(string username, string password, string nama, string no_hp, string alamat, string email)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sqlUser = @"SELECT fn_tambah_user(@username, @password, @nama, @no_hp, @alamat, @email)";

            int newUserId;
            using (var cmdUser = new NpgsqlCommand(sqlUser, conn))
            {
                cmdUser.Parameters.AddWithValue("username", username);
                cmdUser.Parameters.AddWithValue("password", password);
                cmdUser.Parameters.AddWithValue("nama", nama);
                cmdUser.Parameters.AddWithValue("no_hp", no_hp);
                cmdUser.Parameters.AddWithValue("alamat", alamat);
                cmdUser.Parameters.AddWithValue("email", email);
                newUserId = Convert.ToInt32(cmdUser.ExecuteScalar());
            }
            return newUserId;
        }

        public static void GetUserInfo(int id)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            var cmd = new NpgsqlCommand("SELECT * FROM fn_get_user_info(@id)", conn);
            cmd.Parameters.AddWithValue("id", id);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    SessionUser.Nama = reader["nama"].ToString();
                    SessionUser.NoHp = reader["no_hp"].ToString();
                }
            }
        }

        public static Dictionary<string, string> GetProfilUser(int userId)
        {
            var data = new Dictionary<string, string>();
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sql = "SELECT * FROM v_profil_user WHERE id_user = @id;";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", userId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                data["id_user"] = reader["id_user"].ToString();
                data["username"] = reader["username"].ToString();
                data["nama"] = reader["nama"].ToString();
                data["email"] = reader["email"].ToString();
                data["no_hp"] = reader["no_hp"].ToString();
                data["alamat"] = reader["alamat"].ToString();
                data["role"] = string.IsNullOrEmpty(reader["roles"].ToString())
                    ? SessionUser.Role
                    : reader["roles"].ToString();
            }
            return data;
        }

        public static void UpdateProfil(int userId, string nama, string username, string email, string noHp, string alamat)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sql = @"UPDATE users 
                           SET nama = @nama, username = @username, 
                               email = @email, no_hp = @no_hp, alamat = @alamat
                           WHERE id_user = @id";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("nama", nama);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("email", (object)email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("no_hp", (object)noHp ?? DBNull.Value);
            cmd.Parameters.AddWithValue("alamat", (object)alamat ?? DBNull.Value);
            cmd.Parameters.AddWithValue("id", userId);
            cmd.ExecuteNonQuery();

            // Update session
            SessionUser.Nama = nama;
            SessionUser.Username = username;
            SessionUser.Email = email;
            SessionUser.NoHp = noHp;
            SessionUser.Alamat = alamat;
        }
    }
}