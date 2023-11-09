using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class MaxSubarray
    {
        static int MaxSubarraySum(int[] array)
        {
            int sum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (sum > maxSum)
                    maxSum = sum;

                if (sum < 0)
                    sum = 0;

            }
            return maxSum;
        }
        public static void FindMaxSubarraySum()
        {
            //Question 4:  Maximum Subarray. You are given an integer array A of size N.Now you need to find a subarray(contiguous elements)
            //             so that the sum of contiguous elements is maximum.

            int num = -1;
            bool ch = true;

            while (ch)
            {
                Console.WriteLine("Enter the size of Array : ");
                var n = Console.ReadLine();
                bool successive = int.TryParse(n, out num);
                if (num <= 0)
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
            Console.WriteLine("The maximum subarray sum is : " + MaxSubarraySum(array));

        }
    }
}
       