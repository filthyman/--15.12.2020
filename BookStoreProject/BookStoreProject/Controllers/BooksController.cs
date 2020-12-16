using BookStoreProject.Models;
using BookStoreProject.Provider;
using BookStoreProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreProject.Controllers
{
    class BooksController
    {
        private StorageContext _context;
        private BooksForm _view;

        public BooksController(StorageContext context, BooksForm view)
        {
            _context = context;
            _view = view;
            _view.Load += InitialHandler;
            _view.ChangeData += ChangeDataHandler;
            _view.DeletData += DeleteDataHandler;
            _view.AddData += AddDataHandler;
        }

        public void InitialHandler(object o, EventArgs e) 
        {
            RefreshDataHandler();
        }
        public void RefreshDataHandler() 
        {
            try
            {
                List<Book> result = _context.Books.GetAllBooks();
                _view.ShowData(result);
            }
            catch 
            {
                System.Windows.Forms.MessageBox.Show("error");
            }
        }

        public void ChangeDataHandler(Book data) 
        {
            var books = _context.Books.GetAllBooks();
            var editor = new BooksFormEditor();

            var result = editor.ShowDialog(data);

            if (result != DialogResult.OK)
                return;
            
            _context.Books.Update(editor.ChangeData);

            RefreshDataHandler();
        }

        public void AddDataHandler()
        {
            var books = _context.Books.GetAllBooks();
            var editor = new BooksFormEditor();

            var result = editor.ShowDialog();

            if (result != DialogResult.OK)
                return;

            _context.Books.Insert(editor.ChangeData);

            RefreshDataHandler();
        }

        public void DeleteDataHandler(Book data) 
        {
            _context.Books.Delete(data.Id);

            RefreshDataHandler();
        }
    }
}
