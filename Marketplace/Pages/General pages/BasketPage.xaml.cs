using Marketplace.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для BasketPage.xaml
    /// </summary>
    public partial class BasketPage : Page
    {
        User userInfo;
        public BasketPage(User user)
        {
            userInfo = user;
            InitializeComponent();
            List<Product> products = DBMethods.GetAllBasketProduct(user);
            if (products.Count > 0)
            {
                NoProductsInBasketLabel.Visibility = Visibility.Hidden;
                ProductList.ItemsSource = products;
            }
            else
            {
                ProductList.Visibility = Visibility.Hidden;
                NoProductsInBasketLabel.Visibility = Visibility.Visible;

            }
        }
            private void NameLabelMouseDown(object sender, MouseButtonEventArgs e)
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

        private void BackBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void DeleteProductFromBasketBtnClick(object sender, RoutedEventArgs e)
        {
            var id = (int)((Button)sender).Tag;
            BasketProduct bProduct = App.Connection.BasketProduct.First(x => x.idProduct == id);
            MessageBoxResult mbox = MessageBox.Show("Вы уверены что хотите удалить товар из корзины?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (mbox == MessageBoxResult.Yes)
            {
                App.Connection.BasketProduct.Remove(bProduct);
                App.Connection.SaveChanges();
                MessageBox.Show("Товар успешно удален из корзины", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new BasketPage(userInfo));
            }
        }

        private void BuyProductClick(object sender, RoutedEventArgs e)
        {

            var id = (int)((Button)sender).Tag;
            Product product = App.Connection.Product.First(x => x.idProduct == id);
            BasketProduct bProduct = App.Connection.BasketProduct.First(x => x.idProduct == id);
            int totalPrice = DBMethods.GetTotalPriceOfProduct(bProduct);
            MessageBoxResult mbox = MessageBox.Show($"Вы уверены что хотите купить данный товар? Итоговая цена составит: {totalPrice}", 
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (mbox == MessageBoxResult.Yes)
            {
                if (userInfo.Balance < totalPrice)
                {
                    MessageBox.Show("Недостаточно средств на балансе", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (bProduct.Count < DBMethods.GetCountOfProductInStorage(product))
                {
                    MessageBox.Show("Товара недостаточно на складе. Удалите его из корзины и попробуйте добавить снова когда он появится в разделах маркетплейса.", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                userInfo.Balance -= totalPrice;
                App.Connection.User.AddOrUpdate(userInfo);
                App.Connection.BasketProduct.Remove(bProduct);
                App.Connection.Product_Storage.Remove(App.Connection.Product_Storage.First(x => x.idProduct == product.idProduct));
                App.Connection.SaveChanges();
                MessageBox.Show("Вы успешно купили товар", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new BasketPage(userInfo));
            }
        }


        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = userInfo;
        }
    }
}
