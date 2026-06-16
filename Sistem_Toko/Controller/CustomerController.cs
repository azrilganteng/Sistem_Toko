using Sistem_Toko.Model;
using System.Collections.Generic;

namespace Sistem_Toko.Controller
{
    public class CustomerController
    {
        /// <summary>
        /// Ambil semua customer dari database via v_customer.
        /// </summary>
        public List<Customer> GetAllCustomers()
        {
            return CustomerContext.GetAllCustomers();
        }

        /// <summary>
        /// Cari customer berdasarkan nama (case-insensitive).
        /// Return Customer jika ditemukan, null jika tidak ada.
        /// </summary>
        public Customer CariByNama(string nama)
        {
            return CustomerContext.CariByNama(nama);
        }

        /// <summary>
        /// Tambah customer baru via fn_tambah_customer.
        /// Return id_customer yang baru dibuat.
        /// </summary>
        public int TambahCustomer(string nama, string noHp, string alamat)
        {
            return CustomerContext.TambahCustomer(nama, noHp, alamat);
        }
    }
}
