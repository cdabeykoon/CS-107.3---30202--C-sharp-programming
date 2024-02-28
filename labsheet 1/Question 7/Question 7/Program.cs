using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    internal class Program
    {
        
            static double balance = 0;

            static void Main(string[] args)
            {
                bool continueTransaction = true;

                while (continueTransaction)
                {
                    Console.WriteLine("Welcome to the ATM machine!");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Exit");

                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CheckBalance();
                            break;
                        case 2:
                            DepositMoney();
                            break;
                        case 3:
                            WithdrawMoney();
                            break;
                        case 4:
                            continueTransaction = false;
                            Console.WriteLine("Thank you for using the ATM. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

            static void CheckBalance()
            {
                Console.WriteLine($"Your current balance is: ${balance}");
            }

            static void DepositMoney()
            {
                Console.Write("Enter the amount to deposit: ");
                double amount = double.Parse(Console.ReadLine());
                balance += amount;
                Console.WriteLine($"${amount} deposited successfully. Your new balance is: ${balance}");
            }

            static void WithdrawMoney()
            {
                Console.Write("Enter the amount to withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                if (amount > balance)
                {
                    Console.WriteLine("Insufficient funds. Withdrawal failed.");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine($"${amount} withdrawn successfully. Your new balance is: ${balance}");
                }
            }
        }
    }

