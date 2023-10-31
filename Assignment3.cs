using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static int BalanceIndex(int[] array)
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

        static int leadersCount(int[] array)
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

        static int SwitchAction(int[] array)
        {
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = 1;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] == 0)
                        {
                            array[j] = 1;
                        }
                        else
                        {
                            array[j] = 0;
                        }
                    }
                    cnt++;
                }
            }
            return cnt;
        }

        
        static void Main(string[] args)
        {
            //Question 1.Find the BI(balanced index) number: it is the index of an integer array for which,sum of lower indexed
            //value = sum of higher indexed value
            //Console.WriteLine("Enter the size of array : ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];
            //Console.WriteLine("Enter the elements in Array : ");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i]=    int.Parse(Console.ReadLine());

            //}

            //int ans= BalanceIndex(array);

            //Console.WriteLine("The balance index is:" + ans);

            //Question 2:Find the Leaders in an array.Given an integer array A containing N distinct integers, you have to find the count of all
            //  the leaders in array A.

            //Console.WriteLine("Enter the size of array : ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];
            //Console.WriteLine("Enter the elements in Array : ");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());

            //}
            //int cnt=leadersCount(array);
            //Console.WriteLine("The count of leaders in array is : " + cnt);


            //Question 4:  Maximum Subarray. You are given an integer array A of size N.Now you need to find a subarray(contiguous elements)
            //             so that the sum of contiguous elements is maximum.

            Console.WriteLine("Enter the size of array : ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Enter the elements in Array : ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The maximum subarray sum is : " + MaxSubarraySum(array));

            //Quesion 3:Lazy person's switch action.A wire connects N light bulbs.Each bulb has a switch associated with it; however, due to faulty wiring,
            //          a switch also changes the state of all the bulbs to the right of the current bulb.
            //          Given an initial state of all bulbs, find the minimum number of switches a person have to press to turn on all the bulbs.
            //          The person can press the same switch multiple times.


            //Console.WriteLine("Enter the size of array : ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];
            //Console.WriteLine("Enter the elements in Array : ");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("Total count " + SwitchAction(array));



            Console.ReadKey();





        }
    }
}
