using System.Windows;
using BierenLibrary;
using System.Text;
using System.Collections.Generic;
using BierenLibrary;
using System.Threading.Tasks;




namespace wpfMethodeChain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BierenService service = new BierenService();

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MeerDan7Alcohol(object sender, RoutedEventArgs e)
        {
          
            
        }

        private void MeerDan7Alcohol_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Bier> AlcoholMeerDan7 = service.Bieren
              .Where(m => m.Brouwer == "Jupiler" || m.Alcohol <= 1 || m.Alcohol == 5)
              .ToList();

            // Tampilkan data di dalam ListBox atau item lainnya di UI
            foreach (var item in AlcoholMeerDan7)
            {
                // Tambahkan item ke ListBox atau tampilan lainnya
                lst.Items.Add(item.Brouwer + " " + item.Alcohol);
            }
        }

        private void lst(object sender, System.Windows.Controls.ContextMenuEventArgs e)
        {

        }
    }
}