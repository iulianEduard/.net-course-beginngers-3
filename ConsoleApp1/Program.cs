using ConsoleApp1.UnderstandingStatic;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        static void UnderstandingStatic()
        {
            Console.WriteLine("***** Fun with Static Data* ****\n");
            var s1 = new SavingsAccount(50);
            var s2 = new SavingsAccount(100);

            // Print the current interest rate.
            Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterestRate()}");
            
            // Make new object, this does NOT ’reset’ theinterest rate.
            var s3 = new SavingsAccount(10000.75);

            Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterestRate()}");
        }
    }
}
