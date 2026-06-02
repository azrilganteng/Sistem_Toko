using Sistem_Toko.Controller;
using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Sistem_Toko
{
    public partial class FormKasir : Form
    {
        private Kasir _kasirActive;

        public FormKasir(Kasir data)
        {
            InitializeComponent();
            _kasirActive = data;


            TampilanKasir();
            ShowProduk();


        }

        public void TampilanKasir()
        {
            // Contoh menampilkan nama kasir di label
            LblToko.Text = "TOKO TANI SAMUDRA\n";
            LblKasir.Text = "Selamat Datang Kasir: " + _kasirActive.Nama;
        }

        private void ShowProduk() 
        { ProductController pc = new ProductController();
          var listProduk = pc.GetProduct();
            FlpProduk.Controls.Clear();

            foreach (var item in listProduk)
            {
                UC_Produk ucProduk = new UC_Produk(item.Gambar,item.NamaProduk,item.Harga,item.Stok);
                FlpProduk.Controls.Add(ucProduk);
            }
        
        }
  
        private void FormKasir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}