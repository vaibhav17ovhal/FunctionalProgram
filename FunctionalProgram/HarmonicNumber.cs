using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class HarmonicNumber
    {
        public static void Harmonic()
        {
            Console.Write("Enter the range: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i} + ");
            }
        }
    }
}
