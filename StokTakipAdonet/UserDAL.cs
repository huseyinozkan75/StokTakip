using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipAdonet
{
    public class UserDAL : OrtakDAL
    {
        public List<User> GetUsers()
        {
            var users = new List<User>();
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Select * from Users", _connection);
            SqlDataReader reader = sqlCommand.ExecuteReader(); // sql sorgusunu çalıştırıyoruz ve verileri okuyoruz
            while (reader.Read())
            {
                var user = new User
                {
                    Id = (long) reader["Id"],
                    Name = Convert.ToString(reader["Name"]),
                    Surname = Convert.ToString(reader["Surname"]),
                    Email = Convert.ToString(reader["Email"]),
                    Password = Convert.ToString(reader["Password"]),
                    IsActive = (bool) reader["IsActive"],
                    CreateDate = Convert.ToDateTime(reader["CreateDate"])
                };

                users.Add(user);
            }

            reader.Close(); // SqlDataReader'ı kapatıyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            sqlCommand.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            return users;
        }

    }
}
