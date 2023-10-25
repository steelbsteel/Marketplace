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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для LikesPage.xaml
    /// </summary>
    public partial class LikesPage : Page
    {
        User userInfo;
        public LikesPage(User user)
        {

            List<Product> products = DBMethods.GetAllBasketProduct(user);
            if (products.Count > 0)
            {
                ProductList.ItemsSource = products;
            }

            userInfo = user;
            InitializeComponent();
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

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void AddProductToBasketBtnClick(object sender, RoutedEventArgs e)
        {
            Product product;
            if (ProductList.SelectedItem != null)
            {
                try
                {
                    product = ProductList.SelectedItem as Product;
                    var window = new AddProductToBasketWindow(userInfo, product).ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = userInfo;
        }
    }
}
