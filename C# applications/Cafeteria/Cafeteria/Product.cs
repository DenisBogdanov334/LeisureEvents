using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Product
    {
        int productID;
        string productName;
        string productCategory;
        decimal productPrice;
        public int ProductID { get { return productID; } }
        public string ProductName { get { return productName; } }
        public string ProductCategory { get { return productCategory; } }
        public decimal ProductPrice { get { return productPrice; } }
        

        public Product(int id, string name, string category, decimal price)
        {
            this.productID = id;
            this.productName = name;
            this.productCategory = category;
            this.productPrice = price;
        }
        
        
    }
}
