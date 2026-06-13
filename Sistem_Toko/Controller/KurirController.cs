using Npgsql;
using System.Data;
using Sistem_Toko.Helpers;

namespace Sistem_Toko.Controller
{
    public class KurirController
    {
        public DataTable GetPengirimanByKurir(int idUser)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string sql = "SELECT * FROM get_pengiriman_kurir(@idUser)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("idUser", idUser);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public void SelesaikanPengiriman(int idOrder)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string sql = "SELECT selesaikan_pengiriman(@id)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", idOrder);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}