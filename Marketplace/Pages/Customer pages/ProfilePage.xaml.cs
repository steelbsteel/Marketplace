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

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        User userInfo;
        public ProfilePage(User user)
        {
            userInfo = user;
            InitializeComponent();
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = userInfo;
        }

        private void BackBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ReplinishBalanceBtnClick(object sender, RoutedEventArgs e)
        {
            var replinishBalanceWindow = new ReplinishBalanceWindow(userInfo);
            bool? result = replinishBalanceWindow.ShowDialog();
            if (result == false || result == true)
            {
                NavigationService.Navigate(new ProfilePage(userInfo));
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

        private void MarketplaceBtnClick_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MarketplacePage(userInfo));
        }
    }
}
