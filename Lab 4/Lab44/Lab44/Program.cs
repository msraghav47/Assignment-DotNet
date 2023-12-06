using System;
namespace Lab44
{
    public class Temperature
    {
        private double celsius;
        public double Celcius
        {
            get { return celsius; }
            set { celsius = value; }
        }
        public double Fahrenheit
        {
            get { return (celsius * 9 / 5) + 32; }
        }
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            temperature.Celcius = 34;
            double fahrenheit = temperature.Fahrenheit;
            Console.WriteLine("Temperature in Fahrenheit : " + fahrenheit);
        }
    }
}
