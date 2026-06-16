using Npgsql;
using Sistem_Toko.Helpers;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sistem_Toko.Model
{
    public class CustomerContext
    {
        /// <summary>
        /// Ambil semua customer dari database.
        /// </summary>
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> list = new List<Customer>();

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "SELECT * FROM v_customer;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Customer
                        {
                            IdCustomer = Convert.ToInt32(reader["id_customer"]),
                            Nama = reader["nama_customer"].ToString(),
                            NoHp = reader["no_hp"]?.ToString() ?? "",
                            Alamat = reader["alamat"]?.ToString() ?? ""
                        });
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Cari customer berdasarkan nama (case-insensitive exact match).
        /// Return Customer jika ditemukan, null jika tidak.
        /// </summary>
        public static Customer CariByNama(string nama)
        {
            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "SELECT * FROM v_customer WHERE LOWER(nama_customer) = LOWER(@nama) LIMIT 1;";

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

                string sql = "SELECT fn_tambah_customer(@nama, @noHp, @alamat);";

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
