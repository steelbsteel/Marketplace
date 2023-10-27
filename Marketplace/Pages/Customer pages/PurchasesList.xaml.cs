using Marketplace.Classes;
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

namespace Marketplace.Pages.Customer_pages
{
    /// <summary>
    /// Логика взаимодействия для PurchasesList.xaml
    /// </summary>
    public partial class PurchasesList : Page
    {
        User userInfo;
        public PurchasesList(User user)
        {
            userInfo = user;
            InitializeComponent();
            List<Sell> userPurchases = App.Connection.Sell.Where(x => x.idUser == userInfo.idUser).ToList();
            List<Purchase> purchasesList = new List<Purchase>();
            foreach (Sell sell in userPurchases) 
            {
                Product prod = App.Connection.Product.FirstOrDefault(x => x.idProduct == sell.idProduct);
                Storage storage = App.Connection.Storage.FirstOrDefault(x => x.idStorage == App.Connection.Product_Storage.FirstOrDefault(y => y.idProduct == prod.idProduct).idStorage);
                DateTime date = sell.DateDelivery.Date;
                Purchase purchase = new Purchase(storage.Address, prod.Title, prod.Image, date);
               
                purchasesList.Add(purchase);
            }
            if (purchasesList.Count > 0)
            {
                NoPurchases.Visibility = Visibility.Hidden;
                Purchases.ItemsSource = purchasesList;
            }
            else
            {
                Purchases.Visibility = Visibility.Hidden;
            }
           
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = userInfo;
        }

        private void MarketplaceBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MarketplacePage(userInfo));
        }

        private void BackBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
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
    }
}
