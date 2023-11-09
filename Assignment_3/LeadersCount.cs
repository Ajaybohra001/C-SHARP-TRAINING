using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class LeadersCount
    {
        static int SolveLeadersCount(int[] array)
        {
            int count = 0;
            int maxRight = int.MinValue;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > maxRight)
                {
                    count++;
                    maxRight = array[i];
                }
            }
            return count;
        }

        public static void FindLeaderCount()
        {
            //Question 2:Find the Leaders in an array.Given an integer array A containing N distinct integers, you have to find the count of all
            //  the leaders in array A.
            int num = -1;
            bool ch = true;

            while (ch)
            {
                Console.WriteLine("Enter the size of Array : ");
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


            int[] array = new int[num];
            Console.WriteLine("Enter the elements in Array : ");
            for (int i = 0; i < num; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            int cnt = SolveLeadersCount(array);
            Console.WriteLine("The count of leaders in array is : " + cnt);

        }
    }
}
