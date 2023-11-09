using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
      
        static void Main(string[] args)
        {
          
            bool ch = true;
            int choice = -1;
            do
            {
                Console.WriteLine("1.Find Balance Index in an array.");
                Console.WriteLine("2.Find the Leaders count in array. ");
                Console.WriteLine("3.Find maximum subarray sum.");
                Console.WriteLine("4.Find the switch count.");
               
                Console.WriteLine("5.Press 5 to exit");
                Console.WriteLine();
                bool t = true;
                while (t)
                {
                    Console.WriteLine("Enter the choice ");
                    var c = Console.ReadLine();
                    bool successive = int.TryParse(c, out choice);
                    if (!successive)
                    {
                        Console.WriteLine("Invalid input");
                    }
                    else
                        t = false;

                }

                switch (choice)
                {
                    case 1:

                        BalanceIndex.FindBalanceIndex();
                        break;
                    case 2:
                        LeadersCount.FindLeaderCount();
                        break;

                    case 3:
                        MaxSubarray.FindMaxSubarraySum();
                        break;

                    case 4:
                        SwitchBulb.CountSwitchAction();
                        break;

                   
                    case 5:
                        ch = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;


                }
            } while (ch);




            Console.ReadKey();





        }
    }
}
