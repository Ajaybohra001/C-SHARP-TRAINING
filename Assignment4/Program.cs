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
            List<Student> _studentList = new List<Student>();

            int choice = -1;
            bool ch = true;
            //Student stud = new Student();


            do
            {
                Console.WriteLine();
                Console.WriteLine("1.Add Subject");
                Console.WriteLine("2.Add Course");
                Console.WriteLine("3. Add Student");
                Console.WriteLine("4.View All Subjects");
                Console.WriteLine("5.View All Courses");
                Console.WriteLine("6.View All Students");
                Console.WriteLine("7.Find Subject by Name/Code");
                Console.WriteLine("8.Find Course by Name/Code");
                Console.WriteLine("9.Find Student by Name/Code");

                Console.WriteLine("10.Exit");
                Console.WriteLine();


                bool t = true;
                while (t)
                {
                    Console.WriteLine("Enter the choice ");
                    var c = Console.ReadLine();
                    Console.WriteLine();
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
                        bool temp = false;
                        Course c = new Course();
                        while (!temp)
                        {
                            CourseSubject cs = new CourseSubject();
                            c.AddSubject(cs);

                            

                            here:
                            Console.WriteLine("Do you want to add more subject?");
                          
                            Console.WriteLine("Yes(Y/y) or No(N/n) ? ");
                           

                            string input = Console.ReadLine();
                            if (input.Equals("Y") || input.Equals( "y"))
                                continue;

                          else if ((input.Equals("N") || input.Equals("n")))
                            {
                                temp = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input !");
                                goto here;
                            }
                        }
                        Console.WriteLine("Subject added.");
                        break;



                    case 2:
                        bool temp1 = false;
                        Student s = new Student();
                        while (!temp1)
                        {
                            Course c1 = new Course();
                            s.AddCourse(c1);
                            Console.WriteLine("Do you want to add more Course?");
                            Console.WriteLine("Yes(Y/y) or No(N/n) ? ");
                            string str = Console.ReadLine();
                            if ((str.Equals("N") || str.Equals("n")))
                            {
                                temp = true;
                            }

                            Console.WriteLine("Course added.");
                            break;

                        }



                        break;

                    case 3:
                        Console.WriteLine("Enter the student id : ");
                        var sId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the studet name : ");
                        var sName = Console.ReadLine();

                        Console.WriteLine("Enter the student code : ");
                        var sCode = Console.ReadLine();

                        Console.WriteLine("Enter the student course : ");
                        var sCourse = Console.ReadLine();
                        Student s1 = new Student();
                        s1.studId = sId;
                        s1.studName = sName;
                        s1.studCode = sCode;
                        s1.studCourses = sCourse;

                        _studentList.Add(s1);

                        break;

                    case 4:


                        Console.WriteLine("List of all subjects:");
                        foreach (var i in Course.subjects)
                        {
                            Console.WriteLine("Subject id: {0} \n Subject name: {1} \n Subject code: {2} ", i.csId, i.csName, i.csCode);
                        }
                        break;

                    case 5:
                        Console.WriteLine("List of all Courses : ");
                        foreach (var i in Student.courses)
                        {
                            Console.WriteLine("Course id : {0} \n Course Name : {1} \n Course Code : {2} \n Course subject : {3}", i.courseId, i.courseName, i.courseCode, i.courseSubject, i.courseSubject);

                        }
                        break;
                    case 6:
                        Console.WriteLine("List of all Students : ");
                        foreach (var i in _studentList)
                        {
                            Console.WriteLine("Student id : {0} \n Student Name : {1} \n Student Code : {2} \n student course : {3}", i.studId, i.studName, i.studCode, i.studCourses);

                        }
                        break;
                    case 7:

                        List<CourseSubject> subjects = new List<CourseSubject>();
                        subjects.AddRange(Course.subjects);

                        Console.WriteLine("Enter the name or code of the subject to find:");
                        string searchTerm = Console.ReadLine();
                        var foundSubjects = subjects.FindAll(sub => sub.csName.Contains(searchTerm) || sub.csCode.Contains(searchTerm));
                        if (foundSubjects.Count > 0)
                        {
                            Console.WriteLine("Matching Subjects:");
                            foreach (var subject in foundSubjects)
                            {
                                Console.WriteLine($"Id: {subject.csId}, Name: {subject.csName}, Code: {subject.csCode}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No subjects found .");
                        }
                        break;

                    case 8:
                        List<Course> course = new List<Course>();
                        course.AddRange(Student.courses);
                        Console.WriteLine("Enter the name or code of the course to find:");
                        string searchTerm1 = Console.ReadLine();
                        var foundCourses = course.FindAll(co => co.courseName.Contains(searchTerm1) || co.courseCode.Contains(searchTerm1));
                        if (foundCourses.Count > 0)
                        {
                            Console.WriteLine("Matching Courses:");
                            foreach (var c1 in foundCourses)
                            {
                                Console.WriteLine($"Id: {c1.courseId}, Name: {c1.courseName}, Code: {c1.courseCode}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No courses found matching the search term.");
                        }
                        break;

                    case 9:
                        Console.WriteLine("Enter the name or code of the student to find:");
                        string searchTerm2 = Console.ReadLine();
                        var foundStudent = _studentList.FindAll(st => st.studName.Contains(searchTerm2) || st.studCode.Contains(searchTerm2));
                        if (foundStudent.Count > 0)
                        {
                            Console.WriteLine("Matching Courses:");
                            foreach (var i in foundStudent)
                            {
                                Console.WriteLine($"Id: {i.studId}, Name: {i.studName}, Code: {i.studCode}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No courses found matching the search term.");
                        }
                        break;




                    case 10:
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
