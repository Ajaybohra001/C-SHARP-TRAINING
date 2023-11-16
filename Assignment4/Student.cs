using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Student
    {
        public int studId { get; set; }
        public string studName { get; set; }
        public string studCode { get; set; }
        public string studCourses { get; set; }

        private static List<Course> _courses = new List<Course>();
        // public static List<Student>_studentList = new List<Student>();

        public Student()
        {
            Course c = new Course();
            c.courseId = 101;
            c.courseName = "MCA";
            c.courseCode = "MCA-SE";
            c.courseSubject = "Software Engineering";
            _courses.Add(c);
        }

        public static List<Course> courses
        {
            get { return _courses; }

        }

        public void AddCourse(Course course)
        {
            
            bool ch = true;
            int id = -1 ;

            while (ch)
            {
                Console.WriteLine("Enter the Course id");
                var testId = Console.ReadLine();

                bool successive = int.TryParse(testId, out id);
                if (!successive)
                {
                    Console.WriteLine("Please enter the valid input.");
                    
                }
                else
                {
                    ch = false;
                }
                

            }
            course.courseId =id;

            string name = "";
            Console.WriteLine("Enter Course Name");
            name = Console.ReadLine();
            while (name.Length == 0)
            {
                Console.WriteLine("Please enter the valid input.");
                name = Console.ReadLine();
            }
            course.courseName = name;

            string code = "";
            Console.WriteLine("Enter Course Code");
            code = Console.ReadLine();
            while (code.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                code = Console.ReadLine();
            }
            course.courseCode = code;



            string subject = "";
            Console.WriteLine("Enter Course Subject Name");
            subject = Console.ReadLine();
            while (subject.Length == 0)
            {
                Console.WriteLine("Please enter the valid input.");
                name = Console.ReadLine();
            }
            course.courseSubject = subject;


            _courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            _courses.Remove(course);
        }

        public void AddCourse(List<Course> cour)
        {
            _courses.AddRange(cour);
        }

        public static void StudentData()
        {
            Student s = new Student();
            Console.WriteLine("Enter the Id of Student : ");
            s.studId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the student name : ");
            s.studName = Console.ReadLine();

            Console.WriteLine("Enter the Student course: ");
            s.studCourses = Console.ReadLine();

            Console.WriteLine("Enter the Student code: ");
            s.studCode = Console.ReadLine();


        }
    }
}
