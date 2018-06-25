using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoanStand
{
    class Customer
    {
        
        
        private int customerID;
        private decimal customerBalance;
        public int CustomerId { get { return customerID; } }
        public decimal CustomerBalance { get { return customerBalance; } }
        

        public Customer(int id, decimal balance)
        {
            customerID = id;
            customerBalance = balance;
            
        }
        public decimal GetNewBalance(decimal total)
        {
            return customerBalance -= total;
        }

    }
}
