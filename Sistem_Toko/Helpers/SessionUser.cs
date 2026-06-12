using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem_Toko.Helpers
{
    public static class SessionUser
    {
        public static int IdUser { get; set; }
        public static string Username { get; set; }
        public static string Nama { get; set; }
        public static string NoHp { get; set; }
        public static string Email { get; set; }
        public static int IdRole { get; set; }
        public static bool IsReady { get; set; }
    }
}
