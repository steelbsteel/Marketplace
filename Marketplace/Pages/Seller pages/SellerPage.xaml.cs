using Marketplace.DB;
using Marketplace.Pages.Seller_pages;
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
    /// Логика взаимодействия для SellerPage.xaml
    /// </summary>
    public partial class SellerPage : Page
    {
        User userInfo;
        public SellerPage(User user)
        {
            userInfo = user;
            InitializeComponent();
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = userInfo;
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ReplinishBalanceBtnClick(object sender, RoutedEventArgs e)
        {
            var replinishBalanceWindow = new ReplinishBalanceWindow(userInfo);
            bool? result = replinishBalanceWindow.ShowDialog();
            if (result == false || result == true)
            {
                NavigationService.Navigate(new MarketplacePage(userInfo));
            }

        }

        private void GoToLikesBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LikesPage(userInfo));
        }

        private void GoToBasketBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BasketPage(userInfo));
        }

        private void MarketplaceBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MarketplacePage(userInfo));
        }

        private void CreateNewProductBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateNewProductPage(userInfo));
        }

        private void SellsBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SellsPage(userInfo));
        }

        private void MakeSupplyPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MakeSupplyPage(userInfo));
        }

        private void ListOfSuppliesBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SuppliesListPage(userInfo)); 
        }

        private void GoToRequestsPageBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RequestsSellerPage(userInfo));
        }
    }
}
