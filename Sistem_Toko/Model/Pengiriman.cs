using System;

namespace Sistem_Toko.Model
{
    public class Pengiriman
    {
        public int IdPengiriman { get; set; }
        public string Alamat { get; set; }
        public string StatusPengiriman { get; set; }
        public DateTime TanggalKirim { get; set; }
        public int IdUser { get; set; }

       
        public string NamaKurir { get; set; }

        public Pengiriman() { }

        public Pengiriman(int idPengiriman, string alamat, string statusPengiriman, DateTime tanggalKirim, int idUser)
        {
            this.IdPengiriman = idPengiriman;
            this.Alamat = alamat;
            this.StatusPengiriman = statusPengiriman;
            this.TanggalKirim = tanggalKirim;
            this.IdUser = idUser;
        }
    }
}