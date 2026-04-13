using System.Collections.ObjectModel;
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
        private int cost = 25;
        private ObservableCollection<string> CurrentAutoClickers {  get; set; } = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            lbAutoClickers.ItemsSource = CurrentAutoClickers;
        }
        public void UpdateUI() => Application.Current.Dispatcher.Invoke(() => tbCount.Text = Points.GetPoints().ToString());

        private void MainButton(object sender, RoutedEventArgs e)
        {
            Points.AddPoints();
            tbCount.Text = Points.GetPoints().ToString();
        }

        public void RemoveClickerUI() => Application.Current.Dispatcher.Invoke(() => CurrentAutoClickers.RemoveAt(0));

        private void AutoClickerButton(object sender, RoutedEventArgs e)
        {
            if (Points.GetPoints() >= cost)
            {
                Points.RemovePoints(cost);
                CurrentAutoClickers.Add("Auto Clicker");
                var clicker = new AutoClicker(UpdateUI, RemoveClickerUI);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}