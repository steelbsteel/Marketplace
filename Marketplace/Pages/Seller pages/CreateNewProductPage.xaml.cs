using Marketplace.DB;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
    /// Логика взаимодействия для CreateNewProductPage.xaml
    /// </summary>
    public partial class CreateNewProductPage : Page
    {
        Product product;
        User userInfo;
        public CreateNewProductPage(User user)
        {
            userInfo = user;
            product = new Product();
            InitializeComponent();
            CategoryCB.ItemsSource = App.Connection.ProductCategory.ToList();
            AgeCategoryCB.ItemsSource = App.Connection.ProductBirthRate.ToList();
        }

        private void AddImageBtnClick(object sender, RoutedEventArgs e)
        {
            var window = new OpenFileDialog();

            if (window.ShowDialog() != true)
            {
                MessageBox.Show("Изображение не выбрано");
                return;
            }

            ProductImage.Source = new BitmapImage(new Uri(window.FileName));
            product.Image = File.ReadAllBytes(window.FileName);
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void GoToBasketBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BasketPage(userInfo));
        }

        private void MarketplaceBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MarketplacePage(userInfo));
        }

        private void AddRequestBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CostTB.Text) || string.IsNullOrEmpty(DescriptionTB.Text) || string.IsNullOrEmpty(TitleTB.Text) ||
                string.IsNullOrEmpty(CategoryCB.SelectedItem.ToString()) || string.IsNullOrEmpty(AgeCategoryCB.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (ProductImage.Source == null)
            {
                MessageBox.Show("Выберете фотографию для товара", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            product.Description = DescriptionTB.Text;
            product.Title = TitleTB.Text;
            product.idProductCategory = (CategoryCB.SelectedItem as ProductCategory).idProductCategory;
            product.idProductBirthRate = (AgeCategoryCB.SelectedItem as ProductBirthRate).idProductBirthRate;
            product.Cost = Convert.ToInt32(CostTB.Text);
            product.Image = DBMethods.getBytesFromImage(ProductImage.Source as BitmapImage);
            product.idUser = userInfo.idUser;
            product.onSell = false;
            App.Connection.Product.Add(product);
            App.Connection.SaveChanges();
            ProductAddRequest request = new ProductAddRequest();
            request.idProduct = product.idProduct;
            request.idProductAddRequestStatus = 1;
            request.idUser = userInfo.idUser;
            App.Connection.ProductAddRequest.Add(request);
            App.Connection.SaveChanges();
            MessageBox.Show("Вы успешно создали заявку на добавление продукта на маркетплейс. Она находится в состоянии обработки. После принятия заявки, вы сможете сделать поставку и ваш товар появится у пользователей.",
                            "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new SellerPage(userInfo));
        }
    }
}
