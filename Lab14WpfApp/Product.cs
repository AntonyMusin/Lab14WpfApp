using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14WpfApp
{
    public enum ProductTypes
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductCost { get; set; }
        public string ProductImage { get; set; }
        public ProductTypes ProductType { get; set; }
    }
}
