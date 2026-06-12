using Sistem_Toko.Controller;
using System;

namespace Sistem_Toko.Model
{
    public class kurir : User
    {
        private List<Detail_orders> ListKeranjang = new List<Detail_orders>();
        public kurir(int id, string nama, string username, string password)
            : base(id, nama, username, password)
        {
        }

        public override bool Login(string username, string password)
        {
            AuthController auth = new AuthController();
            kurir kurir = auth.LoginKurir(username, password);

            if (kurir != null)
            {
                this.ID = kurir.ID;
                this.Nama = kurir.Nama;
                this.Username = kurir.Username;
                this.Password = kurir.Password;
                return true;
            }
            return false;
        }
    }
}