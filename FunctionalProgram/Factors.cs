using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class Factors
    {
        public static void FactorPrime()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1;  i <= num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine($"{i} is a factor of {num}");
                }
            }
        }
    }
}
