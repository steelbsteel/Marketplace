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
    /// Логика взаимодействия для AdminSuppliesPage.xaml
    /// </summary>
    public partial class AdminSuppliesPage : Page
    {
        User userInfo;
        public AdminSuppliesPage(User user)
        {
            this.userInfo = user;
            InitializeComponent();
            List<Supply> list = App.Connection.Supply.Where(x => x.Date.Day == DateTime.Today.Day && x.Accepted == null).ToList();
            SuppliesLV.ItemsSource = list;

            if (list.Count > 0)
            {
                NoTodaysSuppliesLabel.Visibility = Visibility.Hidden;
            }

            else
            {
                SuppliesLV.Visibility = Visibility.Hidden;
                TodaysSuppliesLabel.Visibility =Visibility.Hidden;
            }
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminMainPage(userInfo));
        }

        private void AcceptSupplyButton(object sender, RoutedEventArgs e)
        {
            var id = (int)((Button)sender).Tag;
            Supply supply = App.Connection.Supply.First(x => x.idSupply == id);
            Product_Storage productStorage = new Product_Storage();
            productStorage.idProduct = supply.idProduct;
            productStorage.idStorage = supply.idStorage;
            productStorage.CountOfProducts = supply.CountOfProducts;
            App.Connection.Product_Storage.Add(productStorage);
            App.Connection.SaveChanges();
            supply.Accepted = true;
            App.Connection.Supply.AddOrUpdate(supply);
            App.Connection.SaveChanges();
            MessageBox.Show("Вы успешно приняли поставку", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new AdminSuppliesPage(userInfo));
        }

        private void RejectBtnClick(object sender, RoutedEventArgs e)
        {
            var id = (int)((Button)sender).Tag;
            Supply supply = App.Connection.Supply.First(x => x.idSupply == id);
            supply.Accepted = false;
            App.Connection.Supply.AddOrUpdate(supply);
            App.Connection.SaveChanges();
            MessageBox.Show("Вы успешно отклонили поставку", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new AdminSuppliesPage(userInfo));
        }
    }
}
