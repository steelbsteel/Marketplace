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
using System.Windows.Shapes;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для ReplinishBalanceWindow.xaml
    /// </summary>
    public partial class ReplinishBalanceWindow : Window
    {
        User userInfo;
        public ReplinishBalanceWindow(User user)
        {
            userInfo = user;
            InitializeComponent();
        }

        private void GoBackBtnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ReplinishBtnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SumTB.Text) || Convert.ToInt32(SumTB.Text) <= 0)
            {
                MessageBox.Show("Исправьте значения поля суммы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                userInfo.Balance +=  Convert.ToInt32(SumTB.Text);
                App.Connection.User.AddOrUpdate(userInfo);
                App.Connection.SaveChanges();
                MessageBox.Show("Баланс успешно пополнен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка пополнения баланса", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
