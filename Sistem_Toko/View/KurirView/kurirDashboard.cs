using System;
using System.Windows.Forms;
using Npgsql;
using Sistem_Toko.Helpers; // namespace connectDB kamu
using Sistem_Toko.Helpers;
using System.Data;
using Sistem_Toko.Controller;
namespace Sistem_Toko.View.KurirView
{
    public partial class kurirDashboard : Form
    {
        public kurirDashboard()
        {
            InitializeComponent();
        }

        private void kurirDashboard_Load(object sender, EventArgs e)
        {
            MuatInfoKurir();
        }

        private void MuatInfoKurir()
        {
            try
            {
                using (var conn = connectDB.GetConn()) 
                {
                    var cmd = new NpgsqlCommand(
                        "SELECT * FROM fn_get_user_info(@id)", conn);
                    cmd.Parameters.AddWithValue("id", SessionUser.Id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            SessionUser.Nama = reader["nama"].ToString();
                            SessionUser.NoHp = reader["no_hp"].ToString();
                        }
                    }
                }

                lblSelamatDatang.Text = "Selamat Datang [Kurir]";
                lblNamaKurir.Text = SessionUser.Nama;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KurirForm formPengiriman = new KurirForm();
            formPengiriman.Show();
            this.Hide(); // sembunyikan dashboard
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblNamaKurir_Click(object sender, EventArgs e)
        {

        }
    }
}