using BookStoreProject.Models;
using BookStoreProject.Provider;
using BookStoreProject.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreProject.Controllers
{
    class UsersController
    {
        private StorageContext _context;
        private AutorisationForm _view;
        public UsersController(StorageContext context, AutorisationForm view)
        {
            _context = context;
            _view = view;
            _view.NeedCheckInformation += SingIn;
        }

        public void SingIn(string username, string password) 
        {
            var result = _context.User.Get(username);
            bool itsAdmin = false;
            if (result != null)
                if (username == result.Username && password == result.Password)
                {
                    if (result.Role == "admin")
                        itsAdmin = true;

                    var window = new BooksForm(itsAdmin);
                    var context = new StorageContext();
                    var controller = new BooksController(context, window);
                    window.ShowDialog();
                }
                else
                    System.Windows.Forms.MessageBox.Show("invalid data");
            else
                System.Windows.Forms.MessageBox.Show("invalid data");
        }
    }
}
