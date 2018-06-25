using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Order
    {
        private int productId;
        private string productName;
        private decimal productPrice;
        private int quantity;
        private decimal totalPerProduct;
        public int ProdictId { get { return productId; } }
        public string ProductName { get { return productName; } }
        public decimal ProductPrice { get { return productPrice; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public decimal TotalPerProduct { get { return totalPerProduct; } }
        public Order(int pId, string pName, decimal pPrice, int qty)
        {
            this.productId = pId;
            this.productName = pName;
            this.productPrice = pPrice;
            this.quantity = qty;
            this.totalPerProduct = pPrice * qty;
        }

        public void ChangeTotalProduct(int newQty)
        {
            totalPerProduct = ProductPrice * newQty;
            quantity = newQty;
        }

        
    }
}
