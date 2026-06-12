using Npgsql;
using Sistem_Toko.Helpers;
using System;
using System.Windows.Forms;

namespace Sistem_Toko.View.AdminView
{
    public partial class HapusKaryawan : Form
    {
        private int userId;
        private DaftarKaryawan parentForm;

        public HapusKaryawan(int id, DaftarKaryawan parent)
        {
            InitializeComponent();
            this.userId = id;
            this.parentForm = parent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox_ID.Text = userId.ToString();
            TextBox_ID.ReadOnly = true;
        }

        private void Btn_Simpan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Apakah Anda yakin ingin menghapus Karyawan dengan ID: {userId}?", 
                "Konfirmasi Hapus", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using var conn = connectDB.GetConn();
                    
                    // Soft delete dengan mengupdate is_aktif menjadi false
                    // Tidak perlu menghapus dari tabel kewenangan karena user hanya dinonaktifkan
                    using (var cmdUser = new NpgsqlCommand("UPDATE users SET is_aktif = false WHERE id_user = @id", conn))
                    {
                        cmdUser.Parameters.AddWithValue("id", userId);
                        cmdUser.ExecuteNonQuery();
                    }

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
    }
}
