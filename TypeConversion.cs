using System;
using System.Text;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit conversion short to int,float,double,decimal
            short n1 = 2;
            int n2 = n1;
            float n3 = n1;
            double n4 = n1;
            decimal n5 = n1;

            //Implicit conversion int to float,double,decimal

            int num1 = 8;
            float num2 = num1;
            decimal num3 = num1;
            double num4 = num1;

            //Implicit conversion float to double,decimal

            float x1 = 4.23f;
            //decimal x2 = x1;  (We can not implicitly convert float to decimal).

            double x3 = x1;

            //Implicit conversion long  to double,decimal

            long b1 = 72123;
            double b2 = b1;
            decimal dn = b1;



            //Explicit Conversion float to decimal,int,string using Convert

            float f1 = 821.121f;
            decimal d1 = Convert.ToDecimal(f1);

            int i1 = Convert.ToInt32(f1);

            string s = Convert.ToString(f1);

            double d2 = 12.232;
            int i2 = (int)d2;

            // using parse function

            string st = "2324";
            int a = int.Parse(st);

            //Explicit conversion int to bool

            int z1 = 0;
            int z2 = 1;


            bool bl1 = Convert.ToBoolean(z1);
            bool bl2 = Convert.ToBoolean(z2);




            //String functions
            String str = "AjayBohra";
            Console.WriteLine(str);


            //Clone
            string str1 = (string)str.Clone();
            Console.WriteLine("The Clone Value is : "+ str1);


            //Compare
            Console.WriteLine("The two string st1 and str  are equal? "+ str.Equals(str1));

            // Adding some data to the string str1(new mwmmory will allocate for str1 it will not modify the original string).
            str1=" hello my absdfhashfkjhas";
            Console.WriteLine("THe new value of str1: "+ str1);

            //Concat
            Console.WriteLine("Concating the str and str1 : "+ string.Concat(str, str1));

            //Contain
            Console.WriteLine("Is str contains str1 : "+ str.Contains(str1));

            

            //Lower Case

            Console.WriteLine("Converting string into lower alpha : "+ str.ToLower());


            //Upper Case
            Console.WriteLine("Converting String to Upper Alphabet : "+ str.ToUpper());

            //Length

            Console.WriteLine("The length of the string is : "+ str.Length);


            //Replace 
            Console.WriteLine("Replacing the char 'j' with 'a' : "+ str.Replace('j', 'a'));


            // using format string)(If we want to insert the data into a string we use String.Format)
            float weight = 60.532f;
            string strweight = String.Format("My body weight is {0} kg.", weight);
            Console.WriteLine(strweight);

            string name = "Ajay";
            string city = "Delhi";

            string strName = String.Format("My name is {0}.I am from {1}", name, city);
            Console.WriteLine(strName);

            //USING STRING BUILDER CLASS:
            StringBuilder sb = new StringBuilder("My name is Ajay");
            Console.WriteLine(sb);
            sb.Append(" i am currently pursuing MCA from GGSIPU");
            sb.AppendLine("I am currently working as a software engineer at Successive tech.");

            Console.WriteLine(sb);



            Console.ReadKey();













        }
    }
}
