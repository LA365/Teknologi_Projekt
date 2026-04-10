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

namespace TeknologiProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly object _lock = new object();
        public MainWindow()
        {
            InitializeComponent();
        }
        int Count { get; set; } = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPoints();
            tbCount.Text = Count.ToString();

        } 
        void AddPoints()
        {
            lock (_lock)
            {
                Count++;
            }
        }


    }
}