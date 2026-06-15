using Sistem_Toko.Model;
using System.Collections.Generic;
using System.Data;

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

        public bool UpdateStatusPengiriman(int idPengiriman, string statusBaru)
        {
            return KurirContext.UpdateStatusKeDatabase(idPengiriman, statusBaru);
        }
        public List<Pengiriman> GetPengirimanKurirAktif(int idKurir)
        {
            return PengirimanContext.GetPengirimanByKurir(idKurir);
        }
        public DataTable GetDetailBarangOrder(int idOrder)
        {
            return PengirimanContext.GetDetailBarangOrder(idOrder);
        }
    }
}