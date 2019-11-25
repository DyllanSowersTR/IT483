// Dyllan Sowers & Adam Schultz Lab03

using System;

namespace AdamDyllanProject
{
    class Program
    {
        static double transaction(double curBal, double amount)
        {
            if ((curBal + amount) < 0)
            {
                return curBal * -1;
            }
            else
            {
                return amount;
            }
        }
        static void Main(string[] args)
        {
            double curBal = 45.32;

            double amount;
            Console.WriteLine("Please enter a amount of update account by $");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nCustomer's balance (before transaction) = $"
                + curBal + "\nRequested update amount = $" + amount + "\n");

            double actAmount;
            actAmount = transaction(curBal, amount);

            curBal += actAmount;

            Console.WriteLine("Actual update amount = $" + actAmount + "\nCustomer's"
                + " balance (after transaction) = $" + curBal + "\nThank you and "
                + "good-bye!");

        }

    }
}
