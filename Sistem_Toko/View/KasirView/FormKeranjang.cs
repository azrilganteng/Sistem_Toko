using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistem_Toko
{
    public partial class FormKeranjang : Form
    {
        public FormKasir _formInduk;
        private List<Detail_orders> _listKeranjang;

        public FormKeranjang(FormKasir formInduk, List<Detail_orders> listKeranjang)
        {
            InitializeComponent();
            this._formInduk = formInduk;
            this._listKeranjang = listKeranjang;

            _formInduk.TampilanKasir();
            TampilkanDaftarKeranjang();
        }

        public void TampilkanDaftarKeranjang()
        {
            FlpKeranjang.Controls.Clear();

            foreach (Detail_orders item in _listKeranjang)
            {
                UC_ProdukKeranjang ucItem = new UC_ProdukKeranjang(this, _formInduk, item.ProdukItem, item.Qty);
                FlpKeranjang.Controls.Add(ucItem);
            }
        }

        public void TmbhQty(string namaProduk)
        {
            foreach (Detail_orders item in _listKeranjang)
            {
                if (item.ProdukItem.NamaProduk == namaProduk)
                {
                    if (item.Qty < item.ProdukItem.Stok)
                    {
                        item.TambahQty();
                        TampilkanDaftarKeranjang();
                    }
                    break;
                }
            }
        }

        public void HapusItem(string namaProduk)
        {
            Detail_orders Hapus = null;
            foreach (Detail_orders item in _listKeranjang)
            {
                if (item.ProdukItem.NamaProduk == namaProduk)
                {
                    Hapus = item;
                    break;
                }
            }

            if (Hapus != null)
            {
                _listKeranjang.Remove(Hapus);
                TampilkanDaftarKeranjang();

                if (_listKeranjang.Count == 0)
                {
                    MessageBox.Show("Keranjang Anda sekarang kosong.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_formInduk != null) _formInduk.Show();
                    this.Close();
                }
            }
        }

        private void PupukBtn_Click(object sender, EventArgs e)
        {
            if (_formInduk != null) _formInduk.Show();
            this.Close();
        }

        private void BayarBtn_Click(object sender, EventArgs e)
        {
            if (_listKeranjang == null || _listKeranjang.Count == 0)
            {
                MessageBox.Show("Tidak ada item untuk dibayar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormPembayaran Bayar = new FormPembayaran(this._formInduk, this, this._listKeranjang);

            Bayar.ShowDialog();

            if (_listKeranjang.Count == 0)
            {
                this.Close();
            }
        }

        public void SelesaiBayar()
        {
            FlpKeranjang.Controls.Clear();
            _listKeranjang.Clear();
            this.Close();
        }

        private void FormKeranjang_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (_listKeranjang.Count > 0 && _formInduk != null)
            {
                _formInduk.Show();
                _formInduk.TampilanKasir();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}