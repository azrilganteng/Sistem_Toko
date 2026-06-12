using Npgsql;
using Sistem_Toko.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistem_Toko.View.AdminView
{
    public partial class Riwayat_Stok : Form
    {
        public Riwayat_Stok()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MuatDataRiwayat();
        }

        private void MuatDataRiwayat()
        {
            try
            {
                using var conn = connectDB.GetConn();

                // Riwayat transaksi: orders + detail_order + nama produk
                string sql = @"SELECT * FROM riwayat_penjualan";

                var adapter = new NpgsqlDataAdapter(sql, conn);
                var dt = new DataTable();
                adapter.Fill(dt);

                Grid_RiwayatPenjualan.DataSource = dt;
                Grid_RiwayatPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Grid_RiwayatPenjualan.ReadOnly = true;
                Grid_RiwayatPenjualan.AllowUserToAddRows = false;
                Grid_RiwayatPenjualan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat penjualan: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
