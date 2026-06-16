using System;
using System.Collections.Generic;
using System.Data;
using Sistem_Toko.Model;

namespace Sistem_Toko.Controller
{
    public class OrderController
    {
        /// <summary>
        /// Ambil semua riwayat penjualan via v_riwayat_penjualan.
        /// </summary>
        public static DataTable GetRiwayatPenjualan()
        {
            return KasirContext.GetRiwayatPenjualan(null, null);
        }

        /// <summary>
        /// Ambil riwayat penjualan dengan filter bulan dan/atau tahun.
        /// </summary>
        public static DataTable GetRiwayatPenjualan(int? bulan, int? tahun)
        {
            return KasirContext.GetRiwayatPenjualan(bulan, tahun);
        }
    }
}
