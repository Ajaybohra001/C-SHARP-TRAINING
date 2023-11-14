using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Course :CourseSubject
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public string courseCode { get; set; }
        public string courseSubject { get; set; }

        private static List<CourseSubject> _subjects= new List<CourseSubject>();
        public Course()
        {
            CourseSubject c = new CourseSubject();
            c.csId = 001;
            c.csName = "Computer Science";
            c.csCode = "compsci";
            _subjects.Add(c);


        }
        public static List<CourseSubject> subjects
        {
            get { return _subjects; }

        }

        public void AddSubject(CourseSubject subject)
        {
            string id = "";
            int final_id = 0;
            Console.WriteLine("Enter Subject id");
            id = Console.ReadLine();
            while (id.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                id = Console.ReadLine();
            }
            while (!int.TryParse(id, out final_id))
            {
                Console.WriteLine("Invalid input,Please enter again");
                id = Console.ReadLine();
            }
            subject.csId = final_id;

            string code = "";
            Console.WriteLine("Enter Subject Code");
            code = Console.ReadLine();
            while (code.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                code = Console.ReadLine();
            }
            subject.csCode = code;

            string name = "";
            Console.WriteLine("Enter Subject Name");
            name = Console.ReadLine();
            while (name.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                name = Console.ReadLine();
            }
            subject.csName = name;
            
            _subjects.Add(subject);
        }

        public void RemoveSubject(CourseSubject subject)
        {
            _subjects.Remove(subject);
        }

        public void AddSubject(List<CourseSubject> subject)
        {
            _subjects.AddRange(subject);
        }

        
        
    }
}
