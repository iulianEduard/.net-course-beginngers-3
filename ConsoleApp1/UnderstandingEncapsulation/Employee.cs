using System;

namespace ConsoleApp1.UnderstandingEncapsulation
{
    public class Employee
    {
        private string name;
        private int id;
        private float currentPay;

        public Employee()
        {

        }

        public Employee(string _name, int _id, float _currentPay)
        {
            name = _name;
            id = _id;
            currentPay = _currentPay;
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

        public string GetName()
        {
            return name;
        }

        public void SetName(string _newName)
        {
            if (!char.IsUpper(_newName[0]))
            {
                Console.WriteLine("Name must start with upper case!");
                return;
            }

            name = _newName;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int _id)
        {
            if(_id <= 0)
            {
                Console.WriteLine("Id cannot be less or equal to 0");
                return;
            }

            id = _id;
        }
    }
}
