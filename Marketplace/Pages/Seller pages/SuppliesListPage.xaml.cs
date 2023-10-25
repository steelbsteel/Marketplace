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
    /// Логика взаимодействия для SuppliesListPage.xaml
    /// </summary>
    public partial class SuppliesListPage : Page
    {
        User userInfo;
        public SuppliesListPage(User user)
        {
            userInfo = user;
            InitializeComponent();
            SuppliesLV.ItemsSource = App.Connection.Supply.ToList().Where(x => x.idUser == user.idUser).ToList();
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
        private void GoToLikesBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LikesPage(userInfo));
        }

        private void GoToBasketBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BasketPage(userInfo));
        }
    }
}
