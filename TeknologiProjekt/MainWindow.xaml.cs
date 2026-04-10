using System;
using System.Windows;
using System.Windows.Controls;

namespace TeknologiProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count = 0;
        private int strength = 1;
        private const int UPGRADE_COST = 10;

        public MainWindow()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPoints();
            UpdateUI();
        }

        private void AddPoints()
        {
            count += strength;
        }

        private void btnUpgradeStrength_Click(object sender, RoutedEventArgs e)
        {
            if (count >= UPGRADE_COST)
            {
                count -= UPGRADE_COST;
                strength += 1;
                UpdateUI();
            }
            else
            {
                MessageBox.Show($"Du mangler {UPGRADE_COST - count} points for at opgradere!", "Ikke nok points", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void UpdateUI()
        {
            tbCount.Text = count.ToString();
            tbStrength.Text = strength.ToString();
            btnUpgradeStrength.IsEnabled = count >= UPGRADE_COST;
        }
    }
}