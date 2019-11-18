using System;

namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                double celsius;
                Console.WriteLine("Enter a temp in f: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine("Celsius temp: " + celsius +"\nContinue? n to stop");
                string cont = Convert.ToString(Console.ReadLine());
                if(cont == "n")
                {
                    break;
                }
            }
        }
    }
}
