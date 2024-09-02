using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindDelegate
{
   // public delegate string PersonFormat(Person person);
    public partial class Form1 : Form
    {
        Func<Person, string > formatPerson;
       //PersonFormat formatPerson; di gunakan untuk public delegate
        public void AssignToDelegate()
        {
            if (rdOptionDefault.Checked)
            {
                formatPerson = Formates.Default;
            }
            else if (rbOptionLastName.Checked)
            {
                formatPerson = Formates.LastNametoUpper;
            }
            else if (rbFirstName.Checked)
            {
                formatPerson = Formates.FirstNameToUpper;
            }

            else if (rbFullName.Checked)
            {
                formatPerson = Formates.FullName;
            }
        }
        public Form1()
        {
            InitializeComponent();
            var people = People.GetPeople(); //List daro people
            foreach (var itme in people)
            {
                lstPersonListBox.Items.Add(itme);
            }
        }

        private void btnProccesData_Click(object sender, EventArgs e)
        {
            lstAutputListBox.Items.Clear();
            AssignToDelegate();
            foreach (Person person in lstPersonListBox.Items)
            {
                lstAutputListBox.Items.Add((person.ToString(formatPerson)));
            }
        }

        private void Form1_Load(object sender, EventArgs e) // bagian ini hanya untuk langsung mencentang default
        {
            rdOptionDefault.Checked = true;
        }

        private void lstPersonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
