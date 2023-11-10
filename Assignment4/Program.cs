using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            bool ch = true;
            Course course = new Course();
            Student stud = new Student();


            do
            {
                Console.WriteLine("1.Add Subject");
                Console.WriteLine("2.Add Course");
                Console.WriteLine("3.View All Subjects");
                Console.WriteLine("4.View All Courses");
                Console.WriteLine("5.View All Students");
                Console.WriteLine("6.Find Subject by Name/Code");
                Console.WriteLine("7.Find Course by Name/Code");
                Console.WriteLine("8.Find Student by Name/Code");
                Console.WriteLine("9.Find Subject by Name/Code");
                Console.WriteLine("10.Exit");
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
                        
                        Console.WriteLine("Enter the course subject Id : ");
                       var id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the Course subject name : ");
                         var name = Console.ReadLine();

                        Console.WriteLine("Enter the Course subject code : ");
                        var code = Console.ReadLine();

                        

                        CourseSubject cs = new CourseSubject();
                        cs.csId = id;
                        cs.csName = name;
                        cs.csCode = code;
                        
                        course.AddSubject(cs);


                        break;
                    case 2:
                        Console.WriteLine("Enter the course subject Id : ");
                        var id1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the Course subject name : ");
                        var name1 = Console.ReadLine();

                        Console.WriteLine("Enter the Course subject code : ");
                        var code1 = Console.ReadLine();
                        CourseSubject cs1 = new CourseSubject();
                        cs1.csId = id1;
                        cs1.csName = name1;
                        cs1.csCode = code1;

                        course.RemoveSubject(cs1);



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
        }
    }
}
