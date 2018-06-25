using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanStand
{
    class Loan
    {
        private int id;
        private string name;
        private decimal priceperday;
        private int qty;
        private int days;
        private decimal total;
        private decimal totalPerProduct;
        public int ID { get { return id; } }
        public string Name { get { return name; } }
        public decimal PricePerDay { get { return priceperday; } }
        public int Qty { get { return qty; } set { qty = value; } }
        public int Days { get { return days; } set { days = value; } }
        public decimal TotalPerProduct { get { return totalPerProduct; } }
        
        //public decimal Totalperproduct()
        //{
        //    return qty * priceperday * days;
        //}

        //public decimal Total()
        //{
        //    total += totalPerProduct;
        //    return total;
        //}

        public Loan(int id, string name, decimal priceperday, int qty, int days)
        {
            this.id = id;
            this.name = name;
            this.priceperday = priceperday;
            this.qty = qty;
            this.days = days;
            this.totalPerProduct = qty * priceperday * days;
            
        }
        public string String()
        {
            return id + " " + name + ", Price: " + priceperday + ", Qty: " + qty + ", Price: " + totalPerProduct;
        }

        public void ChangeTotalProduct(int newqty, int newdays)
        {
            totalPerProduct = PricePerDay * newqty * newdays;
            qty = newqty;
            days = newdays;
        }
    }
}
