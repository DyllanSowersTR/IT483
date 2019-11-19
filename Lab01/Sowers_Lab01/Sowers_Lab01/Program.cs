using System;

namespace Sowers_Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CS 201 Restaurant Guide\n");
            string response;
            char s, f;
            bool spicy, fancy;

            // Ask user for his/her preference
            Console.WriteLine("Do you like spicy food? (y / n) : ");
            // Get the next token
            response = Convert.ToString(Console.ReadLine());
            // Look only at the first character
            s = response[0];
            if (s == 'y' || s == 'Y')
                spicy = true;
            else
                spicy = false;

            // Ask user for his/her preference 
            Console.WriteLine("Do you want to go to a fancy restaurant? (y / n) : ");
            //Get the next token
            response = Convert.ToString(Console.ReadLine());
            f = response[0];
            fancy = (f == 'y') || (f == 'Y');



        }
    }
}
