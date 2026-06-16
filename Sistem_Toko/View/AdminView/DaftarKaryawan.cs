using Sistem_Toko.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistem_Toko.View.AdminView
{
    public partial class DaftarKaryawan : Form
    {
        private int selectedId = -1;

        public DaftarKaryawan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MuatDataKaryawan();
        }

        public void MuatDataKaryawan()
        {
            try
            {
                DataTable dt = UserContext.GetDaftarKaryawan();

                // Hide boolean columns
                HapusKolomBoolean(dt, "is_active");
                HapusKolomBoolean(dt, "is_ready");

                Grid_Daftar_Karyawan.DataSource = dt;
                Grid_Daftar_Karyawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Grid_Daftar_Karyawan.ReadOnly = true;
                Grid_Daftar_Karyawan.AllowUserToAddRows = false;
                Grid_Daftar_Karyawan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                selectedId = -1; // Reset selection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data karyawan: " + ex.Message);
            }
        }

        private void Grid_Daftar_Karyawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Grid_Daftar_Karyawan.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }

        private void Btn_Tambah_Click(object sender, EventArgs e)
        {
            TambahKaryawan formTambah = new TambahKaryawan(this);
            formTambah.ShowDialog();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih karyawan yang ingin diedit dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditKaryawan formEdit = new EditKaryawan(selectedId, this);
            formEdit.ShowDialog();
        }

        private void Btn_Hapus_Click(object sender, EventArgs e)
        {
            HapusKaryawan formHapus = new HapusKaryawan(selectedId, this);
            formHapus.ShowDialog();
        }

        private void Btn_Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static void HapusKolomBoolean(DataTable dt, string columnName)
        {
            if (dt.Columns.Contains(columnName))
                dt.Columns.Remove(columnName);
        }
    }
}
