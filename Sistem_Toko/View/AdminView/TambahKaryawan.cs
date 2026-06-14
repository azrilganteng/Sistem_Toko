using Sistem_Toko.Model;
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
                // 1. Memanggil function tambah_user dan ambil ID-nya
                int newUserId = UserContext.TambahKaryawan(TextBox_Username.Text, TextBox_Password.Text, TextBox_NamaLengkap.Text, TextBox_NoHP.Text, TextBox_Alamat.Text, TextBox_Email.Text);

                // 2. Insert role ke tabel kewenangan
                UserContext.InsertRoleKaryawan(newUserId, ComBox_Role1.Text);
                UserContext.InsertRoleKaryawan(newUserId, ComBox_Role2.Text);
                UserContext.InsertRoleKaryawan(newUserId, ComBox_Role3.Text);

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

        private void Btn_Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
