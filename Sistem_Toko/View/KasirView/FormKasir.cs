using Sistem_Toko.Controller;
using Sistem_Toko.Helpers;
using Sistem_Toko.Model;
using Sistem_Toko;
using Sistem_Toko.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistem_Toko
{
    public partial class FormKasir : Form
    {
        public Kasir _kasirActive;
        public Dictionary<string, int> ItemQty = new Dictionary<string, int>();

        public FormKasir()
        {
            InitializeComponent();
            _kasirActive = new Kasir(
                SessionUser.Id,
                SessionUser.Nama,
                SessionUser.Username,
                ""
            );

            TampilanKasir();
            ShowProduk();
        }

        public void TampilanKasir()
        {
            LblKasir.Text = "Selamat Datang Kasir: " + SessionUser.Nama;
        }
        public void ShowProduk(int? idKategori = null)
        {
            ProductController pc = new ProductController();
            List<Produk> listProduk;

            if (idKategori.HasValue)
            {
                listProduk = pc.GetProduct(idKategori.Value);
            }
            else
            {
                listProduk = pc.GetAll();
            }

            FlpProduk.Controls.Clear();

            foreach (var item in listProduk)
            {
                UC_Produk ucProduk = new UC_Produk(this, item.Id, item.Gambar, item.NamaProduk, item.Harga, item.Stok, item.Deskripsi);
                FlpProduk.Controls.Add(ucProduk);
            }
        }

        private void FormKasir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        public void Keranjang(Produk PilProduk)
        {
            string hasilValidasi = _kasirActive.TambahKeKeranjang(PilProduk);

            if (hasilValidasi != "SUKSES")
            {
                MessageBox.Show(hasilValidasi, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void BuyNow(Produk produk)
        {
            View.KasirView.FormBuyNow formBuyNow = new View.KasirView.FormBuyNow(this, produk, 0);
            this.Hide();
            formBuyNow.ShowDialog();
            ShowProduk();
            this.Show();
        }

        public void BukaKeranjang()
        {
            var keranjang = _kasirActive.GetListKeranjang();
            if (keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang belanja masih kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormKeranjang halamanKeranjang = new FormKeranjang(this, keranjang);
            this.Hide();
            halamanKeranjang.ShowDialog();
            ShowProduk();
            this.Show();
        }

        private void ListKeranjangBtn_Click(object sender, EventArgs e)
        {
            BukaKeranjang();
        }


        private void StatusKirimBtn_Click_1(object sender, EventArgs e)
        {
            View.KasirView.FormStatusPengiriman halamanStatus = new View.KasirView.FormStatusPengiriman(this);

            this.Hide();
            halamanStatus.ShowDialog();
            this.Show();
        }

        private void PupukBtn_Click(object sender, EventArgs e)
        {
            ShowProduk(1);
        }

        private void BibitBtn_Click(object sender, EventArgs e)
        {
            ShowProduk(3);
        }

        private void ObatBtn_Click(object sender, EventArgs e)
        {
            ShowProduk(2);
        }

        private void SemuaBtn_Click(object sender, EventArgs e)
        {
            ShowProduk();
        }

        private void Profil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sistem_Toko.View.FormProfil halamanProfil = new Sistem_Toko.View.FormProfil();
            halamanProfil.Owner = this;
            halamanProfil.ShowDialog();
            if (halamanProfil.IsLoggedOut)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Login)
                    {
                        form.Show();
                        break;
                    }
                }
                
                this.FormClosed -= FormKasir_FormClosed;
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sistem_Toko.View.FormProfil halamanProfil = new Sistem_Toko.View.FormProfil();
            halamanProfil.Owner = this;
            halamanProfil.ShowDialog();
            if (halamanProfil.IsLoggedOut)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Login)
                    {
                        form.Show();
                        break;
                    }
                }
                this.FormClosed -= FormKasir_FormClosed;
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SessionUser.Id = 0;
                SessionUser.Nama = "";
                SessionUser.Username = "";
                SessionUser.Role = "";
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Login)
                    {
                        form.Show();
                        break;
                    }
                }
                this.FormClosed -= FormKasir_FormClosed;
                this.Close();
            }
        }
    }
}