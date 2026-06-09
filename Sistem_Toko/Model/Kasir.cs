using Sistem_Toko.Controller;
using System;
namespace Sistem_Toko.Model;

public class Kasir : User
{
    private List<Detail_orders> ListKeranjang = new List<Detail_orders>();
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
            this.ID = kasir.ID;
            this.Nama = kasir.Nama;
            this.Username = kasir.Username;
            this.Password = kasir.Password;
            return true;
        }
        return false;
    }

    private Detail_orders CariDiKeranjang(string produk)
    {
        foreach (Detail_orders item in ListKeranjang)
        {
            if (item.ProdukItem.NamaProduk == produk)
            {
                return item; 
            }
        }
        return null;
    }
    public List<Detail_orders> GetListKeranjang()
    {
        return this.ListKeranjang;
    }
    public void Keranjang(Produk PilProduk)
    {
        Detail_orders Exist = CariDiKeranjang(PilProduk.NamaProduk);

        if (Exist != null)
        {
            if (Exist.Qty < PilProduk.Stok)
            {
                Exist.TambahQty();
            }
            else
            {
                MessageBox.Show($"Stok '{PilProduk.NamaProduk}' tidak mencukupi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        else
        {
            if (PilProduk.Stok > 0)
            {
                ListKeranjang.Add(new Detail_orders(PilProduk, 1));
            }
            else
            {
                MessageBox.Show($"Stok '{PilProduk.NamaProduk}' habis!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

    }
}