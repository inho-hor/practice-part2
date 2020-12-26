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
using System.Windows.Shapes;

namespace practice
{
    /// <summary>
    /// Логика взаимодействия для ware.xaml
    /// </summary>
    public partial class ware : Window
    {
        public ware()
        {
            InitializeComponent();
        }

        private void exitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void furnitureClick(object sender, RoutedEventArgs e)
        {

        }

        private void productClick(object sender, RoutedEventArgs e)
        {

        }

        private void clothClick(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }


        private void cloth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void furniture_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
