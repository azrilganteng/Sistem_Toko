using Microsoft.VisualBasic.ApplicationServices;
using Sistem_Toko.Controller;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sistem_Toko.Model
{
    public class Kurir : User
    {
    
        public bool IsReady { get; set; }
        public string PlatNo { get; set; }

     
        public Kurir(int id, string nama, string username, string password, string platNo, bool isReady)
             : base(id, nama, username, password) 
        {

            this.IsReady = isReady;
        }
        //optional dipake karna aku lagi tes pengiriman dari kasir ke kurir
        public override bool Login(string username, string password)
        {
            AuthController auth = new AuthController();
            return auth.LoginKurir(username, password);

            
        }
    }
}
