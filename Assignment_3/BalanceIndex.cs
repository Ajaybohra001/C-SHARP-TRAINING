using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class BalanceIndex
    {
        static int SolveBalanceIndex(int[] array)
        {

            int[] prefixSum = new int[array.Length];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                prefixSum[i] = sum;

            }
            int leftSum = 0;
            int rightSum = 0;
            //first index check
            if (leftSum == prefixSum[prefixSum.Length - 1] - prefixSum[0])
            {
                return 0;
            }



            //Mid index
            for (int j = 1; j < prefixSum.Length - 1; j++)
            {

                leftSum = prefixSum[j - 1];
                rightSum = prefixSum[prefixSum.Length - 1] - prefixSum[j];

                if (rightSum == leftSum)
                {
                    return j;

                }
            }
            //last index

            if (rightSum == prefixSum[prefixSum.Length - 2])
                return prefixSum.Length - 1;
            return -1;

        }
        public static void FindBalanceIndex()
        {
            //Question 1.Find the BI(balanced index) number: it is the index of an integer array for which,sum of lower indexed
            //value = sum of higher indexed value
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

            int ans = SolveBalanceIndex(array);

            Console.WriteLine("The balance index is:" + ans);

        }

    }
}
