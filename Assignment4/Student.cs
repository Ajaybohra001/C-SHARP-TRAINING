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

        private List<Course> _courses;
        public Student()
        {
            Course c = new Course();
            c.courseId = 101;
            c.courseName = "MCA";
            c.courseCode = "MCA-SE";
            c.courseSubject = "Software Engineering";
            _courses.Add(c);
        }


        public List<Course> courses
        {
            get { return _courses; }

        }

        public void AddCourse(Course cour)
        {
            _courses.Add(cour);
        }

        public void RemoveCourse(Course cour)
        {
            _courses.Remove(cour);
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
