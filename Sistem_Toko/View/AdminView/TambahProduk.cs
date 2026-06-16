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

        public TambahProduk(Restock parent)
        {
            InitializeComponent();
            _parentForm = parent;
            CmbKategori.SelectedIndex = 0;
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
            // Validation
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

            if (!int.TryParse(TxtStok.Text, out int stok) || stok < 0)
            {
                MessageBox.Show("Stok harus berupa angka non-negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtStok.Focus();
                return;
            }

            if (CmbKategori.SelectedIndex < 0)
            {
                MessageBox.Show("Kategori wajib dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Map category index to id_kategori_produk: Pupuk=1, Obat=2, Bibit=3
            int idKategori = CmbKategori.SelectedIndex + 1;

            try
            {
                ProdukContext.TambahProduk(
                    TxtNama.Text.Trim(),
                    harga,
                    stok,
                    TxtDeskripsi.Text.Trim(),
                    idKategori,
                    _selectedImagePath
                );

                MessageBox.Show("Produk berhasil ditambahkan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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
