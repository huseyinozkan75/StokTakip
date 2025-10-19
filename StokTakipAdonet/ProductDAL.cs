using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipAdonet
{
    public class ProductDAL : OrtakDAL
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand sqlCommand = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = sqlCommand.ExecuteReader(); // sql sorgusunu çalıştırıyoruz ve verileri okuyoruz
            while (reader.Read())
            {
                var product = new Product
                {
                    Id = (Int64) reader["Id"],
                    ProductName = Convert.ToString(reader["ProductName"]),
                    Status = (bool) reader["Status"],
                    CreateDate = Convert.ToDateTime(reader["CreateDate"]),
                    Price =     Convert.ToDecimal(reader["Price"]),
                    Description = Convert.ToString(reader["Description"]),
                    StocksCount = (int)reader["StocksCount"],
                    CategoryID = (Int64)reader["CategoryID"],
                    BrandID = (Int64)reader["BrandID"]
                };
                products.Add(product);
            }

            reader.Close(); // SqlDataReader'ı kapatıyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            sqlCommand.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            return products;
        }


    }
}
