using Sistem_Toko.Controller;
using System;

namespace Sistem_Toko.Model;

public class Admin : User
{
    public Admin(int id, string nama, string username, string password)
        : base(id, nama, username, password)
    {
    }

    public override bool Login(string username, string password)
    {
        AuthController auth = new AuthController();
        Admin admin = auth.LoginAdmin(username, password);

        if (admin != null)
        {
            this.ID = admin.ID;
            this.Nama = admin.Nama;
            this.Username = admin.Username;
            this.Password = admin.Password;
            return true;
        }
        return false;
    }
}
