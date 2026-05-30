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
        }

        public void TampilanKasir()
        {
            // Contoh menampilkan nama kasir di label
            LblToko.Text = "TOKO TANI SAMUDRA\n";
            LblKasir.Text = "Selamat Datang Kasir: " + _kasirActive.Nama;
        }
    }
}