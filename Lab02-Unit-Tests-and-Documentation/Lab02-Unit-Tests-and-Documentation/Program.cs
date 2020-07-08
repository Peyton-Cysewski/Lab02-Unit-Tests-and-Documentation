using System;

namespace Lab02_Unit_Tests_and_Documentation
{
    public class Program
    {
        static public decimal Balance = 10000;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// returns the current value of the account balance
        /// </summary>
        /// <returns>balance amount</returns>
        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static decimal Withdraw(decimal amount)
        {
            if (amount < 0 || amount > Balance)
            {
                return Balance;
            }
            else
            {
                Balance = Balance - amount;
                return Balance;
            }
        }
    }
}
