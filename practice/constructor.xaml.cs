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
    /// Логика взаимодействия для constructor.xaml
    /// </summary>
    public partial class constructor : Window
    {
        public constructor()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            customer customer = new customer();
            this.Close();
            customer.Show();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void show_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addCloth addcloth = new addCloth();
            this.Hide();
            addcloth.Show();
        }
        private void DrawingMouseDown(object sender, RoutedEventArgs e)
        {

        }
        private void DrawingMouseUp(object sender, RoutedEventArgs e)
        {

        }
        private void DrawingMouseMove(object sender, RoutedEventArgs e)
        {

        }

    }
}
