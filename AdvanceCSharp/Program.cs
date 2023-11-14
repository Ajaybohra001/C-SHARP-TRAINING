using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public struct Books
    {
        private string _title;
        private string _author;
        private string _subject;
        private int _bookId;



        public Books(string title, string author, string subject, int bookId)
        {

            _title = title;
            _author = author;
            _subject = subject;
            _bookId = bookId;

        }
        //public Books()
        //{
        //    _author = "Test author";
        //    _subject = "Test Subject";

        //}

        public void PrintBook()
        {
            Console.WriteLine($" Book_id :{_bookId} \n Title:{_title}\n" +
                $"Author : {_author}");
        }
    }
        class Program
    {
       
        class ClassA
        {
            //public readonly string readOnlyVal = "only changed inside the constructor";
            //public readonly string readOnyVal1;
            //public const string constVal = "never ";
            //  public const string consval1;
            public static string staticVal = "value assigned";
            public static string staticVal1;

            public readonly static string staticReadOnlyVal= "Value can be assigned here";
            public readonly static string staticReadOnlyVal1;

            public ClassA()
            {
                //readOnlyVal = "readonly changed";
                //readOnyVal1 = "value assign";
                // constVal1 = "Change not allowed";
                staticVal = "Value can be changed here";
                staticVal1 = "value can be assigned here";
                //staticReadOnlyVal = " not allowed";
                //staticReadOnlyVal1 = " not allowed";

            }
            static  ClassA()
            {
                staticReadOnlyVal = " not allowed";
                staticReadOnlyVal1 = " not allowed";
            }
            public void method1()
            {
               // constVal = "hello";
            }
        }
      
       
        static void Main(string[] args)
        { Class1 c = new Class1();
            //Console.WriteLine(ClassA.constVal);
            //ClassA c = new ClassA();
            //Console.WriteLine(c.readOnyVal1);
            int v1 = (int)(Class1.LogTypes.Error);
            Console.WriteLine(v1);
            c.WriteLog("Msg",Class1.LogTypes.Error);

            Books b = new Books("Title", "author", "sub", 1);
            b.PrintBook();

            Console.ReadKey();
        }
    }
}
