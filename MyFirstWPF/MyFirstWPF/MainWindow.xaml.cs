using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyFirstWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            List<string> strings = new List<string>();
            strings.Add(txtfirstName.Text + " " + txtSecondName.Text);
            txtfirstName.Text = string.Empty;
            txtSecondName.Text = string.Empty;
            txtfirstName.Focus();
            foreach (string s in strings)
            {
                lstList.Items.Add(s.ToString());
            }

        }
        private void lstnames_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(lstList.SelectedItem.ToString());
        }

        private void txtfirstName_TextChanged()
        {

        }
    }
}