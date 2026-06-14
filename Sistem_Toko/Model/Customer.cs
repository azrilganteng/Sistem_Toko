using System;

namespace Sistem_Toko.Model
{
    public class Customer
    {
        public int IdCustomer { get; set; }
        public string Nama { get; set; }
        public string NoHp { get; set; }
        public string Alamat { get; set; }

        public Customer() { }

        public Customer(int idCustomer, string nama, string noHp, string alamat)
        {
            this.IdCustomer = idCustomer;
            this.Nama = nama;
            this.NoHp = noHp;
            this.Alamat = alamat;
        }
    }
}
