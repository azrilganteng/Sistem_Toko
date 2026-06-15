using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem_Toko.Helpers
{
    public class connectDB
    {
        //ini inisialisasi database
        private static string connString =
            "Host=localhost;" +
            "Port=5432;" +
            "Username=postgres;" +
            "Password=12345678;" + //password kalian
            "Database=UAS_SEM2;"; //database kalian

        public static NpgsqlConnection GetConn() //ini method manggil database
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);

            try
            {
                conn.Open();
                //Jika koneksi sudah berhasil matikan atau comment messagebox dibawah
                //MessageBox.Show("Koneksi Berhasil"); comment ini jika sudah koneksi berhasil agar tidak muncul ketika buka tab
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal di : " + ex.Message);
            }

            return conn;
        }

    }
}
