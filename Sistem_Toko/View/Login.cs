using Npgsql;
using Sistem_Toko.Controller;
using Sistem_Toko.Helpers;
using Sistem_Toko.Model;
using Sistem_Toko.View.AdminView;
using Sistem_Toko.View.KurirView;
using System;
using System.Windows.Forms;

namespace Sistem_Toko
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = UsernameBox.Text;
            string pass = PasswordBox.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AuthController auth = new AuthController();



            Kasir kasirAktif = auth.LoginKasir(user, pass);

            if (kasirAktif != null)
            {
                FormKasir kasirPage = new FormKasir();
                kasirPage.Show();
                this.Hide();
                return;
            }


            Admin adminAktif = auth.LoginAdmin(user, pass);

            if (adminAktif != null)
            {

                AdminForm adminPage = new AdminForm();
                adminPage.Show();
                this.Hide();
                return;
            }

            Kurir KurirAktif = auth.LoginKurir(user, pass);

            if (KurirAktif != null)
            {
                kurirDashboard dashboard = new kurirDashboard();
                dashboard.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Username atau Password salah / Akun tidak dikenali!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TogglePasswordBtn_Click(object sender, EventArgs e)
        {
            bool isHidden = PasswordBox.UseSystemPasswordChar;
            PasswordBox.UseSystemPasswordChar = !isHidden;
            // \uE7B3 = eye open, \uED1A = eye hidden (Segoe MDL2 Assets)
            TogglePasswordBtn.Text = isHidden ? "\uE7B3" : "\uED1A";
            TogglePasswordBtn.ForeColor = isHidden ? Color.SeaGreen : Color.Gray;
        }
    }
}