using System;
// Dyllan Sowers
// Lab 01 for IT 483 fall 2019, MNSU Prof. Alkushayni
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
            // This is functionally equivalent to the previous if-else statement
            // Fance will evaluate to either true or false
            fancy = (f == 'y') || (f == 'Y');

            // While this could be written as a switch/block statment, this would be just as efficient as 
            // what is currently here
            if(spicy) 
            {
                if(fancy) // if spicy and fancy
                {
                    Console.WriteLine("I suggest you go to Thai Garden Palace.");
                }
                else // if spicy and not fancy
                {
                    Console.WriteLine("I suggest you go to Alberto's Tacqueria.");
                }
            }
            else
            {
                if(fancy) // if not spicy and fancy
                {
                    Console.WriteLine("I suggest you go to Chez Paris.");
                }
                else // if not spicy and not fancy
                {
                    Console.WriteLine("I suggest you got to Joe's Diner.");
                }
            }
        }
    }
}
