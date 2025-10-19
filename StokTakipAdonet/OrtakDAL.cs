using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipAdonet
{
    public class OrtakDAL
    {
        internal SqlConnection _connection =
      new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=StockTrackerDb;Integrated Security = True;");
        // veritabanı bağlantısı için SqlConnection nesnesi oluşturuyoruz.

        internal void ConnectionControl()  // Veritabanı bağlantısını kontrol eden metot
        {
            if (_connection.State == ConnectionState.Closed) // eğer bağlantı kapalıysa 
            {
                _connection.Open(); // bağlantıyı aç
            }
        }
    }
}
