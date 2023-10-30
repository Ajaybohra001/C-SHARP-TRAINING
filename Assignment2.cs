using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static bool PerfectNumber(int num)
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

        static int MinGap(int n)
        {
            var num = Math.Sqrt(n);
            int lowerValue = (int)Math.Floor(num);
            int higherValue = (int)Math.Ceiling(num);

            int prevPerfectSquare = (int)Math.Pow(lowerValue, 2);
            int nextPerfectSquare = (int)Math.Pow(higherValue, 2);

            int gap = Math.Min(n - prevPerfectSquare, nextPerfectSquare - n);
            return gap;

        }

        static void ArraySum(int[] arr, int mNum)
        {
            List<int[]> result = new List<int[]>();


            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] < mNum && i!=j)
                    {
                        int[] temp = new int[2];
                        temp[0] = i;
                        temp[1] = j;
                        result.Add(temp);
                    }
                    
                }

            }
            
            foreach(var val in result)
            {
                Console.WriteLine(val[0]+","+val[1]);
            }

             }

        static void MagicalNumber(string str)
        {
            int num = int.Parse(str);
            int sum = 0;
            while(num!=0 )
            {
                int digit = num % 10;
                sum += digit;
                num = num / 10;
                if (num == 0 && sum > 9)
                {
                    num = sum;
                    sum = 0;
                }
            }
            Console.WriteLine("Sum : " + sum);
            if (sum == 1)
                Console.WriteLine("It is a magical number");
            else Console.WriteLine("It is not a magical number ");
        }

        static void RemoveMultiSpaces(string s)
        {
            StringBuilder result =new StringBuilder("");
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && (i + 1 < s.Length && s[i + 1] == ' '))
                {
                    continue;
                }
                else
                {
                    result.Append(s[i]);
                }
            }
            Console.WriteLine(result);

        }
       static int ThirdLargestNumber(int[] arr1)
        {
            int largest = arr1[0];
            int secondLargest = int.MinValue;
            int thirdLargest = int.MinValue;

            for (int i = 1; i <arr1.Length ; i++)
            {
                largest = Math.Max(arr1[i], largest);
            }


            
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > secondLargest && arr1[i] < largest )
                {
                    secondLargest = arr1[i];
                }
            }

            
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > thirdLargest && arr1[i] < secondLargest )
                {
                    thirdLargest = arr1[i];
                }
            }
            if (thirdLargest == int.MinValue)
            {
                Console.WriteLine("Third largest value not exist : ");
                return int.MinValue;
            }

            return thirdLargest;
        }

        static void ProductArray(int []arr)
        {
            int[] ansArray = new int[arr.Length];
            for(int i=0;i<arr.Length;i++)
            {
               var product = 1;
                for(int j=0;j<arr.Length;j++)
                {if (i != j)
                        product = product * arr[j];
                   
                }
                ansArray[i] = product;
            }
            Console.WriteLine("The updated array with product of elements : ");
            for(int k=0;k<ansArray.Length;k++)
            {
                Console.WriteLine(ansArray[k]);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number : ");
            //int num= Convert.ToInt32(Console.ReadLine());   

            //if(PerfectNumber(num))
            //{
            //    Console.WriteLine("The input number " + num  + " is " + "Perfect Number");
            //}
            //else
            //    Console.WriteLine("The input number " + num + " is " + " Not a Perfect Number");


            //Question 2 : Find minimum gap to make the given number a perfect square.
            // int n;

            // Console.WriteLine("Enter the number : ");
            // n=int.Parse(Console.ReadLine());  

            //Console.WriteLine("The minimun gap to make the given number "+  n + " a perfect square is : " + MinGap(n));

            //Question 3: Two sum problem

            //int[] arr = new int[5];

            //Console.WriteLine("Enter the elements in array");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    arr[i] = n;
            //}
            //Console.WriteLine("Enter the taret sum :  ");
            //int mNum = int.Parse(Console.ReadLine());

            //Program.ArraySum(arr, mNum);

            //Question 4:  Magical String

            //Console.WriteLine("Enter the string number : ");
            //var str=Console.ReadLine();

            //MagicalNumber(str);


            //Question 5: Program to remove multiple spaces from a string

            //string s;
            //Console.WriteLine("Enter a string : ");
            //s = Console.ReadLine();

            //s = s.Trim();
            //RemoveMultiSpaces(s);

            //Question: 6 Find 3rd largest value in Integer Array.

            //Console.WriteLine("Enter the size of an array : ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //if (n < 3)
            //{
            //    Console.WriteLine("3rd largest does not exist ");
            //}
            //else
            //{
            //    Console.WriteLine("Enter the elements in array ");
            //    for (int i = 0; i < n; i++)
            //    {

            //        arr1[i] = int.Parse(Console.ReadLine());
            //    }


            //    Console.WriteLine("Third largest element in array is : " + ThirdLargestNumber(arr1));

            //}

            //Question 7: Return an array with product of element
            //Console.WriteLine("Enter the size of an array : ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];




            //    Console.WriteLine("Enter the elements in array ");
            //    for (int i = 0; i < n; i++)
            //    {

            //        arr1[i] = int.Parse(Console.ReadLine());
            //    }

            //ProductArray(arr1);




            Console.ReadKey();
        }
    }
}
