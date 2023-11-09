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
     
        static void Main(string[] args)
        {
            bool ch=true;
            int choice=-1;
            do
            {
                Console.WriteLine("1.Find Magical Number.");
                Console.WriteLine("2.Find the minimum gap ");
                Console.WriteLine("3.Find the Perfect number");
                Console.WriteLine("4.Remove Extra spaces from string.");
                Console.WriteLine("5.Find pair sum.");
                Console.WriteLine("6.Third largest Number.");
                Console.WriteLine("7.Find the product array.");
                Console.WriteLine("8.Press 8 to exit");
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

                        MagicalNumbers.IsMagicalNumber();
                        break;
                    case 2:
                        MinGap.FindMinGap();
                        break;

                    case 3:
                        PerfectNumber.IsPerfectNumber();
                        break;

                    case 4:
                        RemoveMultipleSpaces.ExtraSpacesRemove();
                        break;

                    case 5:
                        TwoSum.FindPairSum();
                        break;
                    case 6:

                        ThirdLargest.FindThirdLargest();
                        break;
                    case 7:
                        ProductArray.FindProductArray();
                        break;
                    case 8:
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
