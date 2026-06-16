using Sistem_Toko.Controller;
using Sistem_Toko.Helpers;
using Sistem_Toko.Model;
using Sistem_Toko.View.KurirView;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            try
            {
                using (var conn = connectDB.GetConn())
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                    using (var cmd = new Npgsql.NpgsqlCommand("SELECT * FROM v_status_pengiriman", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        var sb = new System.Text.StringBuilder();
                        sb.AppendLine("=== ISI VIEW v_status_pengiriman ===");
                        for (int i = 0; i < reader.FieldCount; i++) sb.Append(reader.GetName(i) + "\t|\t");
                        sb.AppendLine();
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++) sb.Append(reader[i]?.ToString() + "\t|\t");
                            sb.AppendLine();
                        }
                        System.IO.File.WriteAllText(@"debug_pengiriman.txt", sb.ToString());
                    }
                }
            }
            catch { } // abaikan jika error
            
            ShowPengiriman();
        }

        public void ShowPengiriman()
        {
            try
            {
                PengirimanController pc = new PengirimanController();
                List<Pengiriman> listPengiriman = pc.GetPengirimanKurirAktif(SessionUser.Id);

                FlpPengiriman.Controls.Clear();

                // Menampilkan pengiriman kosong tanpa diagnostic
                if (listPengiriman == null || listPengiriman.Count == 0)
                {
                    Label lblKosong = new Label
                    {
                        Text = "Tidak ada pengiriman aktif",
                        Font = new Font("Segoe UI", 12F),
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Margin = new Padding(20)
                    };
                    FlpPengiriman.Controls.Add(lblKosong);
                    return;
                }

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
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data pengiriman:\n" + ex.Message + "\n\nID Kurir: " + SessionUser.Id,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is kurirDashboard)
                {
                    form.Show();
                    break;
                }
            }
            this.Close();
        }
    }
}