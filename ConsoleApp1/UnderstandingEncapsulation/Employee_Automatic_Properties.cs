using System;

namespace ConsoleApp1.UnderstandingEncapsulation
{
    public class Employee_Automatic_Properties
    {
        public string Name
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }

        public int CNP
        {
            get;
        }

        public float CurrentPay { get; set; }

        public Employee_Automatic_Properties()
        {

        }

        public Employee_Automatic_Properties(string _name, int _id, float _currentPay)
        {
            Name = _name;
            Id = _id;
            CurrentPay = _currentPay;
        }

        public Employee_Automatic_Properties(float _currentPay, int _cnp)
        {
            CurrentPay = _currentPay;
            CNP = _cnp;
        }

        public void BonusUp(float amount)
        {
            CurrentPay += amount;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Salary: {CurrentPay}");
        }
    }
}
