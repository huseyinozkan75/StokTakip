using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipAdonet
{
    public class CategoryDAL : OrtakDAL
    {

        public List<Category> GetCategories()
        {
            var categories = new List<Category>();
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand sqlCommand = new SqlCommand("Select * from Categories", _connection);
            SqlDataReader reader = sqlCommand.ExecuteReader(); // sql sorgusunu çalıştırıyoruz ve verileri okuyoruz
            while (reader.Read())
            {
                var category = new Category
                {
                    Id = (Int64)reader["Id"],
                    CategoryName = Convert.ToString(reader["CategoryName"]),
                    Description = Convert.ToString(reader["Description"])
                };
                categories.Add(category);
            }

            reader.Close(); // SqlDataReader'ı kapatıyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            sqlCommand.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            return categories;
        }


        public List<Category> GetSearchedCategories(string searchText)
        {
            var categories = new List<Category>();
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand($"Select * from Categories where CategoryName like '%{searchText}%' or Description like '%{searchText}%'", _connection);

            SqlDataReader reader = sqlCommand.ExecuteReader(); // sql sorgusunu çalıştırıyoruz ve verileri okuyoruz
            while (reader.Read())
            {
                var category = new Category
                {
                    Id = (Int64)reader["Id"],
                    CategoryName = Convert.ToString(reader["CategoryName"]),
                    Description = Convert.ToString(reader["Description"])
                };

                categories.Add(category);
            }

            reader.Close(); // SqlDataReader'ı kapatıyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            sqlCommand.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            return categories;
        }

        public int Add(Category category)
        {
            int sonuc = 0;

            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Insert into Categories (CategoryName, Description) " +
                "values (@CategoryName, @Description)", _connection);
            cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            cmd.Parameters.AddWithValue("@Description", category.Description);
            sonuc = cmd.ExecuteNonQuery();
            cmd.Dispose();
            _connection.Close();
            return sonuc;
        }



        public int Update(Category category)
        {
            int sonuc = 0;

            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Update Categories Set CategoryName=@CategoryName, Description=@Description" +
                " where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            cmd.Parameters.AddWithValue("@Description", category.Description);
            cmd.Parameters.AddWithValue("@Id", category.Id);
            sonuc = cmd.ExecuteNonQuery();
            cmd.Dispose();
            _connection.Close();
            return sonuc;
        }

        public int Delete(long Id)
        {
            int sonuc = 0;

            ConnectionControl();

            SqlCommand cmd = new SqlCommand("Delete from Categories where Id=@Id", _connection);

            cmd.Parameters.AddWithValue("@Id", Id);
            sonuc = cmd.ExecuteNonQuery();
            cmd.Dispose();
            _connection.Close();
            return sonuc;

        }





    }



}
