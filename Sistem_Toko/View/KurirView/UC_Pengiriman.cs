using System;
using System.Windows.Forms;
using Sistem_Toko.Model;

namespace Sistem_Toko.View.KurirView
{
    public partial class UC_Pengiriman : UserControl
    {
        private KurirForm _Parent;

        public Pengiriman PengirimanData { get; private set; }

        public UC_Pengiriman(
            KurirForm formInduk,
            int idPengiriman,
            string alamat,
            string statusPengiriman,
            DateTime tanggalKirim,
            int idOrder,
            int idUser)
        {
            InitializeComponent();

            this._Parent = formInduk;

            this.PengirimanData = new Pengiriman
            {
                IdPengiriman = idPengiriman,
                Alamat = alamat,
                StatusPengiriman = statusPengiriman,
                TanggalKirim = tanggalKirim,
                IdOrder = idOrder,
                IdUser = idUser
            };

            lblPesanan.Text = "Pesanan #" + idOrder;
            lblAlamat.Text = alamat;
            lblStatus.Text = statusPengiriman;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            if (_Parent != null && PengirimanData != null)
            {
                _Parent.UpdateStatusPengiriman(PengirimanData);

                MessageBox.Show(
                    $"Pesanan #{PengirimanData.IdOrder} berhasil diperbarui!",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void lblAlamat_Click(object sender, EventArgs e)
        {

        }
    }
}