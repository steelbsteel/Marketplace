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

namespace Marketplace.Pages.Admin_pages
{
    /// <summary>
    /// Логика взаимодействия для AdminRequestsWindow.xaml
    /// </summary>
    public partial class AdminRequestsWindow : Page
    {
        User userInfo;
        public AdminRequestsWindow(User user)
        {
            userInfo = user;
            InitializeComponent();
            Requests.ItemsSource = App.Connection.ProductAddRequest.ToList().Where(x => x.idProductAddRequestStatus == 1).ToList();
        }

        private void ButtonAcceptClick(object sender, RoutedEventArgs e)
        {
            var id = (int)((Button)sender).Tag;
            ProductAddRequest productReq = App.Connection.ProductAddRequest.First(x => x.idProduct == id);
            Product product = App.Connection.Product.First(x => x.idProduct == productReq.idProduct);
            product.onSell = true;
            productReq.idProductAddRequestStatus = 2;
            App.Connection.ProductAddRequest.AddOrUpdate(productReq);
            App.Connection.SaveChanges();
            App.Connection.Product.AddOrUpdate(product);
            App.Connection.SaveChanges();
            MessageBox.Show("Вы успешно приняли заявку на добавление товара", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new AdminRequestsWindow(userInfo));
        }

        private void RejectBtnClick(object sender, RoutedEventArgs e)
        {
            var id = (int)((Button)sender).Tag;
            ProductAddRequest product = App.Connection.ProductAddRequest.First(x => x.idProduct == id);
            product.idProductAddRequestStatus = 3;
            App.Connection.ProductAddRequest.AddOrUpdate(product);
            App.Connection.SaveChanges();
            MessageBox.Show("Вы успешно отклонили заявку на добавление товара", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new AdminRequestsWindow(userInfo));
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminMainPage(userInfo));
        }
    }
}
