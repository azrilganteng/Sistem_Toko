using System;
using System.Windows.Forms;
using Sistem_Toko.Model;

namespace Sistem_Toko.View.AdminView
{
    public partial class FormTambahSupplier : Form
    {
        private TambahProduk _parentForm;

        public FormTambahSupplier(TambahProduk parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string nama = TxtNama.Text.Trim();
            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Nama Supplier tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNama.Focus();
                return;
            }

            try
            {
                ProdukContext.TambahSupplier(nama, TxtAlamat.Text.Trim(), TxtNoHp.Text.Trim(), TxtEmail.Text.Trim());
                MessageBox.Show("Supplier berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Refresh supplier di form parent
                _parentForm.MuatSupplier();
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
