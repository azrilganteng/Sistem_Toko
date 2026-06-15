using Sistem_Toko.Controller;
using Sistem_Toko.Controller;
using Sistem_Toko.Helpers;
using Sistem_Toko.Model;
using Sistem_Toko.Model;
using Sistem_Toko.View.KurirView;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Sistem_Toko.View.KurirView
{
    public partial class KurirForm : Form
    {
        public KurirForm()
        {
            InitializeComponent();
        }

        private void KurirForm_Load(object sender, EventArgs e)
        {
            ShowPengiriman();
        }

        public void ShowPengiriman()
        {
            PengirimanController pc = new PengirimanController();

            List<Pengiriman> listPengiriman = pc.GetPengirimanKurirAktif(SessionUser.Id);

            FlpPengiriman.Controls.Clear();

            foreach (var item in listPengiriman)
            {
                UC_Pengiriman uc = new UC_Pengiriman(
                    this,
                    item.IdPengiriman,
                    item.Alamat,
                    item.StatusPengiriman,
                    item.TanggalKirim,
                    item.IdOrder,
                    item.IdUser
                );

                FlpPengiriman.Controls.Add(uc);
            }
        }

        public void UpdateStatusPengiriman(int idPengiriman, string statusBaru)
        {
            PengirimanController controller = new PengirimanController();
            bool berhasil = controller.UpdateStatusPengiriman(idPengiriman, statusBaru);

            if (berhasil)
            {
                ShowPengiriman();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui status di database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}