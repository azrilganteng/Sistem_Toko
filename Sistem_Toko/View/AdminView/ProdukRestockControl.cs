using Sistem_Toko.Model;
using System.Windows.Forms;

namespace Sistem_Toko.View.AdminView
{
    /// <summary>
    /// UserControl yang merepresentasikan satu baris produk di halaman Restock.
    /// Menampilkan nama produk, stok saat ini, checkbox pilih, dan input jumlah restock.
    /// </summary>
    public partial class ProdukRestockControl : UserControl
    {
        public int IdProduk { get; private set; }
        public string NamaProduk => LblNamaProduk.Text;
        public bool Dipilih => ChkPilih.Checked;
        public int JumlahRestock => (int)NumJumlahRestock.Value;

        public ProdukRestockControl(Produk produk)
        {
            InitializeComponent();
            IdProduk = produk.Id;
            LblNamaProduk.Text = produk.NamaProduk;
            LblStokSaatIni.Text = $"Stok saat ini: {produk.Stok}";
            LblDeskripsi.Text = string.IsNullOrWhiteSpace(produk.Deskripsi) ? "-" : produk.Deskripsi;

            // Beri warna latar berbeda jika stok menipis (< 10)
            if (produk.Stok < 10)
            {
                LblStokSaatIni.ForeColor = System.Drawing.Color.OrangeRed;
                LblStokSaatIni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            }
        }

        private void ChkPilih_CheckedChanged(object sender, System.EventArgs e)
        {
            // Aktifkan/nonaktifkan input jumlah sesuai status centang
            NumJumlahRestock.Enabled = ChkPilih.Checked;
        }
    }
}
