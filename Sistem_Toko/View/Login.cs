using Npgsql;
using Sistem_Toko.Controller; // Sesuaikan dengan namespace connectDB kamu
using Sistem_Toko.Helpers;
using Sistem_Toko.Model;

using Sistem_Toko.View.AdminView;

using Sistem_Toko.View.KurirView;


namespace Sistem_Toko
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string user = UsernameBox.Text;
            string pass = PasswordBox.Text;


            // Coba login sebagai Admin dulu
            Admin admin = new Admin(0, "", "", "");
            if (admin.Login(user, pass))
            {
                AdminForm adminPage = new AdminForm(admin);
                adminPage.Show();
                this.Hide();
                return;
            }

            // Kalau bukan admin, coba login sebagai Kasir
            Kasir kasir = new Kasir(0, "", "", "");
            if (kasir.Login(user, pass))
            {
                FormKasir kasirPage = new FormKasir(kasir);
                kasirPage.Show();
                this.Hide();
            }
            else
            {
                Kurir dataKurir = new Kurir(0, "", "", "");

                if (dataKurir.Login(user, pass))
                {
                    MessageBox.Show($"Selamat Datang, {dataKurir.Nama}!", "Login Berhasil");

                    SessionUser.IdUser = dataKurir.ID;
                    SessionUser.Nama = dataKurir.Nama;
                    SessionUser.IdRole = 3;

                    kurirDashboard dashboard = new kurirDashboard();
                    dashboard.Show();
                    this.Hide();
                    return;
                }

                else
                {
                    MessageBox.Show("Username/Password salah!", "Login Gagal");
                }
            }
        }

    }
}
