using Sistem_Toko.Controller;
using System;
namespace Sistem_Toko.Model;

public class Kasir : User
{
    public Kasir(int id, string nama, string username, string password)
        : base(id, nama, username, password)
    {
    }

    public override bool Login(string username, string password)
    {
       AuthController auth = new AuthController();
       Kasir kasir = auth.LoginKasir(username, password);
        if (kasir != null)
        {
            this.Nama = kasir.Nama;
            this.Username = kasir.Username;
            this.Password = kasir.Password;
            return true;
        }
        return false;
    }
}