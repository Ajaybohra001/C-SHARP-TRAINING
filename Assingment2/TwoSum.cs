using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TwoSum
    {
        static void ArraySum(int[] arr, int mNum)
        {
            List<int[]> result = new List<int[]>();


            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] < mNum && i != j)
                    {
                        int[] temp = new int[2];
                        temp[0] = i;
                        temp[1] = j;
                        result.Add(temp);
                    }

                }

            }
            if (result.Count == 0)
            {
                Console.WriteLine("There is no pair exist");
            }
            {
            }

            foreach (var val in result)
            {
                Console.WriteLine(val[0] + "," + val[1]);
            }

        }

        public static void FindPairSum()
        {
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




            int[] arr = new int[num];

            Console.WriteLine("Enter the elements in array");
            for (int i = 0; i < arr.Length; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                arr[i] = n;
            }
            Console.WriteLine("Enter the target sum :  ");
            int mNum = int.Parse(Console.ReadLine());

            ArraySum(arr, mNum);
        }
    }
}
