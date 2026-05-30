using System;
namespace Sistem_Toko.Model;

public class Kasir : User
{
    public Kasir(int id, string nama, string username, string password, string kodeKasir)
        : base(id, nama, username, password)
    {
    }

    public override void Login()
    {
       
    }
}