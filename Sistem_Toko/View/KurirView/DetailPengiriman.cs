using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Sistem_Toko.Controller;

namespace Sistem_Toko.View.KurirView
{
    public partial class DetailPengiriman : Form
    {
        private int _idOrder;
        private string _alamat;

        public DetailPengiriman(int idOrder, string alamat)
        {
            InitializeComponent();
            this._idOrder = idOrder;
            this._alamat = alamat;
        }

        private void DetailPengiriman_Load(object sender, EventArgs e)
        {
            LblJudul.Text = "Detail Pesanan #" + _idOrder;
            LblTujuan.Text = "Alamat Pengiriman:\n" + _alamat;

            TxtNota.Clear();

            MuatBarangKeNota();
        }

        private void MuatBarangKeNota()
        {
            try
            {
                PengirimanController pc = new PengirimanController();
                DataTable dt = pc.GetDetailBarangOrder(_idOrder);

                double totalBelanja = 0;

                if (dt == null || dt.Rows.Count == 0)
                {
                    TxtNota.Text = "Tidak ada detail barang untuk pesanan ini.";
                    LblTotalHarga.Text = "Total: Rp 0";
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    string namaProduk = row["nama_produk"].ToString();
                    int qty = Convert.ToInt32(row["jumlah"]);
                    double harga = Convert.ToDouble(row["harga"]);

                    double subtotal = qty * harga;
                    totalBelanja += subtotal;

                    TxtNota.AppendText($"{namaProduk} \t Qty: {qty} x Rp. {harga:N0} \t Subtotal: Rp. {subtotal:N0}\r\n");
                }

                LblTotalHarga.Text = $"Total Belanja: Rp. {totalBelanja:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat format nota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}