using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakipAdonet
{
    public class ProductDAL : OrtakDAL
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = sqlCommand.ExecuteReader(); // sql sorgusunu çalıştırıyoruz ve verileri okuyoruz
            while (reader.Read())
            {
                var product = new Product
                {
                    Id = (long) reader["Id"],
                    ProductName = Convert.ToString(reader["ProductName"]),
                    Status = (bool) reader["Status"],
                    CreateDate = Convert.ToDateTime(reader["CreateDate"]),
                    Price =     Convert.ToDecimal(reader["Price"]),
                    Description = Convert.ToString(reader["Description"]),
                    StocksCount = (int) reader["StocksCount"],
                    CategoryID = (long) reader["CategoryID"],
                    BrandID = (long) reader["BrandID"]
                };
                products.Add(product);
            }

            reader.Close(); // SqlDataReader'ı kapatıyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            sqlCommand.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            return products;
        }

        public List<Product> GetSearchedProducts(string searchText)
        {
            var products = new List<Product>();

            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand($"Select * from Products where ProductName like '%{searchText}%' or Description like '%{searchText}%'", _connection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                var product = new Product
                {
                    Id = (long)reader["Id"],
                    ProductName = Convert.ToString(reader["ProductName"]),
                    Status = (bool)reader["Status"],
                    CreateDate = Convert.ToDateTime(reader["CreateDate"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                    Description = Convert.ToString(reader["Description"]),
                    StocksCount = (int)reader["StocksCount"],
                    CategoryID = (long)reader["CategoryID"],
                    BrandID = (long)reader["BrandID"]
                };

                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            sqlCommand.Dispose();
            return products;
        }

        public int Add(Product product)
        {
            int sonuc = 0;
                

            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Insert into Products (ProductName, Status, CreateDate, Price, Description, StocksCount, CategoryID, BrandID) " +
                "values (@ProductName, @Status, @CreateDate, @Price, @Description, @StocksCount, @CategoryID, @BrandID)", _connection);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Status", product.Status);
            cmd.Parameters.AddWithValue("@CreateDate", product.CreateDate);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@StocksCount", product.StocksCount);
            cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
            cmd.Parameters.AddWithValue("@BrandID", product.BrandID);

            MessageBox.Show(cmd.CommandText);

            sonuc = cmd.ExecuteNonQuery();
            cmd.Dispose();
            _connection.Close();
            return sonuc;
        }



        public int Update(Product product)
        {
            int sonuc = 0;


            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Update Products Set ProductName=@ProductName, Status=@Status, Price=@Price, Description=@Description, StocksCount=@StocksCount, CategoryID=@CategoryID, BrandID=@BrandID " +
                " where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Status", product.Status);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@StocksCount", product.StocksCount);
            cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
            cmd.Parameters.AddWithValue("@BrandID", product.BrandID);
            cmd.Parameters.AddWithValue("@Id", product.Id);
            sonuc = cmd.ExecuteNonQuery();
            cmd.Dispose();
            _connection.Close();
            return sonuc;
        }

        public int Delete(long Id)
        {
            int sonuc = 0;

            ConnectionControl();

            SqlCommand cmd = new SqlCommand("Delete from Products where Id=@Id", _connection);

            cmd.Parameters.AddWithValue("@Id", Id);
            sonuc = cmd.ExecuteNonQuery();
            cmd.Dispose();
            _connection.Close();
            return sonuc;

        }


    }
}
