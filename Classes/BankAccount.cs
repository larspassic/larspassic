using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class BankAccount
    {
        //All elements of a class are called members
        

        //These are called member declarations
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance = balance + item.Amount;
                }
                return balance;
            }
            
        }

        //This is a data member.
        //It's private, which means it can only be accessed by code inside the BankAccount class.
        //It's a way of separating the public responsibilities (like having an account number) from the private implementation (how account numbers are generated).
        //It is also static, which means it is shared by all of the BankAccount objects.
        //The value of a non-static variable is unique to each instance of the BankAccount object.
        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        //This is the constructor for the bank account class
        public BankAccount(string name, decimal initialBalance)
        {
            //This is what happens when you create a new BankAccount object
            this.Owner = name;

            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
            
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                //because that "throw" is there, it will exit the function
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive.");

            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive.");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);

        }

        public string GetAccountHistory()
        {

            var report = new StringBuilder();

            Console.WriteLine($"\n\n\n");

            //This makes the header
            report.AppendLine("Date\t\t\tAmount\tNote");
            
            //Loop through and make the rows
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date}\t{item.Amount}\t{item.Notes}");
            }

            //Convert the StringBuilder object to a string object and send it back!
            return report.ToString();

        }
    }
}
