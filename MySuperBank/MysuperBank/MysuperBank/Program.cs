// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
  
// C#: Object Oriented Programming - Methods & Members

using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            // account.MakeDeposit(-300, DateTime.Now, "stealing");

            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());




            // hey this is a comment

            // Test for a negative balance:
            try
            {
                account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            // Test that the initial balances must be positive.

            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
