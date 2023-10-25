using Marketplace.DB;
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

namespace Marketplace.Pages.Seller_pages
{
    /// <summary>
    /// Логика взаимодействия для MakeSupplyPage.xaml
    /// </summary>
    public partial class MakeSupplyPage : Page
    {
        User userInfo;
        public MakeSupplyPage(User user)
        {
            userInfo = user;
            InitializeComponent();
            ProductCB.ItemsSource = App.Connection.Product.ToList();
            //ProductCB.ItemsSource = DBMethods.GetProductsReadyToSupply(userInfo.idUser);
            StoragesCB.ItemsSource = App.Connection.Storage.ToList();
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
        private void MarketplaceBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MarketplacePage(userInfo));

        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = userInfo;
        }

        private void GoToBasketBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BasketPage(userInfo));
        }

        private void MakeSupplyBtnClick(object sender, RoutedEventArgs e)
        {
            DateTime correctDate = DateTime.UtcNow.AddDays(7);

            if (string.IsNullOrEmpty(CountTB.Text) || Convert.ToInt32(CountTB.Text) <= 0)
            {
                MessageBox.Show("Введите корректно количество поставляемого товара", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (datePicker.SelectedDate == null)
            {
                MessageBox.Show("Выберите дату", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (datePicker.SelectedDate < DateTime.Now)
            {
                MessageBox.Show($"Ошибка выбора даты поставки. Выберите поставку не ранее чем {correctDate.Date} ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (datePicker.SelectedDate > correctDate)
            {
                MessageBox.Show($"Дата поставки не может превышать 7 дней с настоящего момента. Выберите поставку не позднее чем {correctDate.Date} ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (ProductCB.SelectedItem == null)
            {
                MessageBox.Show("Выберите продукт", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            if (StoragesCB.SelectedItem == null)
            {
                MessageBox.Show("Выберите склад", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                Supply supply = new Supply();
                supply.Accepted = false;
                supply.Date = (DateTime)datePicker.SelectedDate;
                supply.idUser = userInfo.idUser;
                supply.idStorage = (StoragesCB.SelectedItem as Storage).idStorage;

                Product product = ProductCB.SelectedItem as Product;
                App.Connection.Supply.Add(supply);
                App.Connection.SaveChanges();
                
                for (int i = 0; i < Convert.ToInt32(CountTB.Text); i++)
                {
                    Supply_Product supply_Product = new Supply_Product();
                    supply_Product.idProduct = product.idProduct;
                    supply_Product.idSupply = supply.idSupply;
                    App.Connection.Supply_Product.Add(supply_Product);
                    App.Connection.SaveChanges();
                }
                MessageBox.Show("Вы успешно запланировали поставку", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
