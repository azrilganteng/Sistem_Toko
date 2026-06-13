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

            //KurirController kurirCtrl = new KurirController();
            //bool isKurirValid = kurirCtrl.LoginKurir(user, pass);

            //if (isKurirValid)
            //{
            //    MessageBox.Show($"Selamat Datang, {SessionUser.Nama}!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    kurirDashboard dashboard = new kurirDashboard();
            //    dashboard.Show();
            //    this.Hide();
            //    return; 
            //}

            MessageBox.Show("Username atau Password salah / Akun tidak dikenali!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}