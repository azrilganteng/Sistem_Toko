using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem_Toko.Model;

public abstract class User
{
    public int ID { get; protected set; }
    public string Nama { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public User(int id, string nama, string username, string password)
    {
        this.ID = id;
        this.Nama = nama;
        this.Username = username;
        this.Password = password;
    }

    public abstract bool Login(string username,string password); 
}