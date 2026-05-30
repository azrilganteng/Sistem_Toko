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

            // Tampilkan nama kasir di label/form title
            this.Text = "Sistem Kasir - " + _kasirActive.Nama;
        }
    }
}