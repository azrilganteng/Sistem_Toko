using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.Text;
namespace Sistem_Toko
{
    public class Detail_orders
    {
        public int Id { get; set; }
        public Produk ProdukItem { get; set; }
        public int Qty { get; set; }
        public int HargaSatuan { get; set; }

        public Detail_orders(Produk produk, int qty)
        {
            this.ProdukItem = produk;
            this.Qty = qty;
            this.HargaSatuan = produk.Harga;
        }

        public void TambahQty()
        {
            Qty++;
        }
    }
}