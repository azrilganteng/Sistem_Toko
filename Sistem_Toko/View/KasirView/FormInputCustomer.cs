using Sistem_Toko.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistem_Toko.View.KasirView
{
    public partial class FormInputCustomer : Form
    {
        public int CustomerDipilih { get; private set; }

        public string NamaCustomer { get; private set; }

        public FormInputCustomer()
        {
            InitializeComponent();
            CustomerDipilih = 0;
            SembunyikanFormBaru();
        }

        private void SembunyikanFormBaru()
        {
            TxtNoHp.Visible = false;
            TxtAlamat.Visible = false;
            LblNoHp.Visible = false;
            LblAlamat.Visible = false;
            BtnTambahBaru.Visible = false;
            LblInfoCustomer.Visible = false;
        }

        private void TampilkanFormBaru()
        {
            TxtNoHp.Visible = true;
            TxtAlamat.Visible = true;
            LblNoHp.Visible = true;
            LblAlamat.Visible = true;
            BtnTambahBaru.Visible = true;
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            string namaInput = TxtNamaCustomer.Text.Trim();

            if (string.IsNullOrEmpty(namaInput))
            {
                MessageBox.Show("Masukkan nama customer terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer c = CustomerContext.CariByNama(namaInput);

            if (c != null)
            {
                // Customer found
                LblInfoCustomer.Text = $"Ditemukan: {c.Nama}\nNo. HP: {c.NoHp}\nAlamat: {c.Alamat}";
                LblInfoCustomer.ForeColor = Color.Green;
                LblInfoCustomer.Visible = true;
                SembunyikanFormBaruExcept();

                this.CustomerDipilih = c.IdCustomer;
                this.NamaCustomer = c.Nama;
            }
            else
            {
                // Customer not found, show form to create new
                LblInfoCustomer.Text = $"Customer '{namaInput}' tidak ditemukan. Silakan lengkapi data untuk menambah customer baru.";
                LblInfoCustomer.ForeColor = Color.DarkOrange;
                LblInfoCustomer.Visible = true;
                TampilkanFormBaru();
            }
        }

        private void SembunyikanFormBaruExcept()
        {
            TxtNoHp.Visible = false;
            TxtAlamat.Visible = false;
            LblNoHp.Visible = false;
            LblAlamat.Visible = false;
            BtnTambahBaru.Visible = false;
        }

        private void BtnTambahBaru_Click(object sender, EventArgs e)
        {
            string nama = TxtNamaCustomer.Text.Trim();
            string noHp = TxtNoHp.Text.Trim();
            string alamat = TxtAlamat.Text.Trim();

            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Nama customer wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(noHp))
            {
                MessageBox.Show("Nomor HP customer wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(alamat))
            {
                MessageBox.Show("Alamat customer wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idBaru = CustomerContext.TambahCustomer(nama, noHp, alamat);
                this.CustomerDipilih = idBaru;
                this.NamaCustomer = nama;
                MessageBox.Show($"Customer '{nama}' berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPilih_Click(object sender, EventArgs e)
        {
            if (CustomerDipilih > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Silakan cari dan pilih customer terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
