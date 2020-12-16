using BookStoreProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreProject.Provider
{
    public class BooksProvider
    {
        private SqlConnection _connection;
        public BooksProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Book> GetAllBooks() 
        {
            var result = new List<Book>();
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(@"
                                        SELECT
                                            [id],
                                            [title],
                                            [year],
                                            [description],
                                            [author]
                                        FROM 
                                            [BooksStorage] 
                                        WHERE 
                                            [isDeleted] = 'False' ", _connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var books = new Book
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Year = reader.GetInt32(2),
                            Description = reader.GetString(3),
                            Author = reader.GetString(4)
                        };
                        result.Add(books);
                    }
                }
                return result;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Insert(Book data)
        {
            bool result = false;
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(
                    @"INSERT INTO [BooksStorage]
                           ([title], [year], [description], [author])
                      VALUES 
                           (@Title,@Year,@description,@author)
                     ", _connection);
                cmd.Parameters.AddWithValue("@Title", data.Title);
                cmd.Parameters.AddWithValue("@Year", data.Year);
                cmd.Parameters.AddWithValue("@Description", data.Description);
                cmd.Parameters.AddWithValue("@Author", data.Author);

                result = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }
        public bool Update(Book data)
        {
            bool result = false;
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(
                    @"  
                        UPDATE [BooksStorage]
                        SET
                            [title] = @Title,
                            [year] = @Year,
                            [description] = @Description,
                            [author] = @Author
                        WHERE 
                            [id] =  @Id
                     ", _connection);
                cmd.Parameters.AddWithValue("@Title", data.Title);
                cmd.Parameters.AddWithValue("@Year", data.Year);
                cmd.Parameters.AddWithValue("@Description", data.Description);
                cmd.Parameters.AddWithValue("@Author", data.Author);
                cmd.Parameters.AddWithValue("@Id", data.Id);
                result = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(
                    @"
                        DELETE FROM [BooksStorage]
                        WHERE [id] = @Id
                     ", _connection);
                cmd.Parameters.AddWithValue("@Id", id);
                result = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }
    }
}
