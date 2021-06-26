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
            var account = new BankAccount("Lars", 1000);

            Console.WriteLine($"Account: {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeDeposit(3000, DateTime.Now, "Paycheck");
            Console.WriteLine($"Balance after paycheck: {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine($"Balance after Hammock: {account.Balance}");

            account.MakeWithdrawal(1500,DateTime.Now,"Mortgage");
            Console.WriteLine($"Balance after Mortgage: {account.Balance}");

            account.MakeWithdrawal(400, DateTime.Now.AddDays(-5), "Father's day gift");
            Console.WriteLine($"Balance after Father's day gift: {account.Balance}");


            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"\n\nException caught creating account with negative balance.");
                Console.WriteLine($"{e.ToString()}\n\n");
                //return; //use this if I want the program to STOP here. The code below will not execute.
            }

            try
            {
                account.MakeWithdrawal(10000, DateTime.Now, "OVERDRAW");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"\n\nException caught trying to overdraw");
                Console.WriteLine($"{e.ToString()}\n\n");
                //throw;
            }

            account.MakeWithdrawal(60, DateTime.Now, "Xbox Game");
            Console.WriteLine($"Balance after Xbox game: {account.Balance}");

            Console.WriteLine(account.GetAccountHistory());




        }
    }
}
