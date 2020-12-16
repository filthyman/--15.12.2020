using BookStoreProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreProject.Provider
{
    public class UserProvider
    {
        private SqlConnection _connection;

        public UserProvider(SqlConnection connection)
        {
            _connection = connection;
        }
        public User Get(string login)
        {
            var result = new User();
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(@"SELECT * FROM [Users] WHERE [username] = @Username", _connection);
                cmd.Parameters.AddWithValue("@Username", login);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new User
                        {
                            Id = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2),
                            Role = reader.GetString(3)
                        };
                        result = user;
                    }
                }
                return result;
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
