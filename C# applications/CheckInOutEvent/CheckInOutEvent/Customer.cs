using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInOutEvent
{
    class Customer
    {
        string rfidNr; 
        int customerId;
        string firstName, lastName;
        int checkedStatusEvent;
        int loanedProduct;
        
        public int Id { get { return customerId; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public int CheckedStatusEvent { get { return checkedStatusEvent; } }
        public int LoanedProductStatus { get { return loanedProduct; } }
        public Customer(string rfidNr, int id, string firstName, string lastName,
                         int checkedStatusEvent, int loanedProduct)
        {
            this.rfidNr = rfidNr;
            this.customerId = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.checkedStatusEvent = checkedStatusEvent;
            this.loanedProduct = loanedProduct;
        }

        
    }
}
