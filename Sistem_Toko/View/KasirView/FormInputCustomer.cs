using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sistem_Toko.View.KasirView
{
    public partial class FormInputCustomer : Form
    {
        /// <summary>
        /// ID customer yang dipilih/dibuat. 0 jika belum ada.
        /// </summary>
        public int CustomerDipilih { get; private set; }

        /// <summary>
        /// Nama customer yang dipilih.
        /// </summary>
        public string NamaCustomer { get; private set; }

        private List<Customer> _semuaCustomer = new List<Customer>();

        public FormInputCustomer()
        {
            InitializeComponent();
            CustomerDipilih = 0;
        }

        private void FormInputCustomer_Load(object sender, EventArgs e)
        {
            MuatCustomer();
        }

        private void MuatCustomer()
        {
            try
            {
                _semuaCustomer = CustomerContext.GetAllCustomers();
                TampilkanGrid(_semuaCustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data customer: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TampilkanGrid(List<Customer> list)
        {
            GridCustomer.Rows.Clear();
            GridCustomer.Columns.Clear();

            GridCustomer.Columns.Add("ID", "ID");
            GridCustomer.Columns.Add("Nama", "Nama Customer");
            GridCustomer.Columns.Add("NoHp", "No. HP");
            GridCustomer.Columns.Add("Alamat", "Alamat");

            GridCustomer.Columns["ID"].Visible = false;

            foreach (var c in list)
            {
                GridCustomer.Rows.Add(c.IdCustomer, c.Nama, c.NoHp, c.Alamat);
            }

            CustomerDipilih = 0;
            NamaCustomer = "";
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            string keyword = TxtCari.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                TampilkanGrid(_semuaCustomer);
            }
            else
            {
                var filtered = _semuaCustomer
                    .Where(c => c.Nama.ToLower().Contains(keyword))
                    .ToList();
                TampilkanGrid(filtered);
            }
        }

        private void GridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = GridCustomer.Rows[e.RowIndex];
                CustomerDipilih = Convert.ToInt32(row.Cells["ID"].Value);
                NamaCustomer = row.Cells["Nama"].Value?.ToString() ?? "";
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
                MessageBox.Show("Silakan pilih customer dari tabel terlebih dahulu.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnTambahBaru_Click(object sender, EventArgs e)
        {
            // Show add form, hide grid
            GridCustomer.Visible = false;
            TxtCari.Enabled = false;
            PanelTambah.Visible = true;
            BtnTambahBaru.Enabled = false;
            BtnPilih.Enabled = false;

            TxtNamaCustomer.Clear();
            TxtNoHp.Clear();
            TxtAlamat.Clear();
            TxtNamaCustomer.Focus();
        }

        private void BtnBatalTambah_Click(object sender, EventArgs e)
        {
            // Hide add form, show grid
            PanelTambah.Visible = false;
            GridCustomer.Visible = true;
            TxtCari.Enabled = true;
            BtnTambahBaru.Enabled = true;
            BtnPilih.Enabled = true;
        }

        private void BtnSimpanBaru_Click(object sender, EventArgs e)
        {
            string nama = TxtNamaCustomer.Text.Trim();
            string noHp = TxtNoHp.Text.Trim();
            string alamat = TxtAlamat.Text.Trim();

            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Nama customer wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(noHp))
            {
                MessageBox.Show("Nomor HP customer wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(alamat))
            {
                MessageBox.Show("Alamat customer wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idBaru = CustomerContext.TambahCustomer(nama, noHp, alamat);

                // Refresh list and auto-select the new customer
                MuatCustomer();
                CustomerDipilih = idBaru;
                NamaCustomer = nama;

                // Return to grid view
                PanelTambah.Visible = false;
                GridCustomer.Visible = true;
                TxtCari.Enabled = true;
                BtnTambahBaru.Enabled = true;
                BtnPilih.Enabled = true;

                MessageBox.Show($"Customer '{nama}' berhasil ditambahkan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Auto-select and close
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah customer: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
