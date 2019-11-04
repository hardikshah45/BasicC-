using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    class Transaction
    {   
        public decimal Amount { get; }

        public DateTime date { get; }

        public string note { get; }

        public Transaction( decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.date = date;
            this.note = note;

        }


    }
}
