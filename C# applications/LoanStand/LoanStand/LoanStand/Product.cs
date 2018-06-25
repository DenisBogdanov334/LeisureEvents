using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanStand
{
    class Product
    {
        private int loanstandid;
        private int id;
        private string name;
        private decimal priceperday;
        public int ID { get { return id; } }
        public string Name { get { return name; } }
        public decimal PricePerDay { get { return priceperday; } }
        public int LoanStandID { get { return loanstandid; } }
        public Product(int id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.priceperday = price;
        }
    }
}
