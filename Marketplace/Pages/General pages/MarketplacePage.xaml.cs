using Marketplace.DB;
using Marketplace.Pages.General_pages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
using System.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для MarketplacePage.xaml
    /// </summary>
    public partial class MarketplacePage : Page
    {
        User userInfo;
        List<Product> products;
        List<Product> productsModified;
        public MarketplacePage(User user)
        {
            InitializeComponent();
            products = DBMethods.GetProductsReadyToSell();
            productsModified = DBMethods.GetProductsReadyToSell();
            if (products.Count > 0)
            {
                ProductList.ItemsSource = products;
                ProductList.Visibility = Visibility.Visible;
                NoProductsLabel.Visibility = Visibility.Hidden;
            }
            else
            {
                ProductList.Visibility = Visibility.Hidden;
                NoProductsLabel.Visibility = Visibility.Visible;
            }
            userInfo = user;
            NameLabel.Content = user.Name;
            SurnameLabel.Content = user.Surname;
            FilterCB.ItemsSource = App.Connection.ProductCategory.ToList();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbox = MessageBox.Show("Вы уверены что хотите выйти из профиля?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mbox == MessageBoxResult.Yes)
            {
                NavigationService.Navigate(new AuthorizationPage());
            }
        }

        private void LikeBtnClick(object sender, RoutedEventArgs e)
        {
            var id = (int)((Button)sender).Tag;
            Product product = App.Connection.Product.First(x => x.idProduct == id);
            int rate = App.Connection.ProductBirthRate.First(x => x.idProductBirthRate == product.idProductBirthRate).BirthRate;
            if (DBMethods.CheckAgePass(userInfo.BirthDate, DateTime.Now, rate))
            {
                try
                {
                    Like like = new Like();
                    like.idProduct = product.idProduct;
                    like.idUser = userInfo.idUser;
                    App.Connection.Like.Add(like);
                    App.Connection.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            else
            {
                MessageBox.Show($"Вы должны достигнуть возраста {rate} лет, чтобы вы смогли добавить в понравившиеся этот товар", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            MessageBox.Show("Вы успешно добавили товар в понравившиеся", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
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

        private void BuyBtnClick(object sender, RoutedEventArgs e)
        {
            var id = (int)((Button)sender).Tag;
            Product product = App.Connection.Product.First(x => x.idProduct == id);
            int rate = App.Connection.ProductBirthRate.First(x => x.idProductBirthRate == product.idProductBirthRate).BirthRate;

            if (DBMethods.CheckAgePass(userInfo.BirthDate, DateTime.Now, rate))
            {
                try
                {
                    var window = new AddProductToBasketWindow(userInfo, product).ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            else
            {
                MessageBox.Show($"Вы должны достигнуть возраста {rate} лет, чтобы вы смогли купить этот товар", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void GoToBasketBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BasketPage(userInfo));
        }

        private void FilterCBSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FilterCB.Text != null)
            {
                try
                {
                    var id = (FilterCB.SelectedItem as ProductCategory).idProductCategory;
                    ProductList.ItemsSource = DBMethods.GetProductsReadyToSell(id);
                    //ProductList.ItemsSource = App.Connection.Product.Where(x => x.idProductCategory == id).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Товары по данной категории пока отсутствуют {ex}", "Неудачно", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
        }

        private void TextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            productsModified = products.Where(x => x.Title.ToLower().Contains(SearchTB.Text.ToLower())).ToList();
            ProductList.ItemsSource = productsModified;
        }

        private void CreateQRClick(object sender, RoutedEventArgs e)
        {
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            // Присваеваем значиения
            QRCoder.QRCodeData data = qr.CreateQrCode("https://mck-ktits.ru/?ysclid=lo8v2lyc3h750889798", QRCoder.QRCodeGenerator.ECCLevel.L);
            // переводим в Qr
            QRCoder.QRCode code = new QRCoder.QRCode(data);
            Bitmap bitmap = code.GetGraphic(100);
            /// Создание картинки
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();
                var replinishBalanceWindow = new QRWindow(bitmapimage);
                bool? result = replinishBalanceWindow.ShowDialog();
                if (result == false || result == true)
                {
                    NavigationService.Navigate(new MarketplacePage(userInfo));
                }
            }
        }
    }
}
