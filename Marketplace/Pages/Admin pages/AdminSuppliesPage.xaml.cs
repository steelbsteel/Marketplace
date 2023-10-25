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
            List<Supply> supplies = App.Connection.Supply.ToList().Where(x => x.Date == DateTime.Today).ToList();
            List<Supply_Product> list = new List<Supply_Product>();
            foreach (Supply supply in supplies)
            {
                List<Supply_Product> products = App.Connection.Supply_Product.ToList().Where(x => x.idSupply == supply.idSupply).ToList();
            }
            

            list = App.Connection.Supply_Product.Distinct().ToList();

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

        }
    }
}
