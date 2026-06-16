using Npgsql;
using Sistem_Toko.Helpers;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sistem_Toko.Model
{
    public class OrderContext
    {
        public static bool UpdateStok(int idKasirAktif, string metodeBayar, string metodeKirim, int idKurir, string alamat, int idCustomer, List<Detail_orders> listBarang)
        {
            if (listBarang.Count == 0)
            {
                throw new Exception("Gagal Transaksi: Keranjang belanja kosong!");
            }

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        KasirContext.TransaksiPenjualan(conn, transaction, idKasirAktif, idCustomer, metodeBayar, idKurir, listBarang);
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
    }
}
