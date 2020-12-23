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
        practiceEntities practiceEntities;
        static public int sw_roll = 0;
        public login()
        {
            InitializeComponent();
            practiceEntities = new practiceEntities();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (practiceEntities practiceEntities = new practiceEntities())
            {
                var login = log_textbox.Text;
                var password = password_textbox.Password;
                var user = practiceEntities.user;
                var result = user.Where(i => i.login == login && i.password == password);
                if (result.Count() > 0)
                {
                    this.Hide();
                    switch (result.FirstOrDefault().role)
                    {
                        case "admin":
                            {
                                admin admin = new admin();
                                admin.Show();
                                break;
                            }
                        case "manager":
                            {
                                manager manager = new manager();
                                manager.Show();
                                break;
                            }
                        case "ware":
                            {
                                ware ware = new ware();
                                ware.Show();
                                break;
                            }
                        case "customer":
                            {
                                customer customer = new customer();
                                customer.Show();
                                break;
                            }
                    }
                }
                else if (login.Length == 0)
                {
                    MessageBox.Show("Вы не ввели логин.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (password.Length == 0)
                {
                    MessageBox.Show("Вы не ввели пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    MessageBox.Show("Такой пользователь не найден.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
