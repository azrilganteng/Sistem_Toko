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
        private bool _isKembaliKeKasir = false;
        private List<Detail_orders> _listKeranjang;
        public FormKeranjang(FormKasir formInduk, List<Detail_orders> listKeranjang)
        {
            InitializeComponent();
            this._formInduk = formInduk;
            this._listKeranjang = listKeranjang;

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
        private void FormKeranjang_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (_isKembaliKeKasir)
            {
                if (this._formInduk != null)
                {
                    this._formInduk.Show();
                }
            }
            else
            {
                Application.Exit();
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
                    MessageBox.Show("Keranjang Anda sekarang kosong.", "Informasi");
                    this.Close();
                }
            }
        }
        private void PupukBtn_Click(object sender, EventArgs e)
        {
            _isKembaliKeKasir = true;
            this.Close();
        }

        private void BayarBtn_Click(object sender, EventArgs e)
        {
            if (_listKeranjang == null || _listKeranjang.Count == 0)
            {
                MessageBox.Show("Tidak ada item untuk dibayar!", "Peringatan");
                return;
            }
            FormPembayaran Bayar = new FormPembayaran(this, this._listKeranjang);
            this.Hide();
            Bayar.ShowDialog();

            if (_listKeranjang.Count > 0 && !this.IsDisposed)
            {
                this.Show();
            }
        }

        public void SelesaiBayar()
        {
            _isKembaliKeKasir = true; 
            this.Close();
        }
    }
}
