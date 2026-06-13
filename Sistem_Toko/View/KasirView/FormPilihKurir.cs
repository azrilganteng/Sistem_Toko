using Sistem_Toko.Controller;
using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistem_Toko.View.KasirView
{
    public partial class FormPilihKurir : Form
    {
        public Kurir PilKurir { get; private set; }
        public string AlamatKirim { get; private set; }

        public FormPilihKurir()
        {
            InitializeComponent();

            NamaToko.Text = "TOKO TANI SAMUDRA\n";
            ListKurirReady();
        }

        private void ListKurirReady()
        {
            KurirController kc = new KurirController();
            var listKurir = kc.GetKurir();

            CboKurir.DataSource = listKurir;
            CboKurir.DisplayMember = "Nama";
            CboKurir.ValueMember = "ID";
        }

        private void Kirmkan_Click(object sender, EventArgs e)
        {
            if (CboKurir.SelectedItem == null || string.IsNullOrWhiteSpace(TxtAlamat.Text))
            {
                MessageBox.Show("Silakan pilih kurir dan isi alamat pengiriman terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CboKurir.SelectedItem is Kurir kurirTerpilih)
            {
                PilKurir = kurirTerpilih;
                AlamatKirim = TxtAlamat.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal memproses data kurir yang dipilih!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPilihKurir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}