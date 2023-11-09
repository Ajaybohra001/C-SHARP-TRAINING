using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ProductArray
    {
        static void PrintProductArray(int[] arr)
        {
            int[] ansArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                var product = 1;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                        product = product * arr[j];

                }
                ansArray[i] = product;
            }
            Console.WriteLine("The updated array with product of elements : ");
            for (int k = 0; k < ansArray.Length; k++)
            {
                Console.WriteLine(ansArray[k]);
            }
        }
        public static void FindProductArray()
        {
            //Question 7: Return an array with product of element
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



           
            int[] arr1 = new int[num];




            Console.WriteLine("Enter the elements in array ");
            for (int i = 0; i < num; i++)
            {

                arr1[i] = int.Parse(Console.ReadLine());
            }

            PrintProductArray(arr1);
        }
    }
}
