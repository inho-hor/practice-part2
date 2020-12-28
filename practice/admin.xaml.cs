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
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Window
    {
        practiceEntities practiceEntities;
        public admin()
        {
            InitializeComponent();
            practiceEntities = new practiceEntities();
            practiceEntities.product.Load();
            products.ItemsSource = practiceEntities.product.Local.ToBindingList();
            practiceEntities.cloth.Load();
            cloths.ItemsSource = practiceEntities.cloth.Local.ToBindingList();
            practiceEntities.furniture.Load();
            furnitures.ItemsSource = practiceEntities.furniture.Local.ToBindingList();
            practiceEntities.clothWarehouse.Load();
            clothWare.ItemsSource = practiceEntities.clothWarehouse.Local.ToBindingList();
            practiceEntities.furnitureWarehouse.Load();
            furnitureWare.ItemsSource = practiceEntities.furnitureWarehouse.Local.ToBindingList();
            practiceEntities.user.Load();
            user.ItemsSource = practiceEntities.user.Local.ToBindingList();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void productClick(object sender, RoutedEventArgs e)
        {
            products.Visibility = Visibility.Visible;
            cloths.Visibility = Visibility.Collapsed;
            furnitures.Visibility = Visibility.Collapsed;
            orders.Visibility = Visibility.Collapsed;
            furnitureWare.Visibility = Visibility.Collapsed;
            clothWare.Visibility = Visibility.Collapsed;
            user.Visibility = Visibility.Collapsed;

            var Product = practiceEntities.product;
            products.ItemsSource = Product.ToList();
        }

        private void clothClick(object sender, RoutedEventArgs e)
        {
            products.Visibility = Visibility.Collapsed;
            cloths.Visibility = Visibility.Visible;
            furnitures.Visibility = Visibility.Collapsed;
            orders.Visibility = Visibility.Collapsed;
            furnitureWare.Visibility = Visibility.Collapsed;
            clothWare.Visibility = Visibility.Collapsed;
            user.Visibility = Visibility.Collapsed;

            var Cloth = practiceEntities.cloth;
            cloths.ItemsSource = Cloth.ToList();
        }

        private void furnitureClick(object sender, RoutedEventArgs e)
        {
            products.Visibility = Visibility.Collapsed;
            cloths.Visibility = Visibility.Collapsed;
            furnitures.Visibility = Visibility.Visible;
            orders.Visibility = Visibility.Collapsed;
            furnitureWare.Visibility = Visibility.Collapsed;
            clothWare.Visibility = Visibility.Collapsed;
            user.Visibility = Visibility.Collapsed;

            var Furniture = practiceEntities.furniture;
            furnitures.ItemsSource = Furniture.ToList();
        }

        private void orderClick(object sender, RoutedEventArgs e)
        {
            products.Visibility = Visibility.Collapsed;
            cloths.Visibility = Visibility.Collapsed;
            furnitures.Visibility = Visibility.Collapsed;
            orders.Visibility = Visibility.Visible;
            furnitureWare.Visibility = Visibility.Collapsed;
            clothWare.Visibility = Visibility.Collapsed;
            user.Visibility = Visibility.Collapsed;

            var Order = practiceEntities.order;
            orders.ItemsSource = Order.ToList();
        }

        private void wareClick(object sender, RoutedEventArgs e)
        {

        }

        private void clothWareClick(object sender, RoutedEventArgs e)
        {
            products.Visibility = Visibility.Collapsed;
            cloths.Visibility = Visibility.Collapsed;
            furnitures.Visibility = Visibility.Collapsed;
            orders.Visibility = Visibility.Collapsed;
            clothWare.Visibility = Visibility.Visible;
            furnitureWare.Visibility = Visibility.Collapsed;
            user.Visibility = Visibility.Collapsed;

            var clothWareHouse = practiceEntities.clothWarehouse;
            clothWare.ItemsSource = clothWareHouse.ToList();
        }

        private void furnitureWareClick(object sender, RoutedEventArgs e)
        {
            products.Visibility = Visibility.Collapsed;
            cloths.Visibility = Visibility.Collapsed;
            furnitures.Visibility = Visibility.Collapsed;
            orders.Visibility = Visibility.Collapsed;
            furnitureWare.Visibility = Visibility.Visible;
            clothWare.Visibility = Visibility.Collapsed;
            user.Visibility = Visibility.Collapsed;

            var furnitureWareHouse = practiceEntities.furnitureWarehouse;
            furnitureWare.ItemsSource = furnitureWareHouse.ToList();
        }

        private void exitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void userClick(object sender, RoutedEventArgs e)
        {
            products.Visibility = Visibility.Collapsed;
            cloths.Visibility = Visibility.Collapsed;
            furnitures.Visibility = Visibility.Collapsed;
            orders.Visibility = Visibility.Collapsed;
            furnitureWare.Visibility = Visibility.Collapsed;
            clothWare.Visibility = Visibility.Collapsed;
            user.Visibility = Visibility.Visible;

            var User = practiceEntities.user;
            user.ItemsSource = User.ToList();
        }
    }
}
