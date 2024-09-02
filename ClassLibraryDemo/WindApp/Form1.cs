using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLibrary;

namespace WindApp
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
          
        }
        private void lblRun_Click(object sender, EventArgs e)
        {
            TestClass test = new TestClass();
            //lstShow.Text = test.Print();
            //lstShow.Text += "\n" + test.Print(txtFirstName.Text);
            //lstShow.Text += "\n" + test.Print(txtLastName.Text);
            //lstShow.Text += "\n" + test.CalculateAge(Convert.ToDateTime(txtBornYear.Text)); 

            lstShow.Items.Add(test.Print());
            lstShow.Items.Add(test.Print(lblLastName.Text));
            lstShow.Items.Add(test.CalculateAge(Convert.ToDateTime(txtBornYear.Text)));
            lstShow.Size = new Size(100, 100);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size oldsize = lstShow.Size;

            lblBornYear.Text = "Born Date"; // untuk mengganti/memasukan nama
        }
        private void btnReverse_Click(object sender, EventArgs e)
        {

        }

        private void txtReverse_Click(object sender, EventArgs e)
        {

        }

        private void lstShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
