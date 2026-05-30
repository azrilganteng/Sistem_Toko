using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem_Toko.Model;

public abstract class User
{
    public int ID { get; set; }
    public string Nama { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    // Constructor untuk memudahkan mapping data
    public User(int id, string nama, string username, string password)
    {
        ID = id;
        Nama = nama;
        Username = username;
        Password = password;
    }

    public abstract void Login(); // Method wajib ada
}