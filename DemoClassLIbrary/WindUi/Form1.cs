using LibCalculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindUi
{

    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void p_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            double result=calculator.Add(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
        }

        private void ShowResult(double result)
        {
            txtResult.Text = result.ToString();
            txtFirstNumber.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click_1(object sender, EventArgs e)
        {
           
            double result = calculator.Substract(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
        }

        private void btnMultiplay_Click(object sender, EventArgs e)
        {
           
            double result = calculator.Multiplay(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
           
            double result = calculator.Devide(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
