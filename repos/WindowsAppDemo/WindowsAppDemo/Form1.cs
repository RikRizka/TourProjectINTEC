using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppDemo.Models;

namespace WindowsAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void btnLoadBooks_Click(object sender, EventArgs e)
        {
            List<Book> book = Models.DataBase.PopulateBooks();
            lstBooks.DataSource = book;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lstBooks_DoubleClick(object sender, EventArgs e)
        {
            Book selectedbook = (Book)lstBooks.SelectedItem;
            txtTitle.Text = selectedbook.Title;
            txtTitle.Text = selectedbook.Author;
            txtYearPublished.Text = selectedbook.YearPublished.ToString();
            txtGenre.Text = selectedbook.Genre;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.YearPublished = int.Parse(txtYearPublished.Text);
            book.Genre = txtGenre.Text;
            DataBase.Books.Add(book);

            lstBooks.DataSource =null;
            List<Book> books = DataBase.PopulateBooks();
            DataBase.Books.Add(book);
            lstBooks.DataSource=books;

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Book selectedbook = (Book)lstBooks.SelectedItem;    
            

           
        }
    }
}
