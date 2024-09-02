using ClassLibraryBooks.Models;
using LibraryNetFremwork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksDBApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Book book = new Book();

            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.Prijs = Decimal.Parse(txtPrice.Text);
            book.Describe = txtDescribe.Text;
            book.CountryId = (int)cmbCountry.SelectedValue;

            BookRepo repo = new BookRepo();
            repo.AddBookReturnId(book);
            //MessageBox.Show(id.ToString());
            FillListBox();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Country> countries = new List<Country>();
            CountryRepo countryRepo = new CountryRepo();
            countries = countryRepo.GetAllCountries();

            this.cmbCountry.Items.Clear();
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "Id";
            cmbCountry.DataSource = countries;
            FillListBox();
        }

        private void FillListBox()
        {
            List<Book> list = new List<Book>();
            BookRepo repo = new BookRepo();
            list = repo.GetAllBooks();
            this.lstBooks.Items.Clear();
            foreach (var item in list)
            {
                lstBooks.Items.Add(item);
            }
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessegeBox.Show(cmbCountry.SelectedValue.Tostring());
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book = (Book)lstBooks.SelectedItem;
            BookRepo bookRepo = new BookRepo();
            bookRepo.DeletBookById(book.Id);

           // FillListBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book book = new Book();
            book = (Book)lstBooks.SelectedItem;

            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtPrice.Text = book.Prijs.ToString();
            txtDescribe.Text = book.Describe;
            txtId.Text = book.Id.ToString();
            cmbCountry.SelectedValue = book.CountryId;   //untuk menunjukan jika klik Alain akan menunjukan negara
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                BookRepo bookRepo = new BookRepo();
                Book book = new Book();
                book.Title = txtTitle.Text;
                book.Author = txtAuthor.Text;
                book.Prijs = Decimal.Parse(txtPrice.Text);
                book.Describe = txtDescribe.Text;
                book.Id = int.Parse(txtId.Text);
                book.CountryId = (int)cmbCountry.SelectedValue;
                //MessageBox.Show(book.Id)
                bookRepo.UpdateBook(book);
            }
            catch (Exception ex)
            {
                this.lblEror.Text = "NOT UPDATE YET";
                lblEror.Visible = true;
            }
            
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
