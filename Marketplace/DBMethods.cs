using Marketplace.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace
{
    public class DBMethods
    {
        public static bool CheckLoginExists(string login)
        {
            try
            {
                Authorization auth = App.Connection.Authorization.First(x => x.Login == login);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static User GetUserByAuthorization(Authorization auth)
        {
            return App.Connection.User.First(x => x.idAuthorization == auth.idAuthorization);
        }

        public static Basket GetBasketByUser(User user)
        {
            return App.Connection.Basket.First(x => x.idUser == user.idUser);
        }

        public static int GetCountOfProductInStorage(Product product)
        {
            try
            {
                return App.Connection.Product_Storage.ToList().Where(x => x.idProduct == product.idProduct).Count();
            }
            catch
            {
                return 0;
            }
        }
        
        public static int GetTotalPriceOfProduct(BasketProduct product) 
        {
            try
            {
                return product.Count * App.Connection.Product.First(x => x.idProduct == product.idProduct).Cost;
            }

            catch
            {
                return 0;
            }
        }

        public static List<Product> GetAllBasketProduct(User user)
        {
            List<Product> products = new List<Product>();
            try
            {
                List<BasketProduct> basketProducts = App.Connection.BasketProduct.ToList().Where(x => x.idBasket == GetBasketByUser(user).idBasket).ToList();
                foreach (BasketProduct bProduct in basketProducts)
                {
                    Product product = App.Connection.Product.First(x => x.idProduct == bProduct.idProduct);
                    products.Add(product);
                }
                return products;
            }
            catch
            {
                return products;
            }
        }
        public static List<Product> GetAllLikes(User user)
        {
            List<Product> products = new List<Product>();
            try
            {
                List<Like> Likes = App.Connection.Like.ToList().Where(x => x.idUser == user.idUser).ToList();
                foreach (Like like in Likes)
                {
                    Product product = App.Connection.Product.First(x => x.idProduct == like.idProduct);
                    products.Add(product);
                }
                return products;
            }
            catch
            {
                return products;
            }
        }
    }
}
