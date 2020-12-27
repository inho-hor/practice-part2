﻿using System;
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
    /// Логика взаимодействия для customer.xaml
    /// </summary>
    public partial class customer : Window
    {
        practiceEntities practiceEntities;
        public customer()
        {
            InitializeComponent();
            practiceEntities = new practiceEntities();
            practiceEntities.product.Load();
            products.ItemsSource = practiceEntities.product.Local.ToBindingList();
            practiceEntities.cloth.Load();
            cloths.ItemsSource = practiceEntities.cloth.Local.ToBindingList();
            practiceEntities.furniture.Load();
            furnitures.ItemsSource = practiceEntities.furniture.Local.ToBindingList();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void productClick(object sender, RoutedEventArgs e)
        {
                products.Visibility = Visibility.Visible;
                cloths.Visibility = Visibility.Collapsed;
                furnitures.Visibility = Visibility.Collapsed;
                var Product = practiceEntities.product;
                products.ItemsSource = Product.ToList();
        }

        private void clothClick(object sender, RoutedEventArgs e)
        {

        }

        private void furnitureClick(object sender, RoutedEventArgs e)
        {

        }

        private void ordersClick(object sender, RoutedEventArgs e)
        {

        }

        private void constructorClick(object sender, RoutedEventArgs e)
        {

        }

        private void orderClick(object sender, RoutedEventArgs e)
        {

        }

        private void exitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
