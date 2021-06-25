using System;

namespace Classes
{
    class Program
    {
        /*
         * It has a 10-digit number that uniquely identifies the bank account.
         * It has a string that stores the name or names of the owners.
         * The balance can be retrieved.
         * It accepts deposits.
         * It accepts withdrawals.
         * The initial balance must be positive.
         * Withdrawals cannot result in a negative balance.
         * 
         */
        
        static void Main(string[] args)
        {
            var account = new BankAccount("Lars", 10);

            Console.WriteLine($"Account: {account.Number} was created for {account.Owner} with {account.Balance}");
        }
    }
}
