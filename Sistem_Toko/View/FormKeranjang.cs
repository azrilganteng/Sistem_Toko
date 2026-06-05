using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Sistem_Toko
{
    public partial class FormKeranjang : Form
    {
        private FormKasir _formInduk;
        private List<Detail_orders> _listKeranjang;

        // Modifikasi Constructor agar bisa menerima data dari FormKasir
        public FormKeranjang(FormKasir formInduk, List<Detail_orders> listKeranjang)
        {
            InitializeComponent();
            this._formInduk = formInduk;
            this._listKeranjang = listKeranjang;

            TampilkanDaftarKeranjang();
        }

        public void TampilkanDaftarKeranjang()
        {
            // Bersihkan item lama agar tidak duplikat
            FlpKeranjang.Controls.Clear();

            // Render UC_ProdukKeranjang ke dalam Form baru ini
            foreach (Detail_orders item in _listKeranjang)
            {
                // Kita oper _formInduk (FormKasir) agar tombol batal tetap berfungsi nantinya
                UC_ProdukKeranjang ucItem = new UC_ProdukKeranjang(_formInduk, item.ProdukItem, item.Qty);
                FlpKeranjang.Controls.Add(ucItem);
            }
        }
        private void FormKeranjang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this._formInduk != null)
            {
                this._formInduk.Show();
            }
        }
    }
}