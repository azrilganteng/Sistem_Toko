using Npgsql;
using Sistem_Toko.Helpers;
using System;
using System.Collections.Generic;
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
                using var conn = connectDB.GetConn();

                // Load data user
                string sqlUser = "SELECT username, password, nama, no_hp, alamat, email FROM users WHERE id_user = @id";
                using (var cmdUser = new NpgsqlCommand(sqlUser, conn))
                {
                    cmdUser.Parameters.AddWithValue("id", userId);
                    using var r = cmdUser.ExecuteReader();
                    if (r.Read())
                    {
                        TextBox_Username.Text = r["username"].ToString();
                        TextBox_Password.Text = r["password"].ToString();
                        TextBox_NamaLengkap.Text = r["nama"].ToString();
                        TextBox_NoHP.Text = r["no_hp"].ToString();
                        TextBox_Alamat.Text = r["alamat"].ToString();
                        TextBox_Email.Text = r["email"].ToString();
                    }
                }

                // Load roles
                string sqlRoles = "SELECT r.nama_role FROM kewenangan k JOIN roles r ON k.id_role = r.id_role WHERE k.id_user = @id";
                List<string> roles = new List<string>();
                using (var cmdRoles = new NpgsqlCommand(sqlRoles, conn))
                {
                    cmdRoles.Parameters.AddWithValue("id", userId);
                    using var r = cmdRoles.ExecuteReader();
                    while (r.Read())
                    {
                        roles.Add(r["nama_role"].ToString());
                    }
                }

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

            try
            {
                using var conn = connectDB.GetConn();

                // Update tabel users
                string sqlUpdate = @"
                    UPDATE users 
                    SET username = @username, password = @password, nama = @nama, 
                        no_hp = @no_hp, alamat = @alamat, email = @email
                    WHERE id_user = @id";

                using (var cmdUpdate = new NpgsqlCommand(sqlUpdate, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("username", TextBox_Username.Text);
                    cmdUpdate.Parameters.AddWithValue("password", TextBox_Password.Text);
                    cmdUpdate.Parameters.AddWithValue("nama", TextBox_NamaLengkap.Text);
                    cmdUpdate.Parameters.AddWithValue("no_hp", TextBox_NoHP.Text);
                    cmdUpdate.Parameters.AddWithValue("alamat", TextBox_Alamat.Text);
                    cmdUpdate.Parameters.AddWithValue("email", TextBox_Email.Text);
                    cmdUpdate.Parameters.AddWithValue("id", userId);
                    cmdUpdate.ExecuteNonQuery();
                }

                // Update kewenangan (hapus yang lama, insert yang baru)
                using (var cmdDel = new NpgsqlCommand("DELETE FROM kewenangan WHERE id_user = @id", conn))
                {
                    cmdDel.Parameters.AddWithValue("id", userId);
                    cmdDel.ExecuteNonQuery();
                }

                InsertRole(userId, ComBox_Role1.Text, conn);
                InsertRole(userId, ComBox_Role2.Text, conn);
                InsertRole(userId, ComBox_Role3.Text, conn);

                MessageBox.Show("Data karyawan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh grid parent
                parentForm.MuatDataKaryawan();
                this.Close();
            }
            catch (PostgresException ex) when (ex.Message.Contains("Tidak ada perubahan data"))
            {
                MessageBox.Show("Tidak ada data yang diubah. Update dibatalkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertRole(int idUser, string roleName, NpgsqlConnection conn)
        {
            if (string.IsNullOrWhiteSpace(roleName) || roleName.ToLower() == "tidak ada") return;

            string sqlRole = @"
                INSERT INTO kewenangan (id_user, id_role)
                SELECT @id_user, id_role FROM roles WHERE nama_role ILIKE @role";

            using var cmd = new NpgsqlCommand(sqlRole, conn);
            cmd.Parameters.AddWithValue("id_user", idUser);
            cmd.Parameters.AddWithValue("role", roleName);
            cmd.ExecuteNonQuery();
        }
    }
}
