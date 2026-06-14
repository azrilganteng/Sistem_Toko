using Sistem_Toko.Model;
using System;
using System.Windows.Forms;

namespace Sistem_Toko.View.AdminView
{
    public partial class HapusKaryawan : Form
    {
        private int initialUserId;
        private DaftarKaryawan parentForm;

        public HapusKaryawan(int id, DaftarKaryawan parent)
        {
            InitializeComponent();
            this.initialUserId = id;
            this.parentForm = parent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (initialUserId != -1)
            {
                TextBox_ID.Text = initialUserId.ToString();
            }
            TextBox_ID.ReadOnly = false;
        }

        private void Btn_Simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_ID.Text))
            {
                MessageBox.Show("Masukkan ID Karyawan yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TextBox_ID.Text, out int userIdToHapus))
            {
                MessageBox.Show("ID Karyawan harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Apakah Anda yakin ingin menghapus Karyawan dengan ID: {userIdToHapus}?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Soft delete dengan mengupdate is_aktif menjadi false
                    // Tidak perlu menghapus dari tabel kewenangan karena user hanya dinonaktifkan
                    UserContext.NonaktifkanKaryawan(userIdToHapus);

                    MessageBox.Show("Karyawan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    parentForm.MuatDataKaryawan();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
