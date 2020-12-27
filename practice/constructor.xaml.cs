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
using System.Windows.Media.Animation;
using System.Data.Entity;

namespace practice
{
    /// <summary>
    /// Логика взаимодействия для constructor.xaml
    /// </summary>
    public partial class constructor : Window
    {
        practiceEntities practiceEntities;
        public constructor()
        {
            InitializeComponent();
            practiceEntities = new practiceEntities();
            practiceEntities.cloth.Load();
            typeCloth_combobox.ItemsSource = practiceEntities.cloth.Local.ToBindingList();
            practiceEntities.furniture.Load();
            typeFur_combobox.ItemsSource = practiceEntities.furniture.Local.ToBindingList();
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
            if (length_textbox.Text.Length == 0 || width_textbox.Text.Length == 0)
            {
                MessageBox.Show("Введите параметры");
                return;
            }

            var length = Convert.ToDouble(length_textbox.Text.Trim());
            var width = Convert.ToDouble(width_textbox.Text.Trim());
            Rectangle rectangle = new Rectangle();
            rectangle.Fill = Brushes.Gray;
            rectangle.Width = width;
            rectangle.Height = length;
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
