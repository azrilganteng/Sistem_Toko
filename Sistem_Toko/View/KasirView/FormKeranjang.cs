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

            LblKasir.Text = "Kasir: " + Sistem_Toko.Helpers.SessionUser.Nama;
            TampilkanDaftarKeranjang();
            HitungTotal();
        }

        public void TampilkanDaftarKeranjang()
        {
            FlpKeranjang.Controls.Clear();

            foreach (Detail_orders item in _listKeranjang)
            {
                UC_ProdukKeranjang ucItem = new UC_ProdukKeranjang(this, _formInduk, item.ProdukItem, item.Qty);
                FlpKeranjang.Controls.Add(ucItem);
            }

            HitungTotal();
        }

        private void HitungTotal()
        {
            double total = 0;
            foreach (Detail_orders item in _listKeranjang)
            {
                total += (double)item.Qty * item.ProdukItem.Harga;
            }
            LblTotalKeranjang.Text = $"Total: Rp. {total:N0}";
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

        public void UbahQty(string namaProduk, int newQty)
        {
            foreach (Detail_orders item in _listKeranjang)
            {
                if (item.ProdukItem.NamaProduk == namaProduk)
                {
                    if (newQty <= item.ProdukItem.Stok && newQty > 0)
                    {
                        item.Qty = newQty;
                        TampilkanDaftarKeranjang();
                    }
                    else if (newQty == 0)
                    {
                        HapusItem(namaProduk);
                    }
                    else
                    {
                        MessageBox.Show("Stok tidak mencukupi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
            {
                TampilkanDaftarKeranjang();
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
            if (_formInduk != null)
            {
                _formInduk.Show();
                _formInduk.ShowProduk();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}