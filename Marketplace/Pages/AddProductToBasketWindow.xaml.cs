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
using System.Windows.Shapes;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProductToBasketWindow.xaml
    /// </summary>
    public partial class AddProductToBasketWindow : Window
    {
        User userInfo;
        Product productInfo;
        public AddProductToBasketWindow(User user, Product product)
        {
            InitializeComponent();
        }

        private void CountTBTextChanged(object sender, TextChangedEventArgs e)
        {
            int count = Convert.ToInt32(CountTB.Text);
            int number = 0;
            if (int.TryParse(CountTB.Text, out number))
            {
                ProductCost.Content = (productInfo.Cost * count).ToString();
            }
            else
            {
                MessageBox.Show("Введите целое значение поля количества.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BackBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddProductToBasketBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BasketProduct bProduct = new BasketProduct();
                bProduct.idProduct = productInfo.idProduct;
                bProduct.idBasket = DBMethods.GetBasketByUser(userInfo).idBasket;
                bProduct.Count = Convert.ToInt32(CountTB.Text);
                App.Connection.BasketProduct.Add(bProduct);
                App.Connection.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
