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
    /// Логика взаимодействия для MarketplacePage.xaml
    /// </summary>
    public partial class MarketplacePage : Page
    {
        public MarketplacePage(User user)
        {
            InitializeComponent();
            NameLabel.Content = user.Name;
            SurnameLabel.Content = user.Surname;
            BalanceLabel.Content = $"{user.Balance.ToString()} руб";
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbox = MessageBox.Show("Вы уверены что хотите выйти из профиля?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mbox == MessageBoxResult.Yes)
            {
                NavigationService.Navigate(new AuthorizationPage());
            }
        } 
    }
}
