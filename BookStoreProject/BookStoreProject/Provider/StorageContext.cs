using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreProject.Provider
{
    public class StorageContext
    {
        public BooksProvider Books { get; private set; }
        public UserProvider User { get; private set; }
        public StorageContext()
        {
            var connection = Connection();
            Books = new BooksProvider(connection);
            User = new UserProvider(connection);

        }

        public SqlConnection Connection() 
        {
            var cmd = new SqlConnectionStringBuilder
            {
                InitialCatalog = "BooksStorage",
                IntegratedSecurity =true,
                DataSource = "DESKTOP-OTQ2DC3"
            };
            return new SqlConnection(cmd.ToString());
        }
    }
}
