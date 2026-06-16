using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Sistem_Toko.Model;
using System.Data;

namespace Sistem_Toko.Controller
{
    internal class OrderController
    {
        public static DataTable GetRiwayatPenjualan()
        {
            return KasirContext.GetRiwayatPenjualan(null, null);
        }
    }
}
