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
    /// Логика взаимодействия для RequestsSellerPage.xaml
    /// </summary>
    public partial class RequestsSellerPage : Page
    {
        User userInfo;
        public RequestsSellerPage(User user)
        {
            userInfo = user;
            InitializeComponent();
            List<ProductAddRequest> list = App.Connection.ProductAddRequest.ToList().Where(x => x.idUser == userInfo.idUser).ToList();
            if (list.Count == 0 || list == null)
            {
                Requests.Visibility = Visibility.Hidden;
                NoOneRequestsLabel.Visibility = Visibility.Visible;

            }
            else
            {
                Requests.ItemsSource = list;
                Requests.Visibility = Visibility.Visible;
                NoOneRequestsLabel.Visibility = Visibility.Hidden;
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
        private void MarketplaceBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MarketplacePage(userInfo));

        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void GoToLikesBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LikesPage(userInfo));
        }

        private void GoToBasketBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BasketPage(userInfo));
        }
        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = userInfo;
        }
    }
}
