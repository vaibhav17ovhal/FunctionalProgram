using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class FlipCoin
    {
        public static void DisplayPercentage()
        {
            Console.Write("Enter the number of flips: ");
            int Flip = Convert.ToInt32(Console.ReadLine());

            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;
            double HeadPercentage;
            double TailPercentage;

            if (Flip > 0 )
            {
                for (int i = 1; i <= Flip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine($"The random function is: {number}");

                    if (number == 0)
                    {
                        HeadCount++;
                    }
                    else 
                    {
                        TailCount++;
                    }
                }
                Console.WriteLine("The Head Count is: " + HeadCount);
                Console.WriteLine("The Tail Count is: " + TailCount);

                HeadPercentage = HeadCount * 100 / Flip;
                TailPercentage = TailCount * 100 / Flip;

                Console.WriteLine($"The Head Percentage is {HeadPercentage}%");
                Console.WriteLine($"The Tail Percentage is {TailPercentage}%");
            }
        }
    }
}
