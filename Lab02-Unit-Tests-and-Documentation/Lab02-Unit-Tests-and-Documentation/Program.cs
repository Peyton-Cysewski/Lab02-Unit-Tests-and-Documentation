using System;
using System.Net;

namespace Lab02_Unit_Tests_and_Documentation
{
    public class Program
    {
        static public decimal Balance = 10000;

        public static void Main(string[] args)
        {
            UserInterface();
        }

        /// <summary>
        /// runs the menu interface for the console ATM
        /// </summary>
        public static void UserInterface()
        {
            Console.WriteLine("Welcome to the console ATM!");
            int choice = 0;
            while (choice < 1 || choice > 4)
            {
                Console.WriteLine("Enter a number to select an action below:\n1) View Your Balance\n2) Deposit Funds\n3) Withdraw Funds\n4) Exit");

                string userInput = Console.ReadLine();
                Console.Clear();
                try
                {
                    choice = Convert.ToInt32(userInput);
                }
                catch
                {
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your account balance is ${ViewBalance()}\n");
                        choice = 0;
                        break;
                    case 2:
                        Console.WriteLine("What amount would you like to deposit?");
                        try
                        {
                            decimal amount = Convert.ToDecimal(Console.ReadLine());
                            Balance = Deposit(amount);
                            choice = 0;
                        }
                        catch
                        {
                            choice = 0;
                        }
                        break;
                    case 3:
                        Console.WriteLine("What amount would you like to withdraw?");
                        try
                        {
                            decimal amount = Convert.ToDecimal(Console.ReadLine());
                            Balance = Withdraw(amount);
                            choice = 0;
                        }
                        catch
                        {
                            choice = 0;
                        }
                        break;
                    case 4:
                        break;
                }
            }
        }

        /// <summary>
        /// returns the current value of the account balance
        /// </summary>
        /// <returns>current balance amount</returns>
        public static decimal ViewBalance()
        {
            return Balance;
        }

        /// <summary>
        /// allows the user to withdraw money from their atm account
        /// </summary>
        /// <param name="amount">amount to withdraw</param>
        /// <returns>updated balance</returns>
        public static decimal Withdraw(decimal amount)
        {
            if (amount < 0 || amount > Balance)
            {
                return Balance;
            }
            else
            {
                Balance -= amount;
                return Balance;
            }
        }

        /// <summary>
        /// allows the user to withdraw money from their atm account
        /// </summary>
        /// <param name="amount">amount to deposit</param>
        /// <returns>updated balance</returns>
        public static decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                return Balance;
            }
            else
            {
                Balance += amount;
                return Balance;
            }
        }
    }
}
