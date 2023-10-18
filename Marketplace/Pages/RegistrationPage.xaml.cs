﻿using Marketplace.DB;
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

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();  
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            Authorization auth = new Authorization();


            if (string.IsNullOrEmpty(PasswordPB.Password) || string.IsNullOrEmpty(LoginTB.Text) ||
                string.IsNullOrEmpty(RoleCB.Text) || string.IsNullOrEmpty(NameTB.Text) ||
                string.IsNullOrEmpty(SurnameTB.Text) || string.IsNullOrEmpty(datePicker.Text))
            {
                MessageBox.Show("Вы оставили пустые поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else {
                if (DBMethods.CheckLoginExists(LoginTB.Text))
                {
                    MessageBox.Show("Такой логин уже существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else
                {
                    try
                    {
                        auth.Password = PasswordPB.Password;
                        auth.Login = LoginTB.Text;
                        App.Connection.Authorization.Add(auth);
                        App.Connection.SaveChanges();
                        int authId = App.Connection.Authorization.First(x => x.Login == LoginTB.Text && x.Password == PasswordPB.Password).idAuthorization;
                        user.idAuthorization = authId;
                        user.Name = NameTB.Text;
                        user.Surname = SurnameTB.Text;
                        user.BirthDate = (DateTime)datePicker.SelectedDate;
                        if (RoleCB.Text == "Покупатель")
                        {
                            user.idRole = 1;
                        }
                        else
                            user.idRole = 0;
                        user.Balance = 0;
                        App.Connection.User.Add(user);
                        App.Connection.SaveChanges();
                        int idUser = App.Connection.User.First(x => x.idAuthorization == authId).idUser;
                        Basket basket = new Basket();
                        basket.idUser = idUser;
                        App.Connection.Basket.Add(basket);
                        App.Connection.SaveChanges();
                        MessageBox.Show("Вы успешно зарегистрировались", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
