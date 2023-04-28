using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class QuotientAndRemainder
    {
        public static void FindQuotientAndRemainder()
        {
            Console.Write("Enter the value of dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int Quotient = dividend / divisor;
            int Remainder = dividend % divisor;

            Console.WriteLine($"Quotient: {Quotient}");
            Console.WriteLine($"Remainder: {Remainder}");
        }
    }
}
