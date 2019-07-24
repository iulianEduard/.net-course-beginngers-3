namespace ConsoleApp1
{
    public class Client
    {
        private string firstName;
        private string lastName;

        public Client()
        {
            System.Console.WriteLine("This is the empty constructor");
        }

        public Client(string _firstName) : base()
        {
            firstName = _firstName;
        }

        public Client(string _firstName, string _lastName)
        {
            firstName = _firstName;
            lastName = _lastName;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetFirstName(string _newFirstName)
        {
            firstName = _newFirstName;
        }

        public void SetLastName(string _newLastName)
        {
            lastName = _newLastName;
        }
    }
}
