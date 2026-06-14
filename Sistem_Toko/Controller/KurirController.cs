using Npgsql;
using Sistem_Toko.Helpers;
using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Sistem_Toko.Controller
{
    public class KurirController
    {
        public List<Kurir> GetKurir()
        {
            List<Kurir> list = new List<Kurir>();
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "SELECT u.id_user, u.nama FROM users u JOIN kewenangan k ON u.id_user = k.id_user WHERE k.id_role = 3 AND u.is_ready = true;";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id_user"]);
                        string namaKurir = reader["nama"].ToString();

                        list.Add(new Kurir(
                            id,
                            namaKurir,
                            "",
                            "",
                            true
                        ));
                    }
                }
                return list;
            }

        }
        public List<Pengiriman> GetAllPengiriman()
        {
            return PengirimanContext.GetAll();
        }
    }
}
