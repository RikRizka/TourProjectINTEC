using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitWin
{
    public partial class Form1 : Form
    {
        string path = @"c:\INTEC\Data0.1\bieren.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int CountCharacters()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                Thread.Sleep(1000);
                string conten = reader.ReadToEnd();
                int count = conten.Length;
                return count;
            }
        }

        private async void btnProcces_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();
            lblMessage.Text = "Processing infprmation.... Please wait";
            int count = await task;
            lblMessage.Text = $"Numbers of characters in the file is {count}";
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
       
        }
    }
}
