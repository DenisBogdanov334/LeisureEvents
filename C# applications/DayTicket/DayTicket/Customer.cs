using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTicket
{
    class Customer
    {
        private string firstName, lastName, email, phoneNr; 
        private int id;
        public int Id { get { return id; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string Email { get { return email; } }
        public string PhoneNr { get { return phoneNr; } }
        
        
        public Customer(string firstName, string lastName, string email, string phoneNr)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNr = phoneNr;
        }

        public Customer(int id, string fName, string lName)
        {
            this.id = id;
            this.firstName = fName;
            this.lastName = lName;
        }
    }
}
