using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Classes
{
    public class Purchase
    {
        public string storageAddress { get; set; }
        public string productTitle { get; set; }
        public byte[] productImage { get; set; }

        public DateTime dateDelivery { get; set; }

        public Purchase(string storageAddress, string productTitle, byte[] productImage, DateTime dateDelivery)
        {
            this.storageAddress = storageAddress;
            this.productTitle = productTitle;
            this.productImage = productImage;
            this.dateDelivery = dateDelivery;
        }
    }
}
