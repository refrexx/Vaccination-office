using Kursovoy.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
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
    /// Логика взаимодействия для PatientPage.xaml
    /// </summary>
    public partial class PatientPage : Page
    {
        public PatientPage()
        {
            InitializeComponent();

            

            try
            {
                DGridPatient.ItemsSource = App.Context.Пациент.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ComboSortBy.SelectedIndex = 0;
            UpdatePatient();
        }

        private void BtnAddPatientClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditPatientPage());
        }

       
        private void BtnEditPatientClick(object sender, RoutedEventArgs e)
        {
            var currentPatient = (sender as Button).DataContext as Entities.Пациент;
            NavigationService.Navigate(new AddEditPatientPage(currentPatient));
        }

        private void BtnDelPatientClick(object sender, RoutedEventArgs e)
        {

            try
            {

                var currentPatient = (sender as Button).DataContext as Entities.Пациент;

                if (MessageBox.Show("Вы уверены, что хотите удалить пациента: " + currentPatient.Фамилия + " " + currentPatient.Имя + " " + currentPatient.Отчество + " " + currentPatient.Дата_рождения + " ?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    App.Context.Пациент.Remove(currentPatient);
                    App.Context.SaveChanges();
                    UpdatePatient();
                }
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



            private void ComboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdatePatient();
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdatePatient();
        }

        private void TBoxSearchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdatePatient();
        }

        private void TBoxSearchPatronymic_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdatePatient();
        }

        private void UpdatePatient()
        {
            try
            {


                var patient = App.Context.Пациент.ToList();

                if (ComboSortBy.SelectedIndex == 0)
                    patient = patient.OrderBy(p => p.Дата_рождения).ToList();
                else if (ComboSortBy.SelectedIndex == 1)
                    patient = patient.OrderByDescending(p => p.Дата_рождения).ToList();
                else
                    patient = patient.OrderBy(p => p.Фамилия).ToList();

                patient = patient.Where(p => p.Фамилия.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
                DGridPatient.ItemsSource = patient;

                patient = patient.Where(p => p.Имя.ToLower().Contains(TBoxSearchName.Text.ToLower())).ToList();
                DGridPatient.ItemsSource = patient;

                patient = patient.Where(p => p.Отчество.ToLower().Contains(TBoxSearchPatronymic.Text.ToLower())).ToList();
                DGridPatient.ItemsSource = patient;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdatePatient();
        }
    }


}

