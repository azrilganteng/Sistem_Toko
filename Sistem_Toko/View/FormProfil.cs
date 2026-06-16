using Sistem_Toko.Helpers;
using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistem_Toko.View
{
    public partial class FormProfil : Form
    {
        public bool IsLoggedOut { get; private set; }
        private bool _isEditing = false;
        private string _origNama, _origUsername, _origEmail, _origNoHP, _origAlamat;

        public FormProfil()
        {
            InitializeComponent();
            DataProfil();
        }

        private void DataProfil()
        {
            try
            {
                Dictionary<string, string> profil = UserContext.GetProfilUser(SessionUser.Id);

                if (profil.Count > 0)
                {
                    LblIdUserVal.Text = profil["id_user"];
                    LblNamaVal.Text = profil["nama"];
                    LblRoleVal.Text = profil["role"];
                    LblUsernameVal.Text = profil["username"];
                    LblEmailVal.Text = string.IsNullOrWhiteSpace(profil["email"]) ? "-" : profil["email"];
                    LblNoHPVal.Text = string.IsNullOrWhiteSpace(profil["no_hp"]) ? "-" : profil["no_hp"];
                    LblAlamatVal.Text = string.IsNullOrWhiteSpace(profil["alamat"]) ? "-" : profil["alamat"];
                }
                else
                {
                    FallbackSession();
                }
            }
            catch
            {
                FallbackSession();
            }
        }

        private void FallbackSession()
        {
            LblIdUserVal.Text = SessionUser.Id.ToString();
            LblNamaVal.Text = SessionUser.Nama;
            LblRoleVal.Text = SessionUser.Role;
            LblUsernameVal.Text = SessionUser.Username;
            LblEmailVal.Text = string.IsNullOrWhiteSpace(SessionUser.Email) ? "-" : SessionUser.Email;
            LblNoHPVal.Text = string.IsNullOrWhiteSpace(SessionUser.NoHp) ? "-" : SessionUser.NoHp;
            LblAlamatVal.Text = string.IsNullOrWhiteSpace(SessionUser.Alamat) ? "-" : SessionUser.Alamat;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (!_isEditing)
            {
                // Enter edit mode
                _isEditing = true;
                Btn_Edit.Text = "Simpan";
                Btn_Edit.BackColor = Color.DarkOrange;
                Btn_Logout.Enabled = false;

                TxtNama.Text = LblNamaVal.Text;
                TxtUsername.Text = LblUsernameVal.Text;
                TxtEmail.Text = LblEmailVal.Text == "-" ? "" : LblEmailVal.Text;
                TxtNoHP.Text = LblNoHPVal.Text == "-" ? "" : LblNoHPVal.Text;
                TxtAlamat.Text = LblAlamatVal.Text == "-" ? "" : LblAlamatVal.Text;

                _origNama = TxtNama.Text.Trim();
                _origUsername = TxtUsername.Text.Trim();
                _origEmail = TxtEmail.Text.Trim();
                _origNoHP = TxtNoHP.Text.Trim();
                _origAlamat = TxtAlamat.Text.Trim();

                LblNamaVal.Visible = false;
                LblUsernameVal.Visible = false;
                LblEmailVal.Visible = false;
                LblNoHPVal.Visible = false;
                LblAlamatVal.Visible = false;

                TxtNama.Visible = true;
                TxtUsername.Visible = true;
                TxtEmail.Visible = true;
                TxtNoHP.Visible = true;
                TxtAlamat.Visible = true;
            }
            else
            {
                // Validate
                if (string.IsNullOrWhiteSpace(TxtNama.Text) || string.IsNullOrWhiteSpace(TxtUsername.Text))
                {
                    MessageBox.Show("Nama dan Username tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if anything changed
                bool unchanged =
                    TxtNama.Text.Trim() == _origNama &&
                    TxtUsername.Text.Trim() == _origUsername &&
                    TxtEmail.Text.Trim() == _origEmail &&
                    TxtNoHP.Text.Trim() == _origNoHP &&
                    TxtAlamat.Text.Trim() == _origAlamat;

                if (unchanged)
                {
                    MessageBox.Show("Tidak ada perubahan yang disimpan.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CancelEdit();
                    return;
                }

                try
                {
                    UserContext.UpdateProfil(
                        SessionUser.Id,
                        TxtNama.Text.Trim(),
                        TxtUsername.Text.Trim(),
                        TxtEmail.Text.Trim(),
                        TxtNoHP.Text.Trim(),
                        TxtAlamat.Text.Trim());

                    MessageBox.Show("Profil berhasil diperbarui!", "Berhasil",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CancelEdit();
                    DataProfil();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memperbarui profil: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelEdit()
        {
            _isEditing = false;
            Btn_Edit.Text = "Edit Profil";
            Btn_Edit.BackColor = Color.SeaGreen;
            Btn_Logout.Enabled = true;

            TxtNama.Visible = false;
            TxtUsername.Visible = false;
            TxtEmail.Visible = false;
            TxtNoHP.Visible = false;
            TxtAlamat.Visible = false;

            LblNamaVal.Visible = true;
            LblUsernameVal.Visible = true;
            LblEmailVal.Visible = true;
            LblNoHPVal.Visible = true;
            LblAlamatVal.Visible = true;
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                IsLoggedOut = true;
                SessionUser.Id = 0;
                SessionUser.Nama = "";
                SessionUser.Username = "";

                Login halamanLogin = new Login();
                halamanLogin.Show();

                this.Close();
            }
        }
    }
}
