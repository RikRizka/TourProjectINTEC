using ComaSaperatedFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPeople
{
    public partial class Form1 : Form
    {
        private string filePath;
        private Person person;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "Test.txt";
            string filePath = Path.Combine(projectDirectory, fileName);

            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');
                Person person = new Person();
                person.FirstName = entries[0];
                person.LastName = entries[1];
                person.Address = entries[2];

                people.Add(person);
            }
           // Console.WriteLine("Read form text file");
            foreach (var item in people)
            {
               listBox1.Items.Add(item);
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
