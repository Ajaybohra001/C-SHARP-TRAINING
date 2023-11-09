using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class SwitchBulb
    {
        static int SwitchAction(int[] array)
        {
            int switchCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int currentState = array[i];
                if (switchCount % 2 == 1)
                {
                    currentState = array[i] == 0 ? 1 : 0;

                }
                if (currentState == 0)
                {
                    switchCount++;
                }
            }

            return switchCount;
        }

        public static void CountSwitchAction()
        {
            //Quesion 3:Lazy person's switch action.A wire connects N light bulbs.Each bulb has a switch associated with it; however, due to faulty wiring,
            //          a switch also changes the state of all the bulbs to the right of the current bulb.
            //          Given an initial state of all bulbs, find the minimum number of switches a person have to press to turn on all the bulbs.
            //          The person can press the same switch multiple times.

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
            Console.WriteLine("Total count " + SwitchAction(array));


        }

    }
}
