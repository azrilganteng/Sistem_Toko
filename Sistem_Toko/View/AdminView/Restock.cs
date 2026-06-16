using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistem_Toko.View.AdminView
{
    public partial class Restock : Form
    {
        private List<ProdukRestockControl> _kontrolProduk = new();

        public Restock()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MuatDaftarProduk();
        }

        public void MuatDaftarProduk()
        {
            FlowProduk.Controls.Clear();
            _kontrolProduk.Clear();

            try
            {
                var produkList = ProdukContext.GetAllProductAdmin();

                if (produkList.Count == 0)
                {
                    LblInfo.Text = "Tidak ada produk ditemukan.";
                    LblInfo.Visible = true;
                    return;
                }

                LblInfo.Visible = false;

                foreach (var produk in produkList)
                {
                    var kontrol = new ProdukRestockControl(produk)
                    {
                        Width = FlowProduk.ClientSize.Width - 10,
                        Margin = new Padding(0, 0, 0, 4)
                    };
                    _kontrolProduk.Add(kontrol);
                    FlowProduk.Controls.Add(kontrol);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat produk: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Simpan_Click(object sender, EventArgs e)
        {
            var dipilih = _kontrolProduk.Where(k => k.Dipilih).ToList();

            if (dipilih.Count == 0)
            {
                MessageBox.Show("Pilih minimal satu produk untuk di-restock.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var konfirmasi = MessageBox.Show(
                $"Restock {dipilih.Count} produk?\n\n" +
                string.Join("\n", dipilih.Select(k => $"• {k.NamaProduk} +{k.JumlahRestock}")),
                "Konfirmasi Restock",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi != DialogResult.Yes) return;

            try
            {
                foreach (var kontrol in dipilih)
                {
                    ProdukContext.RestockProduk(kontrol.IdProduk, kontrol.JumlahRestock);
                }

                MessageBox.Show("Restock berhasil disimpan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                MuatDaftarProduk(); // refresh list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan restock: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Tambah_Produk_Click(object sender, EventArgs e)
        {
            TambahProduk formTambah = new TambahProduk(this);
            formTambah.ShowDialog();
        }
    }
}
