using System.Collections.Generic;
using Sistem_Toko.Model;

namespace Sistem_Toko.Controller
{
    public class PengirimanController
    {
        //public List<Pengiriman> GetAllHistory()
        //{
        //    return PengirimanContext.GetHistoryPengiriman();
        //}
        public List<Pengiriman> GetStatus
            (string status)
        {
            return PengirimanContext.GetStatusPengiriman(status);
        }
        public List<Pengiriman> GetAllPengiriman()
        {
            return PengirimanContext.GetAll();
        }

        public void UpdateStatusPengiriman(Pengiriman pengiriman)
        {
            // kode update
        }
    }



}