using Sistem_Toko.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistem_Toko.View
{
    public partial class FormProfil : Form
    {
        public FormProfil()
        {
            InitializeComponent();

            DataProfil();
        }

        private void DataProfil()
        {
            TokoLbl.Text = "TOKO TANI SAMUDRA";

            NamaLbl.Text = "Nama  : " + SessionUser.Nama;
            RoleLbl.Text = "Role  : " + SessionUser.Role;

            UserLbl.Text = "Username\n" + SessionUser.Username;
            EmailLbl.Text = "Password\n" + SessionUser.Email;

            AlamatLbl.Text = "Alamat: " + SessionUser.Alamat;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
