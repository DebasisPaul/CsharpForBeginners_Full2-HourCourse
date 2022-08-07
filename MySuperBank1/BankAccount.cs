// =================================================================================================================================

// C#: Objects Oriented Programming - Objects and Classes

using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public Void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}