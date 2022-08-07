// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 10000);
            account.Deposit(100);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
        }
    }
}
