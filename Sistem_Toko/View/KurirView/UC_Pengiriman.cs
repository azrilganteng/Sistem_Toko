using System;
using System.Windows.Forms;
using Sistem_Toko.Model;

namespace Sistem_Toko.View.KurirView
{
    public partial class UC_Pengiriman : UserControl
    {
        private KurirForm _Parent;
        public Pengiriman PengirimanData { get; private set; }

        public UC_Pengiriman(KurirForm formInduk, int idPengiriman, string alamat, string statusPengiriman, DateTime tanggalKirim, int idOrder, int idUser)
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

            this.Click += new EventHandler(KartuPengiriman_Click);
            this.lblPesanan.Click += new EventHandler(KartuPengiriman_Click);
            this.lblAlamat.Click += new EventHandler(KartuPengiriman_Click);
        }
        private void UC_Pengiriman_Load(object sender, EventArgs e)
        {
        }

        private void KartuPengiriman_Click(object sender, EventArgs e)
        {
            if (PengirimanData != null)
            {
                DetailPengiriman detailForm = new DetailPengiriman(PengirimanData.IdOrder, PengirimanData.Alamat);
                detailForm.ShowDialog();
            }
        }

        private void SelesaiBtn_Click(object sender, EventArgs e)
        {
            if (_Parent != null && PengirimanData != null)
            {
                _Parent.UpdateStatusPengiriman(PengirimanData.IdPengiriman, "Selesai");
                MessageBox.Show($"Pesanan #{PengirimanData.IdOrder} selesai dikirim!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}