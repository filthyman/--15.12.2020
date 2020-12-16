using BookStoreProject.Models;
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
    public partial class BooksFormEditor : Form
    {
        private int BookId = 0;

        public Book ChangeData 
        {
            get 
            {
                return new Book
                {
                    Id = BookId,
                    Title = titleBox.Text,
                    Year = (int)yearNumeric.Value,
                    Author = authorBox.Text,
                    Description = descriptionBox.Text
                };
            }
        }
        public BooksFormEditor()
        {
            InitializeComponent();
            acceptButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
        }

        public DialogResult ShowDialog(Book data) 
        {
            BookId = data.Id;
            titleBox.Text = data.Title;
            yearNumeric.Value = data.Year;
            authorBox.Text = data.Author;
            descriptionBox.Text = data.Description;

            return ShowDialog();
        }
    }
}
