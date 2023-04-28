using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class EvenAndOdd
    {
        public static void CheckingEvenOrOdd()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0 )
            {
                Console.WriteLine($"{num} is even number.");
            }
            else
            {
                Console.WriteLine($"{num} is odd number.");
            }
        }
    }
}
