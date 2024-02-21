using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    using System;

    class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
            else
            {
                Balance += amount;
                Console.WriteLine("Deposit of $" + amount + " successful.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a BankAccount object
            BankAccount myAccount = new BankAccount("123456789", 100.0);

            // Display initial balance
            Console.WriteLine("Initial Balance: $" + myAccount.Balance);

            // Deposit money into the account
            double depositAmount = 50.0;
            myAccount.Deposit(depositAmount);

            // Display updated balance
            Console.WriteLine("Updated Balance: $" + myAccount.Balance);

            Console.ReadLine(); // Keep the console window open
        }
    }


}