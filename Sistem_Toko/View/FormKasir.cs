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
        public Dictionary<string, int> ItemQty = new Dictionary<string, int>();
        public List<Detail_orders> ListKeranjang = new List<Detail_orders>();

        public FormKasir(Kasir data)
        {
            InitializeComponent();
            _kasirActive = data;

            TampilanKasir();
            ShowProduk();
    
        }

        public void TampilanKasir()
        {
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

        private Detail_orders CariDiKeranjang(string namaProduk)
        {
            return ListKeranjang.Find(x => x.ProdukItem.NamaProduk == namaProduk);
        }
        public void Keranjang(Produk PilProduk)
        {
            Detail_orders itemEksis = CariDiKeranjang(PilProduk.NamaProduk);

            if (itemEksis != null)
            {
                // Jika barang sudah ada, cek apakah penambahan melebihi stok yang ada
                if (itemEksis.Qty < PilProduk.Stok)
                {
                    itemEksis.TambahQty();
                }
                else
                {
                    MessageBox.Show($"Stok '{PilProduk.NamaProduk}' tidak mencukupi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // Jika barang baru masuk keranjang, cek apakah stok tersedia
                if (PilProduk.Stok > 0)
                {
                    ListKeranjang.Add(new Detail_orders(PilProduk, 1));
                }
                else
                {
                    MessageBox.Show($"Stok '{PilProduk.NamaProduk}' habis!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

        }


        private void ListKeranjangBtn_Click(object sender, EventArgs e)
        {
            if (ListKeranjang.Count == 0)
            {
                MessageBox.Show("Keranjang belanja masih kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Instansiasi FormKeranjang baru dengan melempar data ListKeranjang saat ini
            FormKeranjang halamanKeranjang = new FormKeranjang(this, this.ListKeranjang);

            this.Hide();
            // Tampilkan secara ShowDialog (modal) agar user fokus menyelesaikan transaksi di form tersebut
            halamanKeranjang.ShowDialog();
  
      
        }


        private void PupukBtn_Click(object sender, EventArgs e)
        {
            FlpProduk.Visible = true;
        }



    }
}