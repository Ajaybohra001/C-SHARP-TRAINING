using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class RemoveMultipleSpaces
    {
        static void RemoveMultiSpaces(string s)
        {
            StringBuilder result = new StringBuilder("");
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

        public static void ExtraSpacesRemove()
        {


            string s;
            Console.WriteLine("Enter a string : ");
            s = Console.ReadLine();

            s = s.Trim();
            RemoveMultiSpaces(s);
        }
    }
}
