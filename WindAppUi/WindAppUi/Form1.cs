using ClassLibraryCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindAppUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateAdd_Click(object sender, EventArgs e)
        {
            RekenMachin rekenMachine = new RekenMachin();
           int result = rekenMachine.Add(int.Parse(txtFirstNr.Text), int.Parse(txtSecindNr.Text));
            lblResult.Text = result.ToString();
        }

        private void btnCalculateDev_Click(object sender, EventArgs e)
        {
            RekenMachin rekenMachine = new RekenMachin();
            int result = rekenMachine.Div(int.Parse(txtFirstNr.Text), int.Parse(txtSecindNr.Text));
            lblResult.Text = result.ToString();
        }
    }
}
