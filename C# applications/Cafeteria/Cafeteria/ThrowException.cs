using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class ThrowException : Exception
    {
        public ThrowException() : base() { }
        public ThrowException(string message) : base(message) { } 
    }
}
