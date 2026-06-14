using Sistem_Toko.Controller;
using Sistem_Toko.Model;
using Sistem_Toko.View.KurirView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistem_Toko.View.KurirView
{
    public partial class KurirForm : Form
    {
        public KurirForm()
        {
            InitializeComponent();

            ShowPengiriman();
        }

        public void ShowPengiriman()
        {
            PengirimanController pc = new PengirimanController();
            List<Pengiriman> listPengiriman = pc.GetAllPengiriman();

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
        private void KurirForm_Load(object sender, EventArgs e)
        {
            ShowPengiriman();
        }


        private void lblPengiriman_Click(object sender, EventArgs e)
        {

        }


        public void UpdateStatusPengiriman(Pengiriman pengiriman)
        {
            PengirimanController controller = new PengirimanController();

            controller.UpdateStatusPengiriman(pengiriman);
        }
    }
}