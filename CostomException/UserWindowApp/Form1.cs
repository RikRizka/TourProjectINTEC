using CostomException;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserWindowApp
{
    public partial class FrmLogin : Form
    {
        UserValidation user = new UserValidation();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            LoginInformation loginInformation = new LoginInformation()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
            };
            UserValidation userValidation = new UserValidation();
            try
            {
                string result = userValidation.ValidateLoginData(loginInformation);
                Console.WriteLine(result);
            }
            catch (UserNameExpection ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (PasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) // Genereci
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
