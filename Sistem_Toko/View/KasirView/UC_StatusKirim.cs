using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistem_Toko.Model;

namespace Sistem_Toko.View.KasirView
{
    public partial class UC_StatusKirim : UserControl
    {
        private Pengiriman _data;

        public UC_StatusKirim(Pengiriman data)
        {
            InitializeComponent();

            this._data = data;
            TampilStatus();
        }

        private void TampilStatus()
        {
            LblInfo.Text = $"Pengiriman: {_data.IdPengiriman} | Kurir: {_data.NamaKurir}\nAlamat: {_data.Alamat} ({_data.TanggalKirim:dd/MM/yyyy})";

            // status_pengiriman is boolean: True = Selesai, False = Proses
            bool isSelesai = _data.StatusPengiriman.Equals("True", StringComparison.OrdinalIgnoreCase)
                          || _data.StatusPengiriman.Equals("Selesai", StringComparison.OrdinalIgnoreCase);

            LblStatus.Text = isSelesai ? "Selesai" : "Proses";

            if (isSelesai)
            {
                LblStatus.BackColor = Color.LightGreen;
                LblStatus.ForeColor = Color.Green;
            }
            else
            {
                LblStatus.BackColor = Color.Khaki;
                LblStatus.ForeColor = Color.DarkGoldenrod;
            }
        }

        
        private void UC_StatusKirim_Load(object sender, EventArgs e)
        {

        }
    }
}
