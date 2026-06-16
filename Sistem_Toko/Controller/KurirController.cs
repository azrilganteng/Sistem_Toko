using Sistem_Toko.Model;
using System.Collections.Generic;

namespace Sistem_Toko.Controller
{
    public class KurirController
    {
        public List<Kurir> GetKurir()
        {
            return KurirContext.GetKurirReady();
        }

        public List<Pengiriman> GetAllPengiriman()
        {
            return PengirimanContext.GetAll();
        }
    }
}
