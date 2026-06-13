using Sistem_Toko.Controller;
using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace Sistem_Toko.View.KasirView
{
    public partial class FormStatusPengiriman : Form
    {
        private FormKasir _formKasir;

        public FormStatusPengiriman(FormKasir formKasir)
        {
            InitializeComponent();
            this._formKasir = formKasir;
            TampilkanRiwayat("Proses");
        }

        public void TampilkanRiwayat(string status)
        {
            FlpStatus.Controls.Clear();

            PengirimanController pc = new PengirimanController();

            var listByStatus = pc.GetStatus(status);

            foreach (var item in listByStatus)
            {
                UC_StatusKirim ucKirim = new UC_StatusKirim(item);
                FlpStatus.Controls.Add(ucKirim);
            }
        }

        private void FormStatusPengiriman_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_formKasir != null)
            {
                _formKasir.Show();
                _formKasir.TampilanKasir();
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OngoingBtn_Click(object sender, EventArgs e)
        {
            TampilkanRiwayat("Proses");
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            TampilkanRiwayat("Selesai");
        }
    }
}
