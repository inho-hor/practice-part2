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
    /// Логика взаимодействия для registration.xaml
    /// </summary>
    public partial class registration : Window
    {
        practiceEntities practiceEntities;
        public registration()
        {
            InitializeComponent();
            practiceEntities = new practiceEntities();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            using (practiceEntities practiceEntities = new practiceEntities())
            {
                var name = name_textbox.Text;
                var login = log_textbox.Text;
                var pass = password_textbox.Password;
                var doublePass = doublepassword_textbox.Password;

                if (name.Length > 0)
                {
                    if (login.Length > 0)
                    {
                        if (pass.Length > 0)
                        {
                            if (doublePass.Length > 0)
                            {
                                if (pass == doublePass)
                                {
                                    user user = new user();
                                    user.nameUser = name;
                                    user.login = login;
                                    user.password = pass;
                                    user.role = "customer";
                                    practiceEntities.user.Add(user);
                                    practiceEntities.SaveChanges();
                                    MessageBox.Show("Успешная регистрация");
                                    
                                }
                                else
                                    MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                            }
                            else
                                MessageBox.Show("Вы не ввели пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        else
                            MessageBox.Show("Вы не ввели пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                        MessageBox.Show("Вы не ввели логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                    MessageBox.Show("Вы не ввели имя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void regexit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void logButton_Click(object sender, RoutedEventArgs e)
        {
            login log = new login();
            this.Close();
            log.Show();
        }
    }
}
