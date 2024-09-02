using LibCalculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUi
{
    
    public partial class Form1 : Form
    {
       
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Add(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
            //calculator.Total += result;
            // txtTotal.Text = calculator.Total.ToString();
            // txtTotal.ReadOnly = true;
            
        }

        private void ShowResult(double result)
        {
            Calculator cal = new Calculator();
            txtResult.Text = result.ToString();
            txtResult.ReadOnly = true;
            Calculator.Total += double.Parse(txtResult.Text);
            txtTotal.Text = Calculator.Total.ToString();

        }

        private void btnSubtruct_Click(object sender, EventArgs e)
        {
           
            double result = calculator.Subtract(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
        }

       

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double result = calculator.Multiply(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            double result = calculator.Divide(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
        }

        private void lblFirstNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
