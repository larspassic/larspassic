using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class BankAccount
    {
        //All elements of a class are called members
        
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get;}

        //This is a constructor
        public BankAccount(string name, decimal initialBalance)
        {
            //This is what happens when you create a new BankAccount object
            this.Owner = name;
            this.Balance = initialBalance;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
