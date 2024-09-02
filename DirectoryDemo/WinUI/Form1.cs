using System;
using System.IO;
using LibraryIO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryIO.Models;
using System.Configuration;

namespace WinUI
{
    public partial class Form1 : Form
    {
        //string path = @"c:\TempTest\\books.txt";
        string path = ConfigurationManager.AppSettings["file"]; // selalu di gunakan
        List<Book> temp = new List<Book>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ShowList();
        }

        private void ShowList()
        {
            lstBook.Items.Clear();
            List<Book> list;
            try
            {
                list = Processes.ReadFromFile(path);
                foreach (var item in list)
                {

                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var book = (Book)lstBook.SelectedItem;
            txtAuthor.Text = book.Author;
            txtName.Text = book.txtName;
                txtYear.Text =book.txtYear.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = txtName.Text;
            book.Author = txtAuthor.Text;
            book.Year = int.Parse(txtYear.Text);
            Processes.WriteToFile(temp, path);
            ShowList();

        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            lstBook.Items.Remove(lstBook.SelectedIndex);
            foreach (var item in lstBook.Items)
            {
                temp.Add((Book)item);
            }
            Processes.WriteToFile(temp, path, false);
            Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = txtName.Text;
            book.Author = txtAuthor.Text;
            book.Year = int.Parse(txtYear.Text);
            Processes.WriteFileOneBook(book, path);
            foreach (var item in lstBook.Items)
            {
                temp.Add((Book)item);
            }
            Processes.WriteToFile(temp, Path, false);
        }
    }
}
