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
            userInfo = user;
            InitializeComponent();
            List<Like> likes = DBMethods.GetAllLikes(user);
            if (likes.Count > 0)
            {
                ProductList.ItemsSource = likes;
                NoProductsInLikesLabel.Visibility = Visibility.Hidden;
            }
            else
            {
                ProductList.Visibility = Visibility.Hidden;
                NoProductsInLikesLabel.Visibility = Visibility.Visible;
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

        private void DeleteProductFromBasketBtnClick(object sender, RoutedEventArgs e)
        {
            var id = (int)((Button)sender).Tag;
            Like like = App.Connection.Like.First(x => x.idLike == id);
            MessageBoxResult mbox = MessageBox.Show("Вы уверены что хотите удалить товар из понравившихся?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (mbox == MessageBoxResult.Yes)
            {
                App.Connection.Like.Remove(like);
                App.Connection.SaveChanges();
                MessageBox.Show("Товар успешно удален из понравившихся", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new MarketplacePage(userInfo));
            }
        }
    }
}
