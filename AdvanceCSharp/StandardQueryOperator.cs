using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardQueryOperators
{
    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }
    class Program
    {
       
        
        static void Main(string[] args)
        {
        List<int> number = new List<int>() { 1, 2, 9,5,3,45,8 };
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Ajay");
            arrayList.Add('d');
            arrayList.Add(5);

            //Count
            
            Console.WriteLine("Count of number : " + number.Count());
            Console.WriteLine();

            //Max
            Console.WriteLine("Maximum number : " + number.Max());
            Console.WriteLine();

            //Max
            Console.WriteLine("Minimum number : " + number.Min());
            Console.WriteLine();

            //Average
            Console.WriteLine("Average of number : " + number.Average());
            Console.WriteLine();

            //Sum
            Console.WriteLine("Sum of number : " + number.Sum());

            Console.WriteLine();


            //Where
            Console.WriteLine("Where example : ");
            Console.WriteLine();


            var num =number.Where(n => n > 5);

            foreach(var i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //OfType
            Console.WriteLine("OfType example : ");
            Console.WriteLine();

            var type = arrayList.OfType<string>();
            foreach (var i in type)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //OrderBy
            Console.WriteLine("OrderBy example : ");
            Console.WriteLine();

            var orderBy = number.OrderBy(s=> s);
            foreach (var i in orderBy)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Ajay", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Akshsy",  Age = 15 } ,
                new Student() { StudentID = 5, StudentName = "Prince" , Age = 25 },

                new Student() { StudentID = 3, StudentName = "Govind",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Utkarsh" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Prince" , Age = 19 }

            };

            var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

            var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);


            Console.WriteLine("Ascending Order:");

            foreach (var std in studentsInAscOrder)
                Console.WriteLine(std.StudentName);
            Console.WriteLine();

            Console.WriteLine("Descending Order:");

            foreach (var std in studentsInDescOrder)
                Console.WriteLine(std.StudentName);
            Console.WriteLine();


            //ThenBy
            Console.WriteLine("ThenBy example : ");

            var studThenBy = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
            foreach (var std in studThenBy)
                Console.WriteLine(std.StudentName);
            Console.WriteLine();

            //ThenByDesc
            Console.WriteLine("ThenByDescending example : ");
            var studThenByDes = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
            foreach (var std in studThenBy)
                Console.WriteLine(std.StudentName);
            Console.WriteLine();

            //Contains
            Console.WriteLine("Contains example : ");
            bool check = number.Contains(10);

            Console.WriteLine(check);

            //First and FirstOrDefault

            List<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            List<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            List<string> emptyList = new List<string>();

            Console.WriteLine("1st Element in intList: {0}", intList.First());
            Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));

            Console.WriteLine("1st Element in strList: {0}", strList.First());


            Console.WriteLine("Default value : " + emptyList.FirstOrDefault());

            //Last and LastOrDefault

            Console.WriteLine("1st Element in intList: {0}", intList.LastOrDefault(i=> i==37));
            Console.WriteLine("1st Even Element in intList: {0}", intList.Last(i => i % 2 == 0));

            Console.WriteLine("1st Element in strList: {0}", strList.Last());


            Console.WriteLine("Default value : " + emptyList.LastOrDefault());

            //Single and SingleOrDefault

            List<int> singleElementList = new List<int>() { 12 };
           Console.WriteLine("Single Element : " + singleElementList.Single());

            Console.WriteLine("SingleOrDefault Element " + singleElementList.SingleOrDefault());

            //Skip and SkipWhile
            var skpList = intList.Skip(2);

            foreach(var i in skpList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Skip while list ");
            var skpWhileList = intList.SkipWhile(i => i < 10);

            foreach(var i in skpWhileList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //Take and TakeWhile

            var takeList = intList.Take(4);

            foreach (var i in takeList)
                Console.WriteLine("Top four element of integer list : " + i);


            Console.WriteLine();

            var takeWhileList = intList.TakeWhile(n => n < 20);

            foreach (var i in takeWhileList)
                Console.WriteLine( i);






            Console.ReadKey();

        

        }
    }
}
