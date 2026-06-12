using Sistem_Toko.Controller;
using Sistem_Toko.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistem_Toko.View.KasirView
{
    public partial class FormPilihKurir : Form
    {
        public Kurir PilKurir { get; private set; }
        public string AlamatKirim { get; private set; }
        public FormPilihKurir()
        {
            InitializeComponent();
            LoadKurirToComboBox();
        }
        private void LoadKurirToComboBox()
        {
            KurirController kc = new KurirController();
            var listKurir = kc.GetKurir();

            CboKurir.DataSource = listKurir;
            CboKurir.DisplayMember = "Nama"; 
            CboKurir.ValueMember = "Id";
        }
    }
}
