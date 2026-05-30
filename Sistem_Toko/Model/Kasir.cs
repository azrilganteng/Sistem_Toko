using System;
namespace Sistem_Toko.Model;

public class Kasir : User
{
    // Tambahan atribut khusus kasir jika ada (berdasarkan ERD)
    public string KodeKasir { get; set; }

    public Kasir(int id, string nama, string username, string password, string kodeKasir)
        : base(id, nama, username, password)
    {
        KodeKasir = kodeKasir;
    }

    public override void Login()
    {
        // Logika tambahan saat kasir login
    }
}