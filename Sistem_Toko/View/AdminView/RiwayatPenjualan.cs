using Sistem_Toko.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistem_Toko.View.AdminView
{
    public partial class Riwayat_Stok : Form
    {
        public Riwayat_Stok()
        {
            InitializeComponent();
            IsiComboBulan();
        }

        private void IsiComboBulan()
        {
            CmbBulan.Items.Add("Semua Bulan");
            CmbBulan.Items.Add("Januari");
            CmbBulan.Items.Add("Februari");
            CmbBulan.Items.Add("Maret");
            CmbBulan.Items.Add("April");
            CmbBulan.Items.Add("Mei");
            CmbBulan.Items.Add("Juni");
            CmbBulan.Items.Add("Juli");
            CmbBulan.Items.Add("Agustus");
            CmbBulan.Items.Add("September");
            CmbBulan.Items.Add("Oktober");
            CmbBulan.Items.Add("November");
            CmbBulan.Items.Add("Desember");
            CmbBulan.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MuatDataRiwayat(null, null);
        }

        private void MuatDataRiwayat(int? bulan, int? tahun)
        {
            try
            {
                DataTable dt = KasirContext.GetRiwayatPenjualan(bulan, tahun);

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

        private void Btn_Filter_Click(object sender, EventArgs e)
        {
            // Bulan: index 0 = "Semua Bulan", index 1 = Januari (bulan 1), dst.
            int? bulan = CmbBulan.SelectedIndex > 0 ? CmbBulan.SelectedIndex : (int?)null;
            int tahun = (int)NumTahun.Value;

            MuatDataRiwayat(bulan, tahun);
        }


        private void Btn_Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
