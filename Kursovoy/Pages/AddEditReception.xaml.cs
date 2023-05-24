using Kursovoy.Entities;
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
    /// Логика взаимодействия для AddEditReception.xaml
    /// </summary>
    public partial class AddEditReception : Page
    {
        private Entities.Прием_пациента _currentReception = null;
        public AddEditReception()
        {
            InitializeComponent();

            try
            {

                CBoxPatient.ItemsSource = App.Context.Пациент.ToList();
                
                CBoxPatient.SelectedValuePath = "Код_пациента";
                CBoxPatient.DisplayMemberPath = "СНИЛС";
                

                CBoxPreparat.ItemsSource = App.Context.Препарат.ToList();
                
                CBoxPreparat.SelectedValuePath = "Код_препарата";
                CBoxPreparat.DisplayMemberPath = "Название";
                

                CBoxWorker.ItemsSource = App.Context.Сотрудник.ToList();
                
                CBoxWorker.SelectedValuePath = "Код_сотрудника";
                CBoxWorker.DisplayMemberPath = "Фамилия";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public AddEditReception(Entities.Прием_пациента прием)
        {
            InitializeComponent();

            try
            {

                _currentReception = прием;
                Title = "Редактировать приём";
                CBoxPreparat.Text = _currentReception.Препарат.Название;
                CBoxWorker.Text = _currentReception.Сотрудник.Фамилия;
                CBoxPatient.Text = _currentReception.Пациент.СНИЛС;
                DPDate.Text = _currentReception.Дата_приёма.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string CheckErrors()
        {
            var errorBuilder = new StringBuilder();

            int patient = 0;
            if (int.TryParse(CBoxPatient.Text, out patient) == false || patient <= 0)
                errorBuilder.AppendLine("Поле СНИЛС не заполнено");
            int preparat = 0;
            if (int.TryParse(CBoxPreparat.Text, out preparat) == false || preparat <= 0)
                errorBuilder.AppendLine("Поле препарат не заполнено");
            int worker = 0;
            if (int.TryParse(CBoxWorker.Text, out worker) == false || worker <= 0)
                errorBuilder.AppendLine("Поле сотрудник не заполнено");
            if (string.IsNullOrWhiteSpace(DPDate.Text))
                errorBuilder.AppendLine("Поле дата приёма обязательно для заполнения");


            if (errorBuilder.Length > 0)
                errorBuilder.Insert(0, "Устраните следующие ошибки:\n");

            return errorBuilder.ToString();
        }
        private void BtnSaveClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var errorMessage = CheckErrors();
                if (errorMessage.Length > 0)
                {
                    MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (_currentReception == null)
                    {
                        var receprion = new Entities.Прием_пациента
                        {
                            Дата_приёма = DateTime.Parse(DPDate.Text),
                            Код_пациента = int.Parse(CBoxPatient.SelectedValue.ToString()),
                            Код_препарата = int.Parse(CBoxPreparat.SelectedValue.ToString()),
                            Код_сотрудника = int.Parse(CBoxWorker.SelectedValue.ToString())

                        };
                        App.Context.Прием_пациента.Add(receprion);
                        App.Context.SaveChanges();
                        MessageBox.Show("Данные успешно сохранены");

                    }
                    else
                    {
                        _currentReception.Код_пациента = int.Parse(CBoxPatient.SelectedValue.ToString());
                        _currentReception.Код_сотрудника = int.Parse(CBoxWorker.SelectedValue.ToString());
                        _currentReception.Код_препарата = int.Parse(CBoxPreparat.SelectedValue.ToString());
                        _currentReception.Дата_приёма = DateTime.Parse(DPDate.Text);

                        App.Context.SaveChanges();
                        MessageBox.Show("Данные успешно сохранены");

                    }
                    NavigationService.GoBack();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
