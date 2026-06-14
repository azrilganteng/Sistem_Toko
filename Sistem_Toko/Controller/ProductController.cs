using Npgsql;
using Sistem_Toko.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Sistem_Toko.Model;

namespace Sistem_Toko.Controller
{
    public class ProductController
    {
        public List<Produk> GetAll()
        {
            return ProdukContext.GetProductFromDatabase();
        }

        public static List<Produk> GetProductFromDatabase()
        {
            return ProdukContext.GetProductFromDatabase();
        }
        public List<Produk> GetProduct(int idKategori)
        {
            return ProdukContext.GetProductKategory(idKategori);
        }
    }
}
