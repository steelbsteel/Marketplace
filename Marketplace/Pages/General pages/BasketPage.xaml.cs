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
            //List<BasketProduct> products = DBMethods.GetAllBasketProduct(user);
            List<BasketProduct> products = App.Connection.BasketProduct.ToList().Where(x => x.idBasket == App.Connection.Basket.First(y => y.idUser == userInfo.idUser).idBasket).ToList();
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
            BasketProduct bProduct = App.Connection.BasketProduct.First(x => x.idBasketProduct == id);
            MessageBoxResult mbox = MessageBox.Show("Вы уверены что хотите удалить товар из корзины?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (mbox == MessageBoxResult.Yes)
            {
                App.Connection.BasketProduct.Remove(bProduct);
                App.Connection.SaveChanges();
                MessageBox.Show("Товар успешно удален из корзины", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new MarketplacePage(userInfo));
            }
        }

        private void BuyProductClick(object sender, RoutedEventArgs e)
        {

            var id = (int)((Button)sender).Tag;
            BasketProduct bProduct = App.Connection.BasketProduct.First(x => x.idBasketProduct == id);
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

                if (bProduct.Count < DBMethods.GetCountOfProductInStorage(App.Connection.Product.FirstOrDefault(x => x.idProduct == bProduct.idProduct)))
                {
                    MessageBox.Show("Товара недостаточно на складе. Удалите его из корзины и попробуйте добавить снова когда он появится в разделах маркетплейса.", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                userInfo.Balance -= totalPrice;
                App.Connection.User.AddOrUpdate(userInfo);
                App.Connection.BasketProduct.Remove(bProduct);
                Sell sell = new Sell();
                sell.idProduct = bProduct.idProduct;
                sell.Sallary = bProduct.Count * App.Connection.Product.FirstOrDefault(x => x.idProduct == bProduct.idProduct).Cost;
                sell.Date = DateTime.Now.Date;
                sell.DateDelivery = DateTime.UtcNow.AddDays(2);
                Product_Storage product_Storage = App.Connection.Product_Storage.First(x => x.idProduct == App.Connection.Product.FirstOrDefault(y => y.idProduct == bProduct.idProduct).idProduct);
                product_Storage.CountOfProducts -= bProduct.Count;
                App.Connection.Product_Storage.AddOrUpdate(product_Storage);
                sell.idUser = userInfo.idUser;
                App.Connection.Sell.Add(sell);
                User seller = App.Connection.User.FirstOrDefault(x => x.idUser == App.Connection.Product.FirstOrDefault(y => y.idProduct == bProduct.idProduct).idUser);
                seller.Balance +=  bProduct.Count * App.Connection.Product.FirstOrDefault(x => x.idProduct == bProduct.idProduct).Cost;
                App.Connection.User.AddOrUpdate(seller);
                App.Connection.SaveChanges();
                MessageBox.Show("Вы успешно купили товар", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new MarketplacePage(userInfo));
            }
        }


        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = userInfo;
        }
    }
}
