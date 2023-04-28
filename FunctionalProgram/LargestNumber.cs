using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class LargestNumber
    {
        public static void FindLargestNumber()
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Find the Largest of Two Numbers.");

            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("First number is greatest among three.");
                }
                else
                {
                    Console.WriteLine("Third number is greatest among three.");

                }
            }
            else if (num2 > num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("Second number is greatest among three.");
                }
                else
                {
                    Console.WriteLine("Third number is greatest among three.");

                }
            }
        }
        }
}
