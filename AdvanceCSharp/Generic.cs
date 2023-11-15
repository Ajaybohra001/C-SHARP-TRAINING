using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{
    //Base Class generic constraint
    public class BaseClass
    {
        public int  x=1;


    }

    //Base Class generic constraint

    public class TestGenericClass<T> where T : BaseClass
    {
        public T variable1;
        public T property1 { get; set; }

        public TestGenericClass(T value)
        {
            variable1 = value;
            property1 = value;
        }

      

        public T TestFunction(T param1)
        {
         
            Console.WriteLine("Parameter typer:{0},value:{1}", typeof(T).ToString(),param1);
            Console.WriteLine("Return type:{0},value :{1}", typeof(T).ToString(), variable1);
            return variable1;
        }
    }
    public class Compare
    {public bool IsEqual<T>(T x,T y)
        {
            return x.Equals(y);
        }
        static void Main(string[] args)
        {
            // Compare c = new Compare();
            //Console.WriteLine( c.IsEqual<string>("sd", "d"));
            // Console.WriteLine(c.IsEqual<int>(1, 1));
            BaseClass b = new BaseClass();
            TestGenericClass<BaseClass> Test = new TestGenericClass<BaseClass>(b);

            Console.WriteLine(Test.GetType());
            Console.WriteLine(Test.variable1.GetType());
           

            //  Test.TestFunction(3);
            Console.ReadKey();
        }
    }
}
