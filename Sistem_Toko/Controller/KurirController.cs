using Npgsql;
using Sistem_Toko.Helpers;
using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Sistem_Toko.Helpers;
using System.Data;
using System;

namespace Sistem_Toko.Controller
{
    public class KurirController
    {
        /// <summary>
        /// Ambil semua kurir aktif yang ready via v_kurir_ready.
        /// </summary>
        public List<Kurir> GetAllKurir()
        {
            return KurirContext.GetKurirReady();
        }

        /// <summary>
        /// Alias GetKurir untuk kompatibilitas dengan FormPilihKurir.
        /// </summary>
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

        /// <summary>
        /// Ambil kurir yang status ready via v_kurir_ready.
        /// </summary>
        public List<Kurir> GetKurirReady()
        {
            return KurirContext.GetKurirReady();
        }

        /// <summary>
        /// Login kurir via v_data_kurir.
        /// </summary>
        public Kurir CekLoginKurir(string username, string password)
        {
            return KurirContext.CekLoginKurir(username, password);
        }

        /// <summary>
        /// Update status pengiriman (Proses/Selesai).
        /// </summary>
        public bool UpdateStatusPengiriman(int idPengiriman, string statusBaru)
        {
            return KurirContext.UpdateStatusKeDatabase(idPengiriman, statusBaru);
        }

        public List<Pengiriman> GetAllPengiriman()
        {
            return PengirimanContext.GetAll();
        }
    }
}
