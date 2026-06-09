using Npgsql;
using Sistem_Toko.Helpers;
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
        public FormPembayaran(FormKeranjang formKeranjang, List<Detail_orders> listBarang)
        {
            InitializeComponent();
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

                    this.Close();
                    _formKeranjang.SelesaiBayar();

                }
            }
        }

        private bool UpdateStok()
        {
            using (var conn = connectDB.GetConn())
            {
                
                    try
                    {
                        var daftarItem = new List<string>();
                        foreach (var item in _listBarang)
                        {
                            decimal subTotalHarga = (decimal)(item.Qty * item.ProdukItem.Harga);

                        string formatBaris = $"{item.ProdukItem.Id},{item.Qty},{subTotalHarga}";
                        daftarItem.Add(formatBaris);
                    }
                        string sql = "select simpan_transaksi(@idUser, @metodeBayar, @metodeKirim, @items);";

                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            int idKasirAktif = this._formKeranjang._formInduk._kasirActive.ID;

                            cmd.Parameters.AddWithValue("idUser", idKasirAktif);
                            cmd.Parameters.AddWithValue("metodeBayar", "Online");
                            cmd.Parameters.AddWithValue("metodeKirim", "Langsung");

                            cmd.Parameters.AddWithValue("items", daftarItem.ToArray());

                        cmd.ExecuteNonQuery();
                        }
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
