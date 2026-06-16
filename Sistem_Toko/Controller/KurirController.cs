using Sistem_Toko.Model;
using System.Collections.Generic;

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

                string sql = "SELECT * FROM v_kurir_ready;";
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
            return KurirContext.GetKurirReady();
        }

        public List<Pengiriman> GetAllPengiriman()
        {
            return PengirimanContext.GetAll();
        }
    }
}
