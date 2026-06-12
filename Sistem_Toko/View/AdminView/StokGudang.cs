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
    public partial class StokGudang : Form
    {
        public StokGudang()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MuatDataStok();
        }

        private void MuatDataStok()
        {
            try
            {
                using var conn = connectDB.GetConn();
                string sql = @"SELECT * FROM stok_gudang";

                var adapter = new NpgsqlDataAdapter(sql, conn);
                var dt = new DataTable();
                adapter.Fill(dt);

                Grid_Riwayat_Stok.DataSource = dt;
                Grid_Riwayat_Stok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Grid_Riwayat_Stok.ReadOnly = true;
                Grid_Riwayat_Stok.AllowUserToAddRows = false;
                Grid_Riwayat_Stok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data stok: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Grid_Riwayat_Stok_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
