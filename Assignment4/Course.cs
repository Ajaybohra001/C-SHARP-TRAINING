using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public string courseCode { get; set; }
        public string courseSubject { get; set; }

        private List<CourseSubject> _subjects;
        public Course()
        {
            CourseSubject c = new CourseSubject();
            c.csId=001;
            c.csName = "Computer Science";
            c.csCode = "compsci";
            _subjects.Add(c);


        }
        public List<CourseSubject> subjects
        {
            get { return _subjects; }

        }

        public void AddSubject(CourseSubject subject)
        {
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
