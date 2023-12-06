using System;
namespace Lab43
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public string fullName
        {
            get
            {
                return (firstName.ToUpper() + " " + lastName.ToUpper());
            }
        }
        public Person(string firstname, string lastname)
        {
            this.firstName = firstname;
            this.lastName = lastname;
        }
        static void Main(string[] args)
        {
            Person person = new Person("Mohit", "Raghav");
            Console.WriteLine("Full Name : "+person.fullName);
        }
    }
}
