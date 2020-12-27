using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для addCloth.xaml
    /// </summary>
    public partial class addCloth : Window
    {
        public addCloth()
        {
            InitializeComponent();
        }

        private void choose_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users";

            openFileDialog.ShowDialog();
            string text = openFileDialog.ToString();
            text = text.Replace("Microsoft.Win32.OpenFileDialog: Title: , FileName: ", "");
            name_textbox.Text = text; 
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            constructor constructor = new constructor();
            this.Close();
            constructor.Show();
        }
    }
}
