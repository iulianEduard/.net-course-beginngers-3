using System;

namespace ConsoleApp1.UnderstandingEncapsulation
{
    public class Employee_Basic_Properties
    {
        private string name;
        private int id;
        private float currentPay;
        private int cnp;

        public string Name
        {
            get { return name; }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    Console.WriteLine("Name must start with upper case!");
                    return;
                }

                name = value;
            }
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Id cannot be less or equal to 0");
                    return;
                }

                id = value;
            }
        }

        public int CNP
        {
            get { return cnp; }
        }

        public Employee_Basic_Properties()
        {

        }

        public Employee_Basic_Properties(string _name, int _id, float _currentPay)
        {
            name = _name;
            id = _id;
            currentPay = _currentPay;
        }

        public Employee_Basic_Properties(float _currentPay, int _cnp)
        {
            currentPay = _currentPay;
            cnp = _cnp;
        }

        public void BonusUp(float amount)
        {
            currentPay += amount;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Salary: {currentPay}");
        }
    }
}
