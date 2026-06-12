using Npgsql;
using Sistem_Toko.Helpers;
using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
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
                string sql = "select * from kurir_ready";
                var cmd = new NpgsqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    while (reader.Read())
                    {
                        list.Add(new Kurir
                        {
                            Nama = reader["nama"].ToString(),
                            PlatNo = reader["plat_no"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
