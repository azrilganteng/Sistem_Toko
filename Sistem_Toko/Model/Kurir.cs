using System;

namespace Sistem_Toko.Model
{
    public class Kurir : User
    {
        public bool IsReady { get; set; }
        public string PlatNo { get; set; }

        public Kurir(int id, string nama) : base(id, nama, "", "")
        {
            this.IsReady = true;
        }

        public Kurir(int id, string nama, string username, string password, bool isReady)
             : base(id, nama, username, password)
        {
            this.IsReady = isReady;
        }

        public override bool Login(string username, string password)
        {
            return false;
        }
    }
}