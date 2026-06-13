using System;
using System.Collections.Generic;

namespace Sistem_Toko.Model
{
    public class Kasir : User
    {
        private List<Detail_orders> ListKeranjang = new List<Detail_orders>();

        public Kasir(int id, string nama, string username, string password)
            : base(id, nama, username, password)
        {
        }

        public override bool Login(string username, string password)
        {
            return false;
        }

        private Detail_orders CariDiKeranjang(string namaProduk)
        {
            foreach (Detail_orders item in ListKeranjang)
            {
                if (item.ProdukItem.NamaProduk == namaProduk)
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

        public string TambahKeKeranjang(Produk pilProduk)
        {
            Detail_orders exist = CariDiKeranjang(pilProduk.NamaProduk);

            if (exist != null)
            {
                if (exist.Qty < pilProduk.Stok)
                {
                    exist.TambahQty();
                    return "SUKSES";
                }
                else
                {
                    return $"Stok '{pilProduk.NamaProduk}' tidak mencukupi!";
                }
            }
            else
            {
                if (pilProduk.Stok > 0)
                {
                    ListKeranjang.Add(new Detail_orders(pilProduk, 1));
                    return "SUKSES";
                }
                else
                {
                    return $"Stok '{pilProduk.NamaProduk}' habis!";
                }
            }
        }
    }
}