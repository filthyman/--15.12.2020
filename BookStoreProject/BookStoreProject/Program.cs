using BookStoreProject.Controllers;
using BookStoreProject.Provider;
using BookStoreProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var window = new AutorisationForm();
            var context = new StorageContext();
            var controller = new UsersController(context,window);
            Application.Run(window);
        }
    }
}
