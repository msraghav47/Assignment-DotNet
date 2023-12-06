using System;
namespace Lab42
{
    public class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public string FullName
        {
            get { return (Make+" "+Model+" "+Year); }
        }
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Camry", 2022);
            Console.WriteLine("Car Full Name : "+car.FullName);
        }
    }
}
