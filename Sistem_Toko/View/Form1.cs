using Npgsql;
using Sistem_Toko.Controller; // Sesuaikan dengan namespace connectDB kamu
using Sistem_Toko.Model;

namespace Sistem_Toko
{
    public partial class Form1 : Form
    {
        public Form1()
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

            AuthController auth = new AuthController();
            Kasir loginResult = auth.ProsesLoginKasir(user, pass);

            if (loginResult != null)
            {
                MessageBox.Show($"Selamat Datang, {loginResult.Nama}!", "Login Berhasil");

                // Pindah ke FormKasir dan kirim data objek Kasir
                FormKasir kasirPage = new FormKasir(loginResult);
                kasirPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username/Password salah!", "Login Gagal");
            }
        }
    }
}
