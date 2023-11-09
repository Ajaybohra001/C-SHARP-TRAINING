using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MagicalNumbers
    {
        static void MagicalNumber(string str)
        {
            StringBuilder sb = new StringBuilder(str);

            bool endProcess = false;
            int sum = 0;

            while (!endProcess)
            {
                for (int i = 0; i < sb.Length; i++)
                {
                    char ch = sb[i];
                    int num = int.Parse(ch.ToString());
                    sum += num;
                }
                if (sum >= 10)
                {
                    sb.Clear();
                    sb.Append(sum.ToString());
                    sum = 0;
                }
                else
                {
                    endProcess = true;
                }
            }
            if (sum == 1)
                Console.WriteLine("It is a magical number");
            else Console.WriteLine("It is not a magical number ");
        }

        public static void IsMagicalNumber()
        {
            

            Console.WriteLine("Enter the string number : ");
            var str = Console.ReadLine();

            MagicalNumber(str);

        }
    }
}
