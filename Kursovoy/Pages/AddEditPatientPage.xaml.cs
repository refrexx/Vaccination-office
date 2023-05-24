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
    /// Логика взаимодействия для AddEditPatientPage.xaml
    /// </summary>
    public partial class AddEditPatientPage : Page
    {
        private Entities.Пациент _currentPatient = null;

        public AddEditPatientPage()
        {
            InitializeComponent();

            CBoxAreaNum.ItemsSource = App.Context.Участок.Select(c => c.Номер_участка).ToList();
        }

        public AddEditPatientPage(Entities.Пациент пациент)
        {
            InitializeComponent();

            try
            {

                _currentPatient = пациент;
                Title = "Редактировать пациента";
                TBoxName.Text = _currentPatient.Имя;
                TBoxSurname.Text = _currentPatient.Фамилия;
                TBoxPatronymic.Text = _currentPatient.Отчество;
                TBoxPhoneNum.Text = _currentPatient.Номер_телефона;
                TBoxSNILS.Text = _currentPatient.СНИЛС;
                TBoxWorkPlace.Text = _currentPatient.Место_работы;
                TBoxOProp.Text = _currentPatient.Область_прописки;
                TBoxGender.Text = _currentPatient.Пол;
                TBoxRProp.Text = _currentPatient.Район_прописки;
                TBoxGProp.Text = _currentPatient.Город_прописки;
                TBoxYProp.Text = _currentPatient.Улица_прописки;
                TBoxDProp.Text = _currentPatient.Дом_прописки.ToString();
                TBoxNKProp.Text = _currentPatient.Номер_квартиры_прописки.ToString();
                CBoxAreaNum.Text = _currentPatient.Номер_участка.ToString();
                DPDate.Text = _currentPatient.Дата_рождения.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }







        }
        
        private string CheckErrors()
        {
            var errorBuilder = new StringBuilder();
            
            if (string.IsNullOrWhiteSpace(TBoxName.Text))
                errorBuilder.AppendLine("Поле имя обязательно для заполнения");
            if (string.IsNullOrWhiteSpace(TBoxPatronymic.Text))
                errorBuilder.AppendLine("Поле отчество обязательно для заполнения");
            if (string.IsNullOrWhiteSpace(TBoxSurname.Text))
                errorBuilder.AppendLine("Поле фамилия обязательно для заполнения");
            if (string.IsNullOrWhiteSpace(TBoxGender.Text))
                errorBuilder.AppendLine("Поле пол обязательно для заполнения");
            
            if (TBoxPhoneNum.Text.Length > 11 || TBoxPhoneNum.Text.Length < 11)
                errorBuilder.AppendLine("Поле номер телефона не заполнено или заполнено неверно");

            if (string.IsNullOrWhiteSpace(TBoxRProp.Text))
                errorBuilder.AppendLine("Поле район прописки обязательно для заполнения");
            if (string.IsNullOrWhiteSpace(TBoxOProp.Text))
                errorBuilder.AppendLine("Поле область прописки обязательно для заполнения");
            if (string.IsNullOrWhiteSpace(TBoxGProp.Text))
                errorBuilder.AppendLine("Поле город прописки обязательно для заполнения");
            if (string.IsNullOrWhiteSpace(TBoxYProp.Text))
                errorBuilder.AppendLine("Поле улица прописки обязательно для заполнения");
            int dom = 0;
            if (int.TryParse(TBoxDProp.Text, out dom) == false || dom <= 0)
                errorBuilder.AppendLine("Поле дом прописки не заполнено или заполнено неверно");
            int noverkv = 0;
            if (int.TryParse(TBoxNKProp.Text, out noverkv) == false || noverkv <=0)
                errorBuilder.AppendLine("Поле номер квартиры не заполнено или заполнено неверно");
            if (string.IsNullOrWhiteSpace(DPDate.Text))
                errorBuilder.AppendLine("Поле дата рождения обязательно для заполнения");

            
            if (string.IsNullOrWhiteSpace(TBoxSNILS.Text))
                errorBuilder.AppendLine("Поле СНИЛС обязательно для заполнения");

            int AreaNum = 0;
            if(int.TryParse(CBoxAreaNum.Text, out AreaNum) == false || AreaNum <= 0)     
                errorBuilder.AppendLine("Поле номер участка не заполнено или заполнено неверно");
            
            if (string.IsNullOrWhiteSpace(TBoxWorkPlace.Text))
                errorBuilder.AppendLine("Поле место работы обязательно для заполнения");

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
                    if (_currentPatient == null)
                    {


                        var patient = new Entities.Пациент
                        {
                            Имя = TBoxName.Text,
                            Фамилия = TBoxSurname.Text,
                            Отчество = TBoxPatronymic.Text,
                            Пол = TBoxGender.Text,
                            Номер_телефона = TBoxPhoneNum.Text,
                            Дата_рождения = DateTime.Parse(DPDate.Text),
                            Область_прописки = TBoxOProp.Text,
                            Район_прописки = TBoxRProp.Text,
                            Город_прописки = TBoxGProp.Text,
                            Улица_прописки = TBoxYProp.Text,
                            Дом_прописки = int.Parse(TBoxDProp.Text),
                            Номер_квартиры_прописки = int.Parse(TBoxNKProp.Text),
                            Номер_участка = int.Parse(CBoxAreaNum.Text),
                            СНИЛС = TBoxSNILS.Text,
                            Место_работы = TBoxWorkPlace.Text




                        };
                        App.Context.Пациент.Add(patient);
                        App.Context.SaveChanges();
                        MessageBox.Show("Данные успешно сохранены");
                    }
                    else
                    {
                        _currentPatient.Имя = TBoxName.Text;
                        _currentPatient.Фамилия = TBoxSurname.Text;
                        _currentPatient.Отчество = TBoxPatronymic.Text;
                        _currentPatient.Пол = TBoxGender.Text;
                        _currentPatient.Номер_телефона = TBoxPhoneNum.Text;
                        _currentPatient.Дата_рождения = DateTime.Parse(DPDate.Text);
                        _currentPatient.Область_прописки = TBoxOProp.Text;
                        _currentPatient.Район_прописки = TBoxRProp.Text;
                        _currentPatient.Город_прописки = TBoxGProp.Text;
                        _currentPatient.Улица_прописки = TBoxYProp.Text;
                        _currentPatient.Дом_прописки = int.Parse(TBoxDProp.Text);
                        _currentPatient.Номер_квартиры_прописки = int.Parse(TBoxNKProp.Text);
                        _currentPatient.Номер_участка = int.Parse(CBoxAreaNum.Text);
                        _currentPatient.СНИЛС = TBoxSNILS.Text;
                        _currentPatient.Место_работы = TBoxWorkPlace.Text;
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
