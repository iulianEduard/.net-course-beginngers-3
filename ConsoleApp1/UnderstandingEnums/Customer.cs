using ConsoleApp1.Helpers;
using System;

namespace ConsoleApp1
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private MasterCardType masterCardType;

        public Customer(string first_Name, string last_Name)
        {
            firstName = first_Name;
            lastName = last_Name;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public string GetFullName()
        {
            return $"{firstName} {lastName}";
        }

        public void SetCardForClient(int type)
        {
            switch(type)
            {
                case 1:
                    masterCardType = MasterCardType.Basic;
                    break;
                case 2:
                    masterCardType = MasterCardType.Gold;
                    break;
                case 3:
                    masterCardType = MasterCardType.Platinum;
                    break;
                case 4:
                    masterCardType = MasterCardType.WorldElite;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        public void GetCardForClient()
        {
            Console.WriteLine($"{GetFullName()} has the following card: {masterCardType}");
        }

    }
}
