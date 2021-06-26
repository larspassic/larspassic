﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        //Constructor for the transaction class
        public Transaction( decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;


        }


    }
}
