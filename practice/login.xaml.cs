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
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Window
    {
        static public int sw_roll = 0;
        public login()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        enum Roll
        {
            Manager,
            Customer,
            Admin,
            Ware
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (log_textbox.Text.Length > 0 && password_textbox.Password.Length > 0)
                {
                    practiceEntities practice_bd = new practiceEntities();
                    var av = practice_bd.logins;
                    Admin admin = new Admin();
                    Customer customer = new Customer();
                    Ware ware = new Ware();
                    Manager manager = new Manager();
                    var result = av.Where(i => i.login == log_textbox.Text && i.password == password_textbox.Password);
                    if (result.Count() == 1)
                    {
                        this.Close();
                        sw_roll = (int)result.FirstOrDefault().rool;
                        switch (sw_roll)
                        {
                            case (byte)Roll.Manager:
                                manager.ShowDialog();
                                break;
                            case (byte)Roll.Customer:
                                customer.ShowDialog();
                                break;
                            case (byte)Roll.Admin:
                                admin.ShowDialog();
                                break;
                            case (byte)Roll.Ware:
                                ware.ShowDialog();
                                break;
                        }
                    }
                    else
                        MessageBox.Show(string.Format("Не найдено данной комбинации\nЛогин - {0}\nПароль - {1}",
                        log_textbox.Text, password_textbox.Password), "Предупреждение!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                    MessageBox.Show("Поля Логин и Пароль - обязательны к заполнению!", "Ошибка!",
                        MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }
    }
}
