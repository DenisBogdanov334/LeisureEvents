using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    class Customer
    {
        private int customerId;
        private int status;
        private DateTime timeChecking;

        public int CustomerId { get { return customerId; } }
        public int Status { get { return status; } }

        public Customer(int id, int status)
        {
            this.customerId = id;
            this.status = status;
        }
        public Customer(int id, DateTime timeChecked, int status)
        {
            this.customerId = id;
            this.timeChecking = timeChecked;
            this.status = status;
            
        }

        public string StatusString()
        {
            string s = "Visitor with ID: " + customerId;
            if(status == 0) { s += " has checked out"; }
            else if(status == 1) { s += " has checked in"; }

            return s;
        }

        public string CustomerHistoryString()
        {
            string s = "Visitor with ID: " + customerId;
            if(status == 0)
            {
                s += " has checked out at ";
            }
            else if(status == 1)
            {
                s += " has checked in at ";
            }
            s += timeChecking.ToString("yyyy - MM - dd HH':'mm':'ss");

            return s;
        }
    }
}
