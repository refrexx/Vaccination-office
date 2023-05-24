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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursovoy.Pages
{
    /// <summary>
    /// Логика взаимодействия для ReceptionPage.xaml
    /// </summary>
    public partial class ReceptionPage : Page
    {
        public ReceptionPage()
        {
            InitializeComponent();
            
            
            try
            {
                DGridReception.ItemsSource = App.Context.Прием_пациента.ToList();
                //MessageBox.Show(DGridReception.Items.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ComboSortBy.SelectedIndex = 0;
            UpdateReception();
            
        }

        private void BtnAddPriemClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditReception());
        }

        private void BtnDelPriemClick(object sender, RoutedEventArgs e)
        {
            try
            {

                var currentReception = (sender as Button).DataContext as Entities.Прием_пациента;

                if (MessageBox.Show("Вы уверены, что хотите удалить приём: " + currentReception.Номер_приёма + " " + currentReception.Дата_приёма + " ?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    App.Context.Прием_пациента.Remove(currentReception);
                    App.Context.SaveChanges();
                    UpdateReception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditPriemClick(object sender, RoutedEventArgs e)
        {
            var currentReception = (sender as Button).DataContext as Entities.Прием_пациента;
            NavigationService.Navigate(new AddEditReception(currentReception));
        }

        private void ComboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateReception();
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateReception();
        }

        private void TBoxSearchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateReception();
        }

        private void TBoxSearchPatronymic_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateReception();
        }

        private void TBoxSearchPreparat_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateReception();
        }

        private void TBoxSearchData_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateReception();
        }

        private void UpdateReception()
        {
            try
            {

                var patient = App.Context.Прием_пациента.ToList();
            



            if (ComboSortBy.SelectedIndex == 0)
                patient = patient.OrderBy(p => p.Пациент.Дата_рождения).ToList();
            else if (ComboSortBy.SelectedIndex == 1)
                patient = patient.OrderByDescending(p => p.Пациент.Дата_рождения).ToList();
            else
                patient = patient.OrderBy(p => p.Пациент.Фамилия).ToList();

            patient = patient.Where(p => p.Пациент.Фамилия.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
            DGridReception.ItemsSource = patient;

            patient = patient.Where(p => p.Пациент.Имя.ToLower().Contains(TBoxSearchName.Text.ToLower())).ToList();
            DGridReception.ItemsSource = patient;

            patient = patient.Where(p => p.Пациент.Отчество.ToLower().Contains(TBoxSearchPatronymic.Text.ToLower())).ToList();
            DGridReception.ItemsSource = patient;

            patient = patient.Where(p => p.Препарат.Название.ToLower().Contains(TBoxSearchPreparat.Text.ToLower())).ToList();
            DGridReception.ItemsSource = patient;

            patient = patient.Where(p => p.Пациент.Дата_рождения.ToString().ToLower().Contains(TBoxSearchData.Text.ToLower())).ToList();
            DGridReception.ItemsSource = patient;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateReception();
        }
    }
}
