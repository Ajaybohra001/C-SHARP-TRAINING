using System;


namespace SimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ch = true;
            Console.WriteLine("Enter the Principal Amount: ");
            var p = Console.ReadLine();
            decimal principal;
            bool isValidPrincipal = Decimal.TryParse(p, out principal);
           
               

                if (!isValidPrincipal)
                {
                    Console.WriteLine("Please enter correct input ");
                   

                }
                else
                {
                    ch = false;
                }
            
            

            Console.WriteLine("Enter the Rate of Interest per annum : ");
            var r = Console.ReadLine();
            decimal rate;

            bool isValidRate = Decimal.TryParse(r, out rate);
            if (!isValidRate)
            {
                Console.WriteLine("Please enter correct input ");
            }
           
            Console.WriteLine("Enter the Time : ");
            var t = Console.ReadLine();
            decimal time;
            bool isValidTime = Decimal.TryParse(t, out time);


            if (!isValidTime)
            {
                Console.WriteLine("Please enter correct input ");
            }
            

            var simpleInterest = principal * rate * time / 100;

            Console.WriteLine("Simple Interest : " + simpleInterest);
            Console.ReadKey();
        }
    }
}
