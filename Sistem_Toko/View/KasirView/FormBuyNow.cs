using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Windows.Forms;

namespace Sistem_Toko.View.KasirView
{
    public partial class FormBuyNow : Form
    {
        private Produk _Produk;
        private int _qty = 1;
        private int _idCustomer;
        private FormKasir _formKasir;
        public FormBuyNow(FormKasir formKasir, Produk produk, int idCustomer)
        {
            InitializeComponent();
            this._formKasir = formKasir;
            this._Produk = produk;
            this._idCustomer = idCustomer;

            TampilkanDetailProduk();
        }

        private void TampilkanDetailProduk()
        {
            LblProduk.Text = _Produk.NamaProduk;
            LblKategori.Text = "Kategori: " + _Produk.IdKategori;
            DeskripsiLbl.Text = _Produk.Deskripsi;
            LblQty.Text = _qty.ToString();

            PbGambar.ImageLocation = _Produk.Gambar;
        }

        private void TambahQty_Click(object sender, EventArgs e)
        {
            if (_qty < _Produk.Stok)
            {
                _qty++;
                LblQty.Text = _qty.ToString();
            }
            else
            {
                MessageBox.Show($"Stok tidak mencukupi! Maksimal pembelian adalah {_Produk.Stok} pcs.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_qty > 1)
            {
                _qty--;
                LblQty.Text = _qty.ToString();
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BayarBtn_Click(object sender, EventArgs e)
        {
             List<Detail_orders> keranjangInstant = new List<Detail_orders>();

            Detail_orders detail = new Detail_orders(_Produk, _qty);
            detail.Id = _Produk.Id;
            detail.HargaSatuan = _Produk.Harga;
            detail.Qty = _qty;

            keranjangInstant.Add(detail);

            FormPembayaran halamanPembayaran = new FormPembayaran(_formKasir, null, keranjangInstant);
            this.Hide();
            halamanPembayaran.ShowDialog();
            this.Close();
        }
    }
}

