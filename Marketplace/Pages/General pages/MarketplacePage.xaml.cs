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
    /// Логика взаимодействия для MarketplacePage.xaml
    /// </summary>
    public partial class MarketplacePage : Page
    {
        User userInfo;
        public MarketplacePage(User user)
        {
            InitializeComponent();
            ProductList.ItemsSource = DBMethods.GetProductsReadyToSell();
            userInfo = user;
            NameLabel.Content = user.Name;
            SurnameLabel.Content = user.Surname;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbox = MessageBox.Show("Вы уверены что хотите выйти из профиля?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mbox == MessageBoxResult.Yes)
            {
                NavigationService.Navigate(new AuthorizationPage());
            }
        }

        private void LikeBtn_Click(object sender, RoutedEventArgs e)
        {
            var id = (int)((Button)sender).Tag;
            Product product = App.Connection.Product.First(x => x.idProduct == id);
            int rate = App.Connection.ProductBirthRate.First(x => x.idProductBirthRate == product.idProductBirthRate).BirthRate;
            if (DBMethods.CheckAgePass(userInfo.BirthDate, DateTime.Now, rate))
            {
                try
                {
                    Like like = new Like();
                    like.idProduct = product.idProduct;
                    like.idUser = userInfo.idUser;
                    App.Connection.Like.Add(like);
                    App.Connection.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            else
            {
                MessageBox.Show($"Вы должны достигнуть возраста {rate} лет, чтобы вы смогли добавить в понравившиеся этот товар", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }     
        }

        private void NameMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (userInfo.idRole == 1)
            {
                NavigationService.Navigate(new ProfilePage(userInfo));
            }
            if (userInfo.idRole == 2)
            {
                NavigationService.Navigate(new SellerPage(userInfo));
            }
        }

        private void BuyBtnClick(object sender, RoutedEventArgs e)
        {
            var id = (int)((Button)sender).Tag;
            Product product = App.Connection.Product.First(x => x.idProduct == id);
            int rate = App.Connection.ProductBirthRate.First(x => x.idProductBirthRate == product.idProductBirthRate).BirthRate;

            if (DBMethods.CheckAgePass(userInfo.BirthDate, DateTime.Now, rate))
            {
                try
                {
                    var window = new AddProductToBasketWindow(userInfo, product).ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            else
            {
                MessageBox.Show($"Вы должны достигнуть возраста {rate} лет, чтобы вы смогли купить этот товар", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void GoToBasketBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BasketPage(userInfo));
        }
    }
}