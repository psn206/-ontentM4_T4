using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Сontent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculationDollar_Click(object sender, RoutedEventArgs e)
        {
          rezultDollar.Text = (Convert.ToDouble(inputDollar.Text)* Convert.ToDouble(sumDollar.Text)).ToString();
        }

        private void calculationEuro_Click(object sender, RoutedEventArgs e)
        {
            rezultEuro.Text = (Convert.ToDouble(inputEuro.Text) * Convert.ToDouble(sumEuro.Text)).ToString();
        }

        private void calculationHryvnia_Click(object sender, RoutedEventArgs e)
        {
            rezultHryvnia.Text = (Convert.ToDouble(inputHryvnia.Text) * Convert.ToDouble(sumHryvnia.Text)).ToString();
        }

        private void calculationDram_Click(object sender, RoutedEventArgs e)
        {
            rezultDram.Text = (Convert.ToDouble(inputDram.Text) * Convert.ToDouble(sumDram.Text)).ToString();
        }

        private void calculationInch_Click(object sender, RoutedEventArgs e)
        {
            rezultInch.Text = (Convert.ToDouble(inputInch.Text)* 0.0254).ToString();
        }

        private void calculationMiles_Click(object sender, RoutedEventArgs e)
        {
            rezultMiles.Text = (Convert.ToDouble(inputMiles.Text) * 1609.34).ToString();
        }

        private void calculationFeet_Click(object sender, RoutedEventArgs e)
        {
            rezultFeet.Text = (Convert.ToDouble(inputFeet.Text) * 0.3048).ToString();
        }

        private void calculationVersts_Click(object sender, RoutedEventArgs e)
        {
            rezultVersts.Text = (Convert.ToDouble(inputVersts.Text) * 1066.8).ToString();
        }
    }
}
