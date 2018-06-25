using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanStand
{
    class CustomerException:Exception
    {
        public CustomerException() : base() { }
        public CustomerException(string message) : base(message) { }
    }
}
