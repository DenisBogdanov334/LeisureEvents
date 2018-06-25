using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    class LoanedProduct
    {
        private string nameProduct;
        private int amountBorrowed;

        public string NameProduct { get { return nameProduct; } }
        public int AmountBorrowed { get { return amountBorrowed; } }
        public LoanedProduct(string name, int amount)
        {
            this.nameProduct = name;
            this.amountBorrowed = amount;
        }
    }
}
