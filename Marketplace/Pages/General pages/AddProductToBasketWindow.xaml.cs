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
using System.Windows.Shapes;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProductToBasketWindow.xaml
    /// </summary>
    public partial class AddProductToBasketWindow : Window
    {
        User userInfo;
        Product productInfo;
        Product_Storage productInStorage;
        public AddProductToBasketWindow(User user, Product product)
        {
            userInfo = user;
            productInfo = product;
            InitializeComponent();
            productInStorage = App.Connection.Product_Storage.First(x => x.idProduct == product.idProduct);
            CountOfProductInStorage.Content = productInStorage.CountOfProducts;
        }

        private void CountTBTextChanged(object sender, TextChangedEventArgs e)
        {
            int count = Convert.ToInt32(CountTB.Text);
            int number = 0;
            if (int.TryParse(CountTB.Text, out number))
            {
                ProductCost.Content = (productInfo.Cost * count).ToString();
            }
            else
            {
                CountTB.Text = "";
                MessageBox.Show("Введите целое значение поля количества.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BackBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddProductToBasketBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CountTB.Text))
            {
                MessageBox.Show("Поле количества не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (Convert.ToInt32(CountTB.Text) > productInStorage.CountOfProducts)
            {
                MessageBox.Show("Вы выбрали количество товара больше, чем хранится на складе", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                BasketProduct bProduct = new BasketProduct();
                bProduct.idProduct = productInfo.idProduct;
                bProduct.idBasket = DBMethods.GetBasketByUser(userInfo).idBasket;
                bProduct.Count = Convert.ToInt32(CountTB.Text);
                App.Connection.BasketProduct.Add(bProduct);
                App.Connection.SaveChanges();
                MessageBox.Show("Продукт успешно добавлен в корзину", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = productInfo;
        }
    }
}
