using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInOutCamping
{
    class Customer
    {
        int customerId;
        string firstName, lastName;
        int checkedStatusCamp;
        string spotId;
        bool reservation;

        public int Id { get { return customerId; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public int CheckedStatusCamp { get { return checkedStatusCamp; } }
        public string SpotId { get { return spotId; } }
        public bool Reservation { get { return reservation; } }

        public Customer(int id, string firstName, string lastName,
                         int checkedStatusCamp, string spotId, bool reservation)
        {
            this.customerId = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.checkedStatusCamp = checkedStatusCamp;
            this.spotId = spotId;
            this.reservation = reservation;
        }
    }
}
