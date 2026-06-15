using Sistem_Toko.Helpers;
using Npgsql;
using Sistem_Toko.Model;
using System;

namespace Sistem_Toko.Controller;

public class AuthController
{
    public Kasir LoginKasir(string username, string password)
    {

        return KasirContext.CekLoginKasir(username, password);
    }

    public Admin LoginAdmin(string user, string pass)
    {
        return UserContext.LoginAdmin(user, pass);
    }

    public Kurir LoginKurir(string username, string password)
    {
        return KurirContext.CekLoginKurir(username, password);
    }
}