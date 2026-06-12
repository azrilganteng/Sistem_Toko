using Npgsql;
using Sistem_Toko.Helpers;
using System;
using System.Windows.Forms;

namespace Sistem_Toko.View.AdminView
{
    public partial class TambahKaryawan : Form
    {
        private DaftarKaryawan parentForm;

        public TambahKaryawan(DaftarKaryawan parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Btn_Simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_Username.Text) || string.IsNullOrWhiteSpace(TextBox_Password.Text))
            {
                MessageBox.Show("Username dan Password wajib diisi!");
                return;
            }

            try
            {
                using var conn = connectDB.GetConn();

                // 1. Memanggil function tambah_user dan ambil ID-nya
                string sqlUser = @"SELECT tambah_user(@username, @password, @nama, @no_hp, @alamat, @email)";

                int newUserId;
                using (var cmdUser = new NpgsqlCommand(sqlUser, conn))
                {
                    cmdUser.Parameters.AddWithValue("username", TextBox_Username.Text);
                    cmdUser.Parameters.AddWithValue("password", TextBox_Password.Text);
                    cmdUser.Parameters.AddWithValue("nama", TextBox_NamaLengkap.Text);
                    cmdUser.Parameters.AddWithValue("no_hp", TextBox_NoHP.Text);
                    cmdUser.Parameters.AddWithValue("alamat", TextBox_Alamat.Text);
                    cmdUser.Parameters.AddWithValue("email", TextBox_Email.Text);
                    newUserId = Convert.ToInt32(cmdUser.ExecuteScalar());
                }

                // 2. Insert role ke tabel kewenangan
                InsertRole(newUserId, ComBox_Role1.Text, conn);
                InsertRole(newUserId, ComBox_Role2.Text, conn);
                InsertRole(newUserId, ComBox_Role3.Text, conn);

                MessageBox.Show("Karyawan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh grid parent
                parentForm.MuatDataKaryawan();
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
