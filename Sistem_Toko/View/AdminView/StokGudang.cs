using Sistem_Toko.Model;
using System;
using System.Data;
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
                DataTable dt = ProdukContext.GetStokGudang();

                // Hide boolean status column
                if (dt.Columns.Contains("status"))
                    dt.Columns.Remove("status");

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

        private void Btn_Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
