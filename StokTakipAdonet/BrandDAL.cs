using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakipAdonet
{
    public class BrandDAL : OrtakDAL
    {

        public List<Brand> GetAllBrands()
        {
            var brands = new List<Brand>();
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Select * from Brands", _connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                var brand = new Brand
                {
                    Id = (long) reader["Id"],
                    BrandName = Convert.ToString(reader["BrandName"]),
                    Description = Convert.ToString(reader["Description"]),
                    Status = (bool) reader["Status"],
                    CreateDate = Convert.ToDateTime(reader["CreateDate"])
                };
                brands.Add(brand);
            }

            reader.Close(); // SqlDataReader'ı kapatıyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            sqlCommand.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            return brands;
        }


        public List<Brand> GetSearchedBrands(string searchText)
        {
            var brands = new List<Brand>();

            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand($"Select * from Brands where BrandName like '%{searchText}%' or Description like '%{searchText}%'", _connection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                var brand = new Brand
                {
                    Id = (long)reader["Id"],
                    BrandName = Convert.ToString(reader["BrandName"]),
                    Description = Convert.ToString(reader["Description"]),
                    Status = (bool)reader["Status"],
                    CreateDate = Convert.ToDateTime(reader["CreateDate"])
                };

                brands.Add(brand);
            }

            reader.Close();
            _connection.Close();
            sqlCommand.Dispose();
            return brands;
        }

        public int Add(Brand brand)
        {
            int sonuc = 0;

            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Insert into Brands (BrandName, Description, Status, CreateDate) " +
                "values (@BrandName, @Description, @Status, @CreateDate)", _connection);
            cmd.Parameters.AddWithValue("@BrandName", brand.BrandName);
            cmd.Parameters.AddWithValue("@Description", brand.Description);
            cmd.Parameters.AddWithValue("@Status", brand.Status);
            cmd.Parameters.AddWithValue("@CreateDate", brand.CreateDate);
            sonuc = cmd.ExecuteNonQuery();
            cmd.Dispose();
            _connection.Close();
            return sonuc;
        }



        public int Update(Brand brand)
        {
            int sonuc = 0;

            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Update Brands Set BrandName=@BrandName, Description=@Description, Status=@Status " +
                " where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@BrandName", brand.BrandName);
            cmd.Parameters.AddWithValue("@Description", brand.Description);
            cmd.Parameters.AddWithValue("@Status", brand.Status);
            cmd.Parameters.AddWithValue("@Id", brand.Id);
            sonuc = cmd.ExecuteNonQuery();
            cmd.Dispose();
            _connection.Close();
            return sonuc;
        }

        public int Delete(long Id)
        {
            int sonuc = 0;

            ConnectionControl();

            SqlCommand cmd = new SqlCommand("Delete from Brands where Id=@Id", _connection);

            cmd.Parameters.AddWithValue("@Id", Id);
            sonuc = cmd.ExecuteNonQuery();
            cmd.Dispose();
            _connection.Close();
            return sonuc;

        }

    }
}
