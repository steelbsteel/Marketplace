using Marketplace.DB;
using Marketplace.Pages.Admin_pages;
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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            Authorization auth = new Authorization();
            try
            {
                auth = App.Connection.Authorization.First(x => x.Login == LoginTB.Text && x.Password == PasswordTB.Password);
                User user = DBMethods.GetUserByAuthorization(auth);
                if(user.idRole == 3)
                {
                    NavigationService.Navigate(new AdminMainPage(user));
                }
                else
                {
                    NavigationService.Navigate(new MarketplacePage(user));
                }
            }
            catch 
            {
                MessageBox.Show("Неверно введены данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
