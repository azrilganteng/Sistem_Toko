using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using Sistem_Toko.Helpers;

namespace Sistem_Toko.Model
{
    public class PengirimanContext
    {
        public static List<Pengiriman> GetStatusPengiriman(string status)
        {
            List<Pengiriman> list = new List<Pengiriman>();

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT id_pengiriman, alamat, status_pengiriman, tanggal_kirim, id_order, id_user 
                               FROM pengiriman 
                               WHERE status_pengiriman = @status;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("status", status);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pengiriman p = new Pengiriman
                            {
                                IdPengiriman = Convert.ToInt32(reader["id_pengiriman"]),
                                Alamat = reader["alamat"].ToString(),
                                StatusPengiriman = reader["status_pengiriman"].ToString(),
                                TanggalKirim = ((DateOnly)reader["tanggal_kirim"]).ToDateTime(TimeOnly.MinValue),
                                IdOrder = Convert.ToInt32(reader["id_order"]),
                                IdUser = Convert.ToInt32(reader["id_user"])
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }

        public static List<Pengiriman> GetAll()
        {
            List<Pengiriman> list = new List<Pengiriman>();

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sql = @"SELECT id_pengiriman,
                              alamat,
                              status_pengiriman,
                              tanggal_kirim,
                              id_order,
                              id_user
                       FROM pengiriman";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pengiriman p = new Pengiriman
                        {
                            IdPengiriman = Convert.ToInt32(reader["id_pengiriman"]),
                            Alamat = reader["alamat"].ToString(),
                            StatusPengiriman = reader["status_pengiriman"].ToString(),
                            TanggalKirim = ((DateOnly)reader["tanggal_kirim"])
                                            .ToDateTime(TimeOnly.MinValue),
                            IdOrder = Convert.ToInt32(reader["id_order"]),
                            IdUser = Convert.ToInt32(reader["id_user"])
                        };

                        list.Add(p);
                    }
                }
            }

            return list;
        }


        public static void SimpanDataPengiriman(NpgsqlConnection conn, NpgsqlTransaction transaction, int idOrder, int idKurir, string alamat)
        {
            string sqlPengiriman = @"
                INSERT INTO pengiriman (alamat, status_pengiriman, tanggal_kirim, id_order, id_user) 
                VALUES (@alamat, 'Proses', CURRENT_DATE, @idOrder, @idKurir);";

            using (var cmdKirim = new NpgsqlCommand(sqlPengiriman, conn, transaction))
            {
                cmdKirim.Parameters.AddWithValue("alamat", alamat);
                cmdKirim.Parameters.AddWithValue("idOrder", idOrder);
                cmdKirim.Parameters.AddWithValue("idKurir", idKurir);

                cmdKirim.ExecuteNonQuery();
            }

        }
    }
}