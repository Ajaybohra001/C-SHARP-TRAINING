using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ThirdLargest
    {
        static int ThirdLargestNumber(int[] arr1)
        {
            int firstLargest = arr1[0];
            int secondLargest = int.MinValue;
            int thirdLargest = int.MinValue;

            for (int i = 1; i < arr1.Length; i++)
            {
                if(arr1[i]>firstLargest)
                {
                    thirdLargest = secondLargest;
                    secondLargest = firstLargest;
                    firstLargest = arr1[i];
                }
                else if(arr1[i]>secondLargest)
                {
                    thirdLargest = secondLargest;
                    secondLargest = arr1[i];

                }
                else if(arr1[i]>thirdLargest)
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

        public static void FindThirdLargest()
        {
            //Question: 6 Find 3rd largest value in Integer Array.
            int num = -1;
            bool ch = true;

            while (ch)
            {
                Console.WriteLine("Enter the size of the Array : ");
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
            
            int[] arr1 = new int[num];
            if (num < 3)
            {
                Console.WriteLine("3rd largest does not exist ");
            }
            else
            {
                Console.WriteLine("Enter the elements in array ");
                for (int i = 0; i < num; i++)
                {

                    arr1[i] = int.Parse(Console.ReadLine());
                }


                Console.WriteLine("Third largest element in array is : " + ThirdLargestNumber(arr1));

            }
        }
    }
}
