using System;

namespace ConsoleApp1.UnderstandingStatic
{
    public class SavingsAccount
    {
        public double currBalance;
        public static double currInterestRate = 0.04;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        static SavingsAccount()
        {
            Console.WriteLine("In static constructor!");
            currInterestRate = 0.08;
        }

        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
