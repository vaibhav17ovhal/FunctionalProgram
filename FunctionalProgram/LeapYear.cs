using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class LeapYear
    {
        public static void CheckingLeapYear()
        {
            Console.Write("Enter the Year: ");
            int Year = Convert.ToInt32(Console.ReadLine());

            if (Year > 999 && Year < 10000)
            {
                if (Year % 400 == 0)
                {
                    Console.WriteLine($"{Year} is a leap year.");
                }
                else if (Year % 100 == 0)
                {
                    Console.WriteLine($"{Year} is not a leap year.");
                }
                else if (Year % 4  == 0)
                {
                    Console.WriteLine($"{Year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"{Year} is not a leap year.");        
                }
            }
            else
            {
                Console.WriteLine("Enter a Valid Year.");
            }
        }
    }
}
