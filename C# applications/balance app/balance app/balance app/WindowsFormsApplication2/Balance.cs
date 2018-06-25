using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Balance
    {
        private String bank_account;
        private DateTime date_start;
        private DateTime date_end;
        private int amount_of_deposits;
        private int user_account_money;


        public Balance(String bank_account, DateTime date_start, DateTime date_end, int amount_of_deposits, int user_account_money)
        {

            this.bank_account = bank_account;
            this.date_start = date_start;
            this.date_end = date_end;
            this.amount_of_deposits = amount_of_deposits;
            this.user_account_money = user_account_money;
        }
    }
}
