using Sistem_Toko.View.KasirView;
using Sistem_Toko.Model;
using Sistem_Toko.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace Sistem_Toko
{
    public partial class FormPembayaran : Form
    {
        private FormKeranjang _formKeranjang;
        private List<Detail_orders> _listBarang;
        private FormKasir _formKasir;
        private int _idCustomer = 0;
        private string _namaCustomer = "";

        //[Browsable(false)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public int IdCustomerProperti
        //{
        //    get => _idCustomer;
        //    set => _idCustomer = value;
        //}

        public FormPembayaran(FormKasir formKasir, FormKeranjang formKeranjang, List<Detail_orders> listBarang)
        {
            InitializeComponent();
            this._formKasir = formKasir;
            this._formKeranjang = formKeranjang;

            this._listBarang = new List<Detail_orders>(listBarang);

            CboMetodeKirim.Items.Clear();
            CboMetodeKirim.Items.Add("Langsung");
            CboMetodeKirim.Items.Add("Dikirim");
            CboMetodeKirim.SelectedIndex = 0;

            CboMetodeBayar.Items.Clear();
            CboMetodeBayar.Items.Add("Cash");
            CboMetodeBayar.Items.Add("Transfer");
            CboMetodeBayar.SelectedIndex = 0;

            TampilDetail();
        }

        private void BtnCariCustomer_Click(object sender, EventArgs e)
        {
            using (FormInputCustomer frmCustomer = new FormInputCustomer())
            {
                if (frmCustomer.ShowDialog() == DialogResult.OK)
                {
                    _idCustomer = frmCustomer.CustomerDipilih;
                    _namaCustomer = frmCustomer.NamaCustomer;
                    TxtCustomer.Text = _namaCustomer;
                }
            }
        }

        private void TampilDetail()
        {
            double TotalBayar = 0;
            txtNota.Clear();

            foreach (var item in _listBarang)
            {
                if (item.ProdukItem != null)
                {
                    double subtotal = item.Qty * item.ProdukItem.Harga;
                    TotalBayar += subtotal;

                    txtNota.AppendText($"{item.ProdukItem.NamaProduk} \t Qty: {item.Qty} x Rp. {item.ProdukItem.Harga:N0} \t Subtotal: Rp. {subtotal:N0}\r\n");
                }
            }
            lblTotal.Text = $"Total Bayar: Rp. {TotalBayar:N0}";
        }

        private void KonfirmBtn_Click(object sender, EventArgs e)
        {
            if (_idCustomer <= 0)
            {
                MessageBox.Show("Silakan pilih customer terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string metodeKirim = CboMetodeKirim.SelectedItem?.ToString() ?? "Langsung";
            string metodeBayar = CboMetodeBayar.SelectedItem?.ToString() ?? "Cash";

            int idKurir = 0;
            string alamat = "";

            if (metodeKirim.Equals("Dikirim", StringComparison.OrdinalIgnoreCase))
            {
                using (FormPilihKurir frmKurir = new FormPilihKurir())
                {
                    if (frmKurir.ShowDialog() == DialogResult.OK)
                    {
                        if (frmKurir.PilKurir != null)
                        {
                            idKurir = frmKurir.PilKurir.ID;
                        }
                        alamat = frmKurir.AlamatKirim;

                        if (idKurir <= 0 || string.IsNullOrWhiteSpace(alamat))
                        {
                            MessageBox.Show("Data kurir atau alamat tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (UpdateStok(metodeBayar, metodeKirim, idKurir, alamat, _idCustomer))
                        {
                            MessageBox.Show("Pembayaran & Penugasan Kurir Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClosePembayaran();
                        }
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menyelesaikan pembayaran?", "Konfirmasi Pembayaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (UpdateStok(metodeBayar, metodeKirim, idKurir, alamat, _idCustomer))
                    {
                        MessageBox.Show("Pembayaran berhasil! Stok produk telah diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClosePembayaran();
                    }
                }
            }
        }

        private void ClosePembayaran()
        {
            _listBarang.Clear();

            if (_formKeranjang != null && !_formKeranjang.IsDisposed)
            {
                _formKeranjang.SelesaiBayar();
                _formKeranjang.Close(); 
            }

            if (_formKasir != null)
            {
                _formKasir.Show();
            }

            this.Close();
        }

        private bool UpdateStok(string metodeBayar, string metodeKirim, int idKurir, string alamat, int idCustomer)
        {
            try
            {
                int idKasirAktif = this._formKasir._kasirActive.ID;
                return OrderContext.UpdateStok(idKasirAktif, metodeBayar, metodeKirim, idKurir, alamat, idCustomer, _listBarang);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FormPembayaran_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_listBarang.Count > 0 && _formKeranjang != null && !_formKeranjang.IsDisposed)
            {
                _formKeranjang.TampilkanDaftarKeranjang();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}