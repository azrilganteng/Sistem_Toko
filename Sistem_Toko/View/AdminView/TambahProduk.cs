using Sistem_Toko.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistem_Toko.View.AdminView
{
    public partial class TambahProduk : Form
    {
        private Restock _parentForm;
        private string _selectedImagePath = "";
        private System.Collections.Generic.List<(int Id, string Nama)> _supplierList = new();

        public TambahProduk(Restock parent)
        {
            InitializeComponent();
            _parentForm = parent;
            CmbKategori.SelectedIndex = 0;
            MuatSupplier();
        }

        public void MuatSupplier()
        {
            try
            {
                _supplierList = ProdukContext.GetAllSupplier();
                CmbSupplier.Items.Clear();
                foreach (var s in _supplierList)
                {
                    CmbSupplier.Items.Add(s.Nama);
                }
                if (CmbSupplier.Items.Count > 0)
                    CmbSupplier.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data supplier: " + ex.Message, "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnTambahSupplier_Click(object sender, EventArgs e)
        {
            FormTambahSupplier formTambahSupplier = new FormTambahSupplier(this);
            formTambahSupplier.ShowDialog();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Pilih Gambar Produk";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = ofd.FileName;
                    TxtGambar.Text = Path.GetFileName(_selectedImagePath);

                    try
                    {
                        PbPreview.Image = Image.FromFile(_selectedImagePath);
                    }
                    catch
                    {
                        PbPreview.Image = null;
                    }
                }
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNama.Text))
            {
                MessageBox.Show("Nama produk wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNama.Focus();
                return;
            }

            if (!int.TryParse(TxtHarga.Text, out int harga) || harga <= 0)
            {
                MessageBox.Show("Harga harus berupa angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtHarga.Focus();
                return;
            }

            if (CmbSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("Supplier wajib dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbSupplier.Focus();
                return;
            }

            if (CmbKategori.SelectedIndex < 0)
            {
                MessageBox.Show("Kategori wajib dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idKategori = CmbKategori.SelectedIndex + 1;
            int idSupplier = _supplierList[CmbSupplier.SelectedIndex].Id;

            try
            {
                int idProdukBaru = ProdukContext.TambahProduk(
                    TxtNama.Text.Trim(),
                    harga,
                    TxtDeskripsi.Text.Trim(),
                    idKategori,
                    _selectedImagePath
                );

                // Tambahkan relasi supplier_produk
                ProdukContext.TambahSupplierProduk(idSupplier, idProdukBaru);

                MessageBox.Show("Produk berhasil ditambahkan!\nStok awal = 0, silakan lakukan restock untuk menambah stok.",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _parentForm.MuatDaftarProduk();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan produk: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
