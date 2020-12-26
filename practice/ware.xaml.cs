using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        practiceEntities practiceEntities;
        public ware()
        {
            InitializeComponent();
            practiceEntities = new practiceEntities();
            practiceEntities.clothWarehouse.Load();
            cloth.ItemsSource = practiceEntities.clothWarehouse.Local.ToBindingList();
            practiceEntities.furnitureWarehouse.Load();
            furniture.ItemsSource = practiceEntities.furnitureWarehouse.Local.ToBindingList();
        }

        private void exitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void furnitureClick(object sender, RoutedEventArgs e)
        {
            furniture.Visibility = Visibility.Visible;
            cloth.Visibility = Visibility.Hidden;
            var furnitureWareHouse = practiceEntities.furnitureWarehouse;
            furniture.ItemsSource = furnitureWareHouse.ToList();
        }


        private void clothClick(object sender, RoutedEventArgs e)
        {
            cloth.Visibility = Visibility.Visible;
            furniture.Visibility = Visibility.Hidden;
            var clothWareHouse = practiceEntities.clothWarehouse;
            cloth.ItemsSource = clothWareHouse.ToList();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
