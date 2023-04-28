using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class SwapNumbers
    {
        public static void SwappingNumbers()
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before Swapping a: {a} and b: {b}");

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine($"After Swapping a: {a} and b: {b}");
        }
    }
}
