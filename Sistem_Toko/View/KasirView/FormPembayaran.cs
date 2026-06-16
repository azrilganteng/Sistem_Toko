using Sistem_Toko.View.KasirView;
using Sistem_Toko.Model;
using Sistem_Toko.Helpers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        private int SimpanDataPengiriman(NpgsqlConnection conn, NpgsqlTransaction transaction, int idKurir)
        {
            string sqlPengiriman = @"CALL p_simpan_pengiriman(@idKurir);";

            using (var cmdKirim = new NpgsqlCommand(sqlPengiriman, conn, transaction))
            {
                cmdKirim.Parameters.AddWithValue("idKurir", idKurir);
                cmdKirim.ExecuteNonQuery();
            }

            string sqlGetId = "SELECT MAX(id_pengiriman) FROM pengiriman WHERE id_user = @idKurir;";
            using (var cmdGet = new NpgsqlCommand(sqlGetId, conn, transaction))
            {
                cmdGet.Parameters.AddWithValue("idKurir", idKurir);
                return Convert.ToInt32(cmdGet.ExecuteScalar());
            }
        }

        private bool UpdateStok(string metodeBayar, string metodeKirim, int idKurir, string alamat, int idCustomer)
        {
            if (_listBarang.Count == 0)
            {
                MessageBox.Show("Gagal Transaksi: Keranjang belanja kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (var conn = connectDB.GetConn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        int idOrderBaru = 0;
                        int idKasirAktif = 0;

                        if (_formKeranjang != null && _formKeranjang._formInduk != null && _formKeranjang._formInduk._kasirActive != null)
                        {
                            idKasirAktif = _formKeranjang._formInduk._kasirActive.ID;
                        }
                        else
                        {
                            idKasirAktif = SessionUser.Id; 
                        }

                        string sqlOrder = "SELECT fn_buat_order_baru(@idUser, @metodeBayar, @metodeKirim);";
                        using (var cmdOrder = new NpgsqlCommand(sqlOrder, conn, transaction))
                        {
                            cmdOrder.Parameters.AddWithValue("idUser", idKasirAktif);
                            cmdOrder.Parameters.AddWithValue("metodeBayar", metodeBayar);
                            cmdOrder.Parameters.AddWithValue("metodeKirim", metodeKirim);

                            idOrderBaru = Convert.ToInt32(cmdOrder.ExecuteScalar());
                        }

                        if (idCustomer > 0)
                        {
                            string sqlSetCustomer = "UPDATE orders SET id_customer = @idCustomer WHERE id_order = @idOrder;";
                            using (var cmdCust = new NpgsqlCommand(sqlSetCustomer, conn, transaction))
                            {
                                cmdCust.Parameters.AddWithValue("idCustomer", idCustomer);
                                cmdCust.Parameters.AddWithValue("idOrder", idOrderBaru);
                                cmdCust.ExecuteNonQuery();
                            }
                        }

                        if (metodeKirim.Equals("Dikirim", StringComparison.OrdinalIgnoreCase) && idKurir > 0)
                        {
                            int idPengiriman = SimpanDataPengiriman(conn, transaction, idKurir);

                            string sqlLink = "UPDATE orders SET id_pengiriman = @idPengiriman WHERE id_order = @idOrder;";
                            using (var cmdLink = new NpgsqlCommand(sqlLink, conn, transaction))
                            {
                                cmdLink.Parameters.AddWithValue("idPengiriman", idPengiriman);
                                cmdLink.Parameters.AddWithValue("idOrder", idOrderBaru);
                                cmdLink.ExecuteNonQuery();
                            }
                        }

                        foreach (var item in _listBarang)
                        {
                            if (item.ProdukItem != null)
                            {
                                string sqlDetail = "SELECT fn_tambah_detail_order(@idOrder, @idProduk, @jumlah, @harga);";
                                using (var cmdDetail = new NpgsqlCommand(sqlDetail, conn, transaction))
                                {
                                    decimal subTotalHarga = (decimal)(item.Qty * item.ProdukItem.Harga);
                                    cmdDetail.Parameters.AddWithValue("idOrder", idOrderBaru);
                                    cmdDetail.Parameters.AddWithValue("idProduk", item.ProdukItem.Id);
                                    cmdDetail.Parameters.AddWithValue("jumlah", item.Qty);
                                    cmdDetail.Parameters.AddWithValue("harga", subTotalHarga);

                                    cmdDetail.ExecuteScalar();
                                }
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Gagal memperbarui data transaksi ke database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
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