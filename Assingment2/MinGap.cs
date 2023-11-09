using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MinGap
    {
        static int SolveMinGap(int n)
        {
            var num = Math.Sqrt(n);
            int lowerValue = (int)Math.Floor(num);
            int higherValue = (int)Math.Ceiling(num);

            int prevPerfectSquare = (int)Math.Pow(lowerValue, 2);
            int nextPerfectSquare = (int)Math.Pow(higherValue, 2);

            int gap = Math.Min(n - prevPerfectSquare, nextPerfectSquare - n);
            return gap;

        }

        public static void FindMinGap()
        {

            int num=-1;
            bool ch = true;

            while (ch)
            {
                Console.WriteLine("Enter the number : ");
                var n = Console.ReadLine();
                bool successive = int.TryParse(n, out num);

                if (num < 0)
                {
                    Console.WriteLine("Enter the valid input");
                    continue;
                }
                if (!successive)
                {
                    Console.WriteLine("Enter the valid value");
                }
                else
                    ch = false;
            }


                Console.WriteLine("The minimun gap to make the given number " + num + " a perfect square is : " + SolveMinGap(num));
            
        }
    }
}
