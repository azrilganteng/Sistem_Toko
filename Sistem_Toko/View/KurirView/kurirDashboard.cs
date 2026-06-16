using Sistem_Toko.Helpers;
using Sistem_Toko.Model;
using System;
using System.Windows.Forms;

namespace Sistem_Toko.View.KurirView
{
    public partial class kurirDashboard : Form
    {
        public kurirDashboard()
        {
            InitializeComponent();
        }

        private void MuatDashboard(object sender, EventArgs e)
        {
            MuatInfoKurir();
        }

        private void MuatInfoKurir()
        {
            lblSelamatDatang.Text = "Selamat Datang Kurir Hebat!";
            lblNamaKurir.Text = SessionUser.Nama;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KurirForm formPengiriman = new KurirForm();
            formPengiriman.Show();
            this.Hide(); 
        }
    }
}