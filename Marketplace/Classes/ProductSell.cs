using Marketplace.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Marketplace
{
    public class ProductSell
    {
        public ProductSell(string _tile, DateTime _date, string _sallary, BitmapImage _image)
        {
            this.Title = _tile;
            this.Date = _date;
            this.Sallary = _sallary;
            this.image = _image;
        }

        public string Title { get; set; }
        public DateTime Date { get; set; }
        
        public string Sallary { get; set; }

        public BitmapImage image { get; set; }
    }
}
