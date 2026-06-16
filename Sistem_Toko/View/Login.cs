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
            var result = auth.CekCredentials(user, pass);

            if (result == null)
            {
                MessageBox.Show("Username atau Password salah / Akun tidak aktif!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var roles = result.Value.Roles;
            if (roles.Count == 0)
            {
                MessageBox.Show("Akun Anda tidak memiliki role/kewenangan apa pun!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRole = roles[0];

            if (roles.Count > 1)
            {
                // Buat form sederhana untuk pilih role
                using (Form formPilih = new Form())
                {
                    formPilih.Text = "Pilih Role";
                    formPilih.StartPosition = FormStartPosition.CenterParent;
                    formPilih.Size = new System.Drawing.Size(300, 150);
                    formPilih.FormBorderStyle = FormBorderStyle.FixedDialog;
                    formPilih.MaximizeBox = false;
                    formPilih.MinimizeBox = false;

                    Label lbl = new Label() { Text = "Pilih role untuk login:", Left = 20, Top = 20, Width = 250 };
                    ComboBox cmb = new ComboBox() { Left = 20, Top = 45, Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };
                    foreach (var r in roles) cmb.Items.Add(r);
                    cmb.SelectedIndex = 0;

                    Button btnOk = new Button() { Text = "Masuk", Left = 160, Top = 80, DialogResult = DialogResult.OK };
                    formPilih.Controls.Add(lbl);
                    formPilih.Controls.Add(cmb);
                    formPilih.Controls.Add(btnOk);
                    formPilih.AcceptButton = btnOk;

                    if (formPilih.ShowDialog(this) == DialogResult.OK)
                    {
                        selectedRole = cmb.SelectedItem.ToString();
                    }
                    else
                    {
                        return; // Batal login
                    }
                }
            }

            // Setelah role terpilih, eksekusi login sesuai role untuk mengisi session context
            if (selectedRole == "Kasir")
            {
                var kasir = auth.LoginKasir(user, pass);
                if (kasir != null)
                {
                    FormKasir kasirPage = new FormKasir();
                    kasirPage.Show();
                    this.Hide();
                }
            }
            else if (selectedRole == "Admin")
            {
                var admin = auth.LoginAdmin(user, pass);
                if (admin != null)
                {
                    AdminForm adminPage = new AdminForm(admin);
                    adminPage.Show();
                    this.Hide();
                }
            }
            else if (selectedRole == "Kurir")
            {
                var kurir = auth.LoginKurir(user, pass);
                if (kurir != null)
                {
                    kurirDashboard dashboard = new kurirDashboard();
                    dashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Role tidak dikenali: " + selectedRole, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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