using Npgsql;
using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistem_Toko.View.AdminView
{
    public partial class EditKaryawan : Form
    {
        private int userId;
        private DaftarKaryawan parentForm;

        public EditKaryawan(int id, DaftarKaryawan parent)
        {
            InitializeComponent();
            this.userId = id;
            this.parentForm = parent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MuatDataUser();
        }

        private void MuatDataUser()
        {
            try
            {
                // Load data user
                var data = UserContext.GetKaryawanById(userId);
                if (data.Count > 0)
                {
                    TextBox_Username.Text = data.ContainsKey("username") ? data["username"] : "";
                    TextBox_Password.Text = data.ContainsKey("password") ? data["password"] : "";
                    TextBox_NamaLengkap.Text = data.ContainsKey("nama") ? data["nama"] : "";
                    TextBox_NoHP.Text = data.ContainsKey("no_hp") ? data["no_hp"] : "";
                    TextBox_Alamat.Text = data.ContainsKey("alamat") ? data["alamat"] : "";
                    TextBox_Email.Text = data.ContainsKey("email") ? data["email"] : "";
                }

                // Load roles
                List<string> roles = UserContext.GetRolesKaryawan(userId);

                // Fill combo boxes (1 to 3)
                if (roles.Count > 0) ComBox_Role1.Text = roles[0];
                if (roles.Count > 1) ComBox_Role2.Text = roles[1];
                if (roles.Count > 2) ComBox_Role3.Text = roles[2];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void Btn_Simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_Username.Text))
            {
                MessageBox.Show("Username wajib diisi!");
                return;
            }

            // Validasi role duplikat
            var selectedRoles = new[] { ComBox_Role1.Text, ComBox_Role2.Text, ComBox_Role3.Text }
                .Where(r => !string.IsNullOrWhiteSpace(r) && !r.Equals("tidak ada", StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (selectedRoles.Count != selectedRoles.Select(r => r.ToLower()).Distinct().Count())
            {
                MessageBox.Show("Role sudah ada! Setiap role harus berbeda.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Update tabel users
                try
                {
                    UserContext.UpdateKaryawan(userId, TextBox_Username.Text, TextBox_Password.Text, TextBox_NamaLengkap.Text, TextBox_NoHP.Text, TextBox_Alamat.Text, TextBox_Email.Text);
                }
                catch (Exception)
                {
                    // Abaikan semua error dari UpdateKaryawan (seperti trigger tidak ada perubahan)
                    // agar proses update role tetap berjalan!
                }

                // Update kewenangan (hapus yang lama, insert yang baru)
                UserContext.HapusKewenanganKaryawan(userId);

                UserContext.InsertRoleKaryawan(userId, ComBox_Role1.Text);
                UserContext.InsertRoleKaryawan(userId, ComBox_Role2.Text);
                UserContext.InsertRoleKaryawan(userId, ComBox_Role3.Text);

                MessageBox.Show("Data karyawan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh grid parent
                parentForm.MuatDataKaryawan();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
