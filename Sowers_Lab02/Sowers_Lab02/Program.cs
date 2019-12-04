using System;

namespace Sowers_Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int prescription = 0;
            int coating = 0;
            while((prescription != 2) && (prescription != 1))
            {
                Console.Write("What kind of glasses would you like: \n1 -> prescription, 2 -> non-prescription : ");
                prescription = Convert.ToInt32(Console.ReadLine());
            }
            while((coating != 2) && (coating != 1))
            {
                Console.Write("What kind of coating would you like: \n1 -> anti-glare, 2 -> brown tint : ");
                coating = Convert.ToInt32(Console.ReadLine());
            }
            if (prescription == 1)
            {
                if(coating == 1)
                {
                    Console.WriteLine("Your cost is $52.50");
                }
                else
                {
                    Console.WriteLine("Your cost is $49.99");
                }
            }
            else
            {
                if(coating == 1)
                {
                    Console.WriteLine("Your cost is $37.50");
                }
                else
                {
                    Console.WriteLine("Your cost is $34.99");
                }
            }
        }
    }
}
