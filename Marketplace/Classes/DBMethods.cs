﻿using Marketplace.DB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

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

        public static void SellProduct(Product product, int sallary)
        {
            User seller = App.Connection.User.First(x => x.idUser == product.idUser);

        }
        public static byte[] getBytesFromImage(BitmapImage imageC)
        {
            MemoryStream memStream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);
            return memStream.ToArray();
        }
        
        public static List<Product> GetProductsReadyToSell()
        {
            List<Product> list = new List<Product>();
            List<Product_Storage> productsInStorage = App.Connection.Product_Storage.Distinct().ToList();
            foreach(Product_Storage product in productsInStorage) 
            {
                list.Add(App.Connection.Product.First(x => x.idProduct == product.idProduct));
            }
            return list;
        }

        public static List<Product> GetProductsReadyToSupply(int idSeller)
        {
            List<Product> list = App.Connection.Product.ToList().Where(x => x.idUser == idSeller && x.onSell == true).ToList();
            return list;
        }
        private static BitmapImage ByteToImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
        public static List<ProductSell> GetSells(int idSeller)
        {
            List<Product> sellersProducts = App.Connection.Product.ToList().Where(x => x.idUser == idSeller).ToList();
            List<Sell> sells = App.Connection.Sell.ToList();
            List<ProductSell> productsSelled = new List<ProductSell>();
            
            foreach(Sell sell in sells)
            {
                 foreach (Product product in sellersProducts) 
                 {
                    if (sell.idProduct != product.idProduct)
                    {
                        sells.Remove(sell);
                    }
                 }
            }

            foreach (Sell sell in sells)
            {
                Product product = App.Connection.Product.First(x => x.idProduct == sell.idProduct);
                ProductSell productSell = new ProductSell(product.Title, sell.Date, sell.Sallary.ToString(), ByteToImage(product.Image));
                productsSelled.Add(productSell);
            }

            return productsSelled;
        }

        public static bool CheckAgePass(DateTime birthDate, DateTime now, int rate)
        {
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            if (age > rate)
                return true;
            else
                return false;
        }

        public static List<Supply_Product> GetAllSupplies()
        {

        }
    }
}
