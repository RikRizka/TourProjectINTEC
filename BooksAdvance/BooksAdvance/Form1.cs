using LibrarryStoreProcedure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksAdvance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();

        }

        private void Insert()
        {
            if (lblIdInvisible.Text == "")
            {
                //Insert
            }
            else
            {
                //Insert
            }
            if ((int)cmbCountry.SelectedValue < 0)
            {
                MessageBox.Show("You should select a country");
                lblEror.Visible = true;
                lblEror.Text = "You should select a country";
            }
            else
            {
                Book book = new Book();
                book.CountryId = (int)cmbCountry.SelectedValue;
                book.Title = txtTitle.Text;
                book.Author = txtAuthor.Text;
                book.Price = decimal.Parse(txtPrice.Text);
                book.Description = txtDescribe.Text;

                BookRepo bookRepo = new BookRepo();
                bookRepo.AddBook(book);
                lblEror.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCountry();
        }

        private void FillCountry()
        {
            List<Country> countriesWithText = new List<Country>();
            countriesWithText.Add(new Country { Id = -1, Name = "Select Country" });

            CountryRepo countryrepo = new CountryRepo();
            List<Country> countrylist = countryrepo.GetCountrys();

            countriesWithText.AddRange(countrylist);

            this.cmbCountry.Items.Clear();
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "Id";
            this.cmbCountry.DataSource = countriesWithText;
        }
        private void FillListBooxWithBook()
        {
            List<Book> booklist = new List<Book>();
            BookRepo bookRepo = new BookRepo();
            booklist = bookRepo.GetBooks();
            foreach (var item in booklist)
            {
                lstBooks.Items.Add(item);
            }
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Book book = lstBooks.SelectedItem as Book;
            Book book = new Book();
            book = (Book)lstBooks.SelectedItem;
            if (book != null)
            {
                txtTitle.Text = book.Title;
                txtAuthor.Text = book.Author;
                txtPrice.Text = book.Price.ToString();
                txtDescribe.Text = book.Description;
                lblIdInvisible.Text = book.Id.ToString();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            cmbCountry.SelectedIndex = 0;
            lblIdInvisible.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPrice.Text = "";
            txtDescribe.Text = "";
            //MessageBox.Show.(cmbCountry.SelectedValue)

            Book book = new Book();
            book = (Book)lstBooks.SelectedItem;
            if (book != null)
            {
                BookRepo bookRepo = new BookRepo();
                bookRepo.DeleteBook(book);
            }
        }
    }
}
