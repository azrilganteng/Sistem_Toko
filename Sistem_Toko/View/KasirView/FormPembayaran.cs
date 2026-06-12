using Npgsql;
using Sistem_Toko.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace Sistem_Toko
{

    public partial class FormPembayaran : Form
    {
        private FormKeranjang _formKeranjang;
        private List<Detail_orders> _listBarang;
        private FormKasir _formKasir;
        public FormPembayaran(FormKasir formKasir, FormKeranjang formKeranjang, List<Detail_orders> listBarang)
        {
            InitializeComponent();
            this._formKasir = formKasir;
            this._formKeranjang = formKeranjang;
            this._listBarang = listBarang;

            TampilDetail();
        }
        private void TampilDetail()
        {
            double TotalBayar = 0;

            foreach (var item in _listBarang)
            {
                double subtotal = item.Qty * item.ProdukItem.Harga;
                TotalBayar += subtotal;

                txtNota.AppendText($"{item.ProdukItem.NamaProduk} \t Qty: {item.Qty} x Rp. {item.ProdukItem.Harga:N0} \t Subtotal: Rp. {subtotal:N0}\r\n");
            }
            lblTotal.Text = $"Total Bayar: Rp. {TotalBayar:N0}";
        }

        private void KonfirmBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menyelesaikan pembayaran?", "Konfirmasi Pembayaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               if(UpdateStok())
                {
                    MessageBox.Show("Pembayaran berhasil! Stok produk telah diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _listBarang.Clear();

                    _formKeranjang.SelesaiBayar();
                    _formKasir.Show();
                    this.Close();
                }
            }
        }

        private bool UpdateStok()
        {
            using (var conn = connectDB.GetConn())
            {
                using (var transaction = conn.BeginTransaction()) 
                {
                    try
                    {
                        int idOrderBaru = 0;

                        string sqlOrder = "SELECT buat_order_baru(@idUser, @metodeBayar, @metodeKirim);";
                        using (var cmdOrder = new NpgsqlCommand(sqlOrder, conn))
                        {
                            int idKasirAktif = this._formKeranjang._formInduk._kasirActive.ID;

                            cmdOrder.Parameters.AddWithValue("idUser", idKasirAktif);
                            cmdOrder.Parameters.AddWithValue("metodeBayar", "Online");
                            cmdOrder.Parameters.AddWithValue("metodeKirim", "Langsung");


                            idOrderBaru = Convert.ToInt32(cmdOrder.ExecuteScalar());
                        }
                        foreach (var item in _listBarang)
                        {
                            string sqlDetail = "SELECT tambah_detail_order(@idOrder, @idProduk, @jumlah, @harga);";
                            using (var cmdDetail = new NpgsqlCommand(sqlDetail, conn))
                            {
                                decimal subTotalHarga = (decimal)(item.Qty * item.ProdukItem.Harga);

                                cmdDetail.Parameters.AddWithValue("idOrder", idOrderBaru);
                                cmdDetail.Parameters.AddWithValue("idProduk", item.ProdukItem.Id);
                                cmdDetail.Parameters.AddWithValue("jumlah", item.Qty);
                                cmdDetail.Parameters.AddWithValue("harga", subTotalHarga);

                                cmdDetail.ExecuteScalar();
                            }
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal memperbarui data ke database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                    
                
            }
        }
    }
}
