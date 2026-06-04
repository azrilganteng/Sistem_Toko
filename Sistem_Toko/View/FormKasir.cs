using Sistem_Toko.Controller;
using Sistem_Toko.Model;
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
        private Kasir _kasirActive;
        public List<Produk> ListKeranjang = new List<Produk>();
        public Dictionary<string, int> ItemQty = new Dictionary<string, int>();

        public FormKasir(Kasir data)
        {
            InitializeComponent();
            _kasirActive = data;


            TampilanKasir();
            ShowProduk();
    
        }

        public void TampilanKasir()
        {
            // Contoh menampilkan nama kasir di label
            LblToko.Text = "TOKO TANI SAMUDRA\n";
            LblKasir.Text = "Selamat Datang Kasir: " + _kasirActive.Nama;
        }

        private void ShowProduk()
        {
            ProductController pc = new ProductController();
            var listProduk = pc.GetProduct();
            FlpProduk.Controls.Clear();

            foreach (var item in listProduk)
            {
                UC_Produk ucProduk = new UC_Produk(this,item.Gambar, item.NamaProduk, item.Harga, item.Stok);
                FlpProduk.Controls.Add(ucProduk);
            }

        }

        

        private void FormKasir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void Keranjang(Produk PilProdduk)
        {
            bool InKeranjang = ItemQty.ContainsKey(PilProdduk.NamaProduk);
            if (InKeranjang)
            {

                bool stokMasihAda = ItemQty[PilProdduk.NamaProduk] < PilProdduk.Stok;

                if (stokMasihAda)
                {
                    ItemQty[PilProdduk.NamaProduk]++;
                    MessageBox.Show($"Jumlah {PilProdduk.NamaProduk} di keranjang ditambah!", "Sukses");
                }
                else
                {
                    MessageBox.Show("Tidak bisa menambah jumlah, melebihi stok yang tersedia!", "Peringatan");
                }
            }
            else
            {
                ListKeranjang.Add(PilProdduk);
                ItemQty.Add(PilProdduk.NamaProduk, 1);
                MessageBox.Show($"{PilProdduk.NamaProduk} berhasil dimasukkan ke keranjang!", "Sukses");
            }
        }

        public void RefreshTampilanKeranjang()
        {
            FlpKeranjang.Controls.Clear();

            foreach (var item in ListKeranjang)
            {
                int jumlahBeli = ItemQty[item.NamaProduk];
                UC_ProdukKeranjang barisCart = new UC_ProdukKeranjang(this, item, jumlahBeli);
                FlpKeranjang.Controls.Add(barisCart);
            }
            FlpKeranjang.PerformLayout();
        }


        private void ListKeranjangBtn_Click(object sender, EventArgs e)
        {
            FlpProduk.Visible = false;
            FlpKeranjang.Visible = true;
            BayarBtn.Visible = true;

            RefreshTampilanKeranjang();
        }

        private void PupukBtn_Click(object sender, EventArgs e)
        {
            FlpProduk.Visible = true;
            FlpKeranjang.Visible = false;

            BayarBtn.Visible = false;
        }

        

        // Fungsi untuk menghapus item (dipanggil dari tombol Batal di UC_CartItem)
        //public void HapusDariKeranjang(Produk produk)
        //{
        //    ListKeranjang.Remove(produk);
        //    ItemQty.Remove(produk.NamaProduk);

        //    KeranjangBtn.Text = ;
        //    MessageBox.Show($"{PilProdduk.NamaProduk} ditambahkan ke keranjang.", "Sukses");

        //    // Segarkan ulang list di layar
        //    RefreshTampilanKeranjang();
        //}


    }
}