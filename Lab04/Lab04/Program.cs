// Dyllan Sowers Lab 04 For IT483 Fall 2019 

/* Answers to Problem Description Questions:
 *  1.  Yes, you need the int parameter versions of average if you want to call the function 
 *      using integers. If you were to try to cast integers to the function which is only defined 
 *      with doubles an error would occur.
 *      
 *  2.  You need the three paramter version. Averaging two numbers first then averaging the result 
 *      with a third number is not equivalent to just averaging three numbers. This is not the way 
 *      the commutative property works with both additon and multiplication involved. 
 *      
 *  3.  That is not legal. 2.0 is a double and 1 and 3 are integers. There are no presently defined
 *      methods which accept a mix of parameter types. 
 */

using System;

namespace Lab04
{
    class Program
    {
        public static double average(int n1, int n2, int n3)
        {
            return (n1 + n2 + n3) / 3.0;
        }

        public static double average(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3.0;
        }

        public static double average(double n1, double n2)
        {
            return (n1 + n2) / 2.0;
        }

        public static double average(int n1, int n2)
        {
            return (n1 + n2) / 2.0;
        }

        static void Main(string[] args)
        {
            int a = 1, b = 3, c = 5;
            double x = 2.2, y = 4.4, z = 6.6, ans;

            ans = average(a, b);
            Console.WriteLine("\naverage(a, b) = " + ans);

            ans = average(a, b, c);
            Console.WriteLine("\naverage(a, b, c) = " + ans);

            ans = average(x, y);
            Console.WriteLine("\naverage(x, y) = " + ans);

            ans = average(x, y, z);
            Console.WriteLine("\naverage(x, y, z) = " + ans);

            // Evaluates to false. 3 parameter version is needed. 
            Console.WriteLine(average(average(x, y), z) == average(x, y, z));
        }
    }
}
