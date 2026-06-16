using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using Sistem_Toko.Helpers;
using System;
using System.Data;

namespace Sistem_Toko.Model
{
    public class KasirContext
    {
        public static Kasir CekLoginKasir(string username, string password)
        {
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT * FROM v_data_kasir WHERE username = @u AND password = @p;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("u", username);
                    cmd.Parameters.AddWithValue("p", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            SessionUser.Id = Convert.ToInt32(reader["id_user"]);
                            SessionUser.Username = reader["username"].ToString();
                            SessionUser.Nama = reader["nama"].ToString();
                            SessionUser.Email = reader["email"].ToString();
                            SessionUser.Alamat = reader["alamat"].ToString();
                            SessionUser.Role = reader["nama_role"].ToString();
                            SessionUser.IdRole = 2;


                            return new Kasir(
                                SessionUser.Id,
                                SessionUser.Nama,
                                SessionUser.Username,
                                reader["password"].ToString()
                            );
                        }
                    }
                }
            }
            return null;
        }

        public static int BuatOrderBaru(NpgsqlConnection conn, NpgsqlTransaction transaction, int idUser, string metodeBayar, string metodeKirim)
        {
            string sqlOrder = "SELECT fn_buat_order_baru(@idUser, @metodeBayar, @metodeKirim);";
            using (var cmdOrder = new NpgsqlCommand(sqlOrder, conn, transaction))
            {
                cmdOrder.Parameters.AddWithValue("idUser", idUser);
                cmdOrder.Parameters.AddWithValue("metodeBayar", metodeBayar);
                cmdOrder.Parameters.AddWithValue("metodeKirim", metodeKirim);

                return Convert.ToInt32(cmdOrder.ExecuteScalar());
            }
        }

        public static void TambahDetailOrder(NpgsqlConnection conn, NpgsqlTransaction transaction, int idOrder, int idProduk, int jumlah, decimal harga)
        {
            string sqlDetail = "SELECT fn_tambah_detail_order(@idOrder, @idProduk, @jumlah, @harga);";
            using (var cmdDetail = new NpgsqlCommand(sqlDetail, conn, transaction))
            {
                cmdDetail.Parameters.AddWithValue("idOrder", idOrder);
                cmdDetail.Parameters.AddWithValue("idProduk", idProduk);
                cmdDetail.Parameters.AddWithValue("jumlah", jumlah);
                cmdDetail.Parameters.AddWithValue("harga", harga);

                cmdDetail.ExecuteScalar();
            }
        }

        public static DataTable GetRiwayatPenjualan(int? bulan, int? tahun)
        {
            using var conn = connectDB.GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();

            string sql = "SELECT * FROM v_riwayat_penjualan WHERE 1=1";
            if (bulan.HasValue)
                sql += " AND EXTRACT(MONTH FROM \"Tanggal Order\") = @bulan";
            if (tahun.HasValue)
                sql += " AND EXTRACT(YEAR FROM \"Tanggal Order\") = @tahun";
            
            sql += " ORDER BY \"Tanggal Order\" DESC";

            using var cmd = new NpgsqlCommand(sql, conn);
            if (bulan.HasValue)
                cmd.Parameters.AddWithValue("bulan", bulan.Value);
            if (tahun.HasValue)
                cmd.Parameters.AddWithValue("tahun", tahun.Value);

            var adapter = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }
}