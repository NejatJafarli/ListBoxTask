using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    public class Product
    {
        public Product(string productName, string productOriginCountry, int productCost)
        {
            ProductName = productName;
            ProductOriginCountry = productOriginCountry;
            ProductCost = productCost;
        }

        public string ProductName { get; set; }
        public string ProductOriginCountry { get; set; }
        public int ProductCost { get; set; }
        public override string ToString()
        {
            return $"Name:{ProductName} Country:{ProductOriginCountry} Cost:{ProductCost}";
        }
    }
}
