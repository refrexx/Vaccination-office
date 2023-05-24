﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursovoy.Pages
{
    
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogClick(object sender, RoutedEventArgs e)
        {
            try
            {



                var currentUser = App.Context.Users
                    .FirstOrDefault(p => p.Login == TBoxLogin.Text && p.Password == PBoxPassword.Password);

                if (currentUser != null)
                {
                    App.CurrentUser = currentUser;
                    NavigationService.Navigate(new NavigationPage());
                }

                else
                {
                    MessageBox.Show("Пользователь с такими данными не найден.", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при авторизации", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }


}
