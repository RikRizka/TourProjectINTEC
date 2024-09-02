using GemeenschapCL;
using GemeenschapCL.Models;
using GemeenschapCL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EindOpGaveDapperWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Docent> campuses = new List<Docent>();
            DocentRepo opleidingenServices = new DocentRepo();
            campuses = opleidingenServices.GetAllDocent();
            this.cmbSelecteerCMPS.Items.Clear();
            lblSelectCmps.Text = string.Empty;

        }

        private void lblSelectCmps_Click(object sender, EventArgs e)
        {

        }
    }
}
