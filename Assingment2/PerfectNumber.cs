using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class PerfectNumber
    {
        static bool PrintPerfectNumber(int num)
        {
            if (num == 0) return false;
            int sumFactors = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    sumFactors += i;
            }
            if (sumFactors == num)
                return true;

            return false;

        }
        public static void IsPerfectNumber()
        {
            int num = -1;
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


            

            if (PrintPerfectNumber(num))
            {
                Console.WriteLine("The input number " + num + " is " + "Perfect Number");
            }
            else
                Console.WriteLine("The input number " + num + " is " + " Not a Perfect Number");
        }
    }
}
