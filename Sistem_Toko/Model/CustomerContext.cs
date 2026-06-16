using Npgsql;
using Sistem_Toko.Helpers;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sistem_Toko.Model
{
    public class CustomerContext
    {
        public static Customer CariByNama(string nama)
        {
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "SELECT * FROM customer WHERE LOWER(nama_customer) = LOWER(@nama) LIMIT 1;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nama", nama);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer
                            {
                                IdCustomer = Convert.ToInt32(reader["id_customer"]),
                                Nama = reader["nama_customer"].ToString(),
                                NoHp = reader["no_hp"]?.ToString() ?? "",
                                Alamat = reader["alamat"]?.ToString() ?? ""
                            };
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Tambah customer baru ke database.
        /// Return id_customer yang baru dibuat.
        /// </summary>
        public static int TambahCustomer(string nama, string noHp, string alamat)
        {
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "INSERT INTO customer (nama_customer, no_hp, alamat) VALUES (@nama, @noHp, @alamat) RETURNING id_customer;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nama", nama);
                    cmd.Parameters.AddWithValue("noHp", (object)noHp ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("alamat", (object)alamat ?? DBNull.Value);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}
