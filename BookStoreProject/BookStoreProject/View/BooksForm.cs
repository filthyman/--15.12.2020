using BookStoreProject.Models;
using BookStoreProject.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreProject.View
{
    public partial class BooksForm : Form
    {
        public event Action<Book> ChangeData;
        public event Action<Book> DeletData;
        public event Action AddData;
        private bool itsAdmin = false;
        public BooksForm(bool istAdmin)
        {
            InitializeComponent();
            if (!istAdmin)
            {
                deleteButton.Hide();
                cangeButton.Hide();
                addButton.Hide();
            }
        }

        public void ShowData(List<Book> data) 
        {
            booksView.DataSource = data; 
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var row = booksView.SelectedRows[0];
            var books = row.DataBoundItem as Book;
            DeletData(books);


        }

        private void cangeButton_Click(object sender, EventArgs e)
        {
            var row = booksView.SelectedRows[0];
            var books = row.DataBoundItem as Book;
            ChangeData(books);
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            AddData();
        }
    }
}
