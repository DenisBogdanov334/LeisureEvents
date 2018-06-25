using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignRfid
{
    class Customer
    {
        private int id;
        private string firstName, lastName, address;
        private string rfid;

        public int Id { get { return id; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string Address { get { return address; } }
        public string Rfid { get { return rfid; } }

        public Customer(int id, string fName, string lName, string address)
        {
            this.id = id;
            this.firstName = fName;
            this.lastName = lName;
            this.address = address;
            this.rfid = null;
        }
        public void AssignRfid(string rfidNr)
        {
            this.rfid = rfidNr;
        }
    }
}
