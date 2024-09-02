﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "Click me";
            b.Location = new Point(200, 200);
            b.Size = new Size(100, 50);
            this.Controls.Add(b);
            b.Click += new EventHandler(b_Click);
        }
        private void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You click me");
        }
    }
}
