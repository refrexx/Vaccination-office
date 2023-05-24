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
    /// <summary>
    /// Логика взаимодействия для NavigationPage.xaml
    /// </summary>
    public partial class NavigationPage : Page
    {
        public NavigationPage()
        {
            InitializeComponent();
        }

        private void BtnPatientClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PatientPage());
        }

        private void BtnPriemClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReceptionPage());
        }

        
    }
}
