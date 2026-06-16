using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Sistem_Toko.Helpers;

namespace Sistem_Toko.Model
{
    public class KasirContext
    {
        public static Kasir CekLoginKasir(string username, string password)
        {
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT * FROM v_data_kasir WHERE username = @username AND password = @password;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar).Value = username;
                    cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = password;

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
                            try { SessionUser.NoHp = reader["no_hp"].ToString(); } catch { }


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

        /// <summary>
        /// Transaksi penjualan lengkap via 1 stored procedure.
        /// Atomicity: Pengiriman + Order + Detail + Stok dalam 1 CALL.
        /// </summary>
        public static int TransaksiPenjualan(NpgsqlConnection conn, NpgsqlTransaction transaction,
            int idKasir, int idCustomer, string metodeBayar,
            int idKurir, List<Detail_orders> listBarang)
        {
            bool metodeBayarBool = metodeBayar.Equals("Cash", StringComparison.OrdinalIgnoreCase);

            // Build arrays dari list barang
            int[] produkIds = listBarang.Select(b => b.ProdukItem.Id).ToArray();
            int[] produkJumlahs = listBarang.Select(b => b.Qty).ToArray();
            decimal[] produkHargas = listBarang.Select(b => (decimal)b.ProdukItem.Harga).ToArray();

            string sql = @"CALL p_transaksi_penjualan(
                @idUser, @idCustomer, @metodeBayar, @idOrder,
                @idKurir, @produkIds, @produkJumlahs, @produkHargas);";

            using (var cmd = new NpgsqlCommand(sql, conn, transaction))
            {
                cmd.Parameters.AddWithValue("idUser", idKasir);
                cmd.Parameters.AddWithValue("idCustomer", idCustomer);
                cmd.Parameters.AddWithValue("metodeBayar", metodeBayarBool);

                var outParam = new NpgsqlParameter("idOrder", NpgsqlTypes.NpgsqlDbType.Integer)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outParam);

                cmd.Parameters.AddWithValue("idKurir", idKurir > 0 ? (object)idKurir : DBNull.Value);
                cmd.Parameters.AddWithValue("produkIds", produkIds);
                cmd.Parameters.AddWithValue("produkJumlahs", produkJumlahs);
                cmd.Parameters.AddWithValue("produkHargas", produkHargas);

                cmd.ExecuteNonQuery();
                return Convert.ToInt32(outParam.Value);
            }
        }

        public static DataTable GetRiwayatPenjualan()
        {
            return GetRiwayatPenjualan(null, null);
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