using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class PowerOfTwo
    {
        public static void CalculatingPower()
        {
            Console.Write("Enter the Size of Degree: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("The value of 2^{0}: {1}", i, Math.Pow(2,i));
            }
        }
    }
}
