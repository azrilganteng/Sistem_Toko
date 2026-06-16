using Sistem_Toko.Model;
using System.Collections.Generic;
using System.Data;

namespace Sistem_Toko.Controller
{
    public class UserController
    {
        /// <summary>
        /// Ambil daftar semua karyawan via v_daftar_karyawan.
        /// </summary>
        public DataTable GetDaftarKaryawan()
        {
            return UserContext.GetDaftarKaryawan();
        }

        /// <summary>
        /// Ambil detail data karyawan berdasarkan ID.
        /// </summary>
        public Dictionary<string, string> GetKaryawanById(int userId)
        {
            return UserContext.GetKaryawanById(userId);
        }

        /// <summary>
        /// Ambil daftar role yang dimiliki karyawan.
        /// </summary>
        public List<string> GetRolesKaryawan(int userId)
        {
            return UserContext.GetRolesKaryawan(userId);
        }

        /// <summary>
        /// Tambah karyawan baru via fn_tambah_user.
        /// Return id_user yang baru dibuat.
        /// </summary>
        public int TambahKaryawan(string username, string password, string nama,
                                  string noHp, string alamat, string email)
        {
            return UserContext.TambahKaryawan(username, password, nama, noHp, alamat, email);
        }

        /// <summary>
        /// Update data karyawan (username, password, nama, dll).
        /// Trigger fn_log_perubahan_user otomatis mencatat perubahan.
        /// </summary>
        public void UpdateKaryawan(int userId, string username, string password,
                                   string nama, string noHp, string alamat, string email)
        {
            UserContext.UpdateKaryawan(userId, username, password, nama, noHp, alamat, email);
        }

        /// <summary>
        /// Hapus semua kewenangan/role karyawan (sebelum assign ulang).
        /// </summary>
        public void HapusKewenanganKaryawan(int userId)
        {
            UserContext.HapusKewenanganKaryawan(userId);
        }

        /// <summary>
        /// Assign role baru ke karyawan.
        /// </summary>
        public void InsertRoleKaryawan(int idUser, string roleName)
        {
            UserContext.InsertRoleKaryawan(idUser, roleName);
        }

        /// <summary>
        /// Nonaktifkan (soft delete) karyawan.
        /// Trigger fn_log_perubahan_user otomatis mencatat perubahan.
        /// </summary>
        public void NonaktifkanKaryawan(int userId)
        {
            UserContext.NonaktifkanKaryawan(userId);
        }

        /// <summary>
        /// Ambil info profil user via fn_get_user_info.
        /// </summary>
        public void GetUserInfo(int id)
        {
            UserContext.GetUserInfo(id);
        }

        /// <summary>
        /// Ambil profil lengkap user (nama, email, role, dll).
        /// </summary>
        public Dictionary<string, string> GetProfilUser(int userId)
        {
            return UserContext.GetProfilUser(userId);
        }

        /// <summary>
        /// Update profil user yang sedang login.
        /// Trigger fn_log_perubahan_user otomatis mencatat perubahan.
        /// </summary>
        public void UpdateProfil(int userId, string nama, string username,
                                 string email, string noHp, string alamat)
        {
            UserContext.UpdateProfil(userId, nama, username, email, noHp, alamat);
        }
    }
}
