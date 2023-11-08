using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            
            if (number > 0) //Check if the number is positive, negative, zero
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            
            string evenOrOdd = (number % 2 == 0) ? "even" : "odd"; // Check if the number is even or odd using the conditional operator
            Console.WriteLine("The number is " + evenOrOdd + ".");
            Console.ReadKey();
        }
    }
}
        
    

