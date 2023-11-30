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
        public int courseId { get; set; }

    }
    public class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }

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
            
            //Console.WriteLine("Count of number : " + number.Count());
            //Console.WriteLine();

            //Max
            //Console.WriteLine("Maximum number : " + number.Max());
            //Console.WriteLine();

            //Max
            //Console.WriteLine("Minimum number : " + number.Min());
            //Console.WriteLine();

            //Average
            //Console.WriteLine("Average of number : " + number.Average());
            //Console.WriteLine();

            //Sum
            //Console.WriteLine("Sum of number : " + number.Sum());

            //Console.WriteLine();


            //Where
            //Console.WriteLine("Where example : ");
            //Console.WriteLine();


            //var num =number.Where(n => n > 5);

            //foreach(var i in num)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            //OfType
            //Console.WriteLine("OfType example : ");
            //Console.WriteLine();

            //var type = arrayList.OfType<string>();
            //foreach (var i in type)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            //OrderBy
            //Console.WriteLine("OrderBy example : ");
            //Console.WriteLine();

            //var orderBy = number.OrderBy(s=> s);
            //foreach (var i in orderBy)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();


            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Ajay", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Akshsy",  Age = 15 } ,
                new Student() { StudentID = 5, StudentName = "Prince" , Age = 25 },

                new Student() { StudentID = 3, StudentName = "Govind",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Utkarsh" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Prince" , Age = 19 }

            };

            //var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

            //var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);


            //Console.WriteLine("Ascending Order:");

            //foreach (var std in studentsInAscOrder)
            //    Console.WriteLine(std.StudentName);
            //Console.WriteLine();

            //Console.WriteLine("Descending Order:");

            //foreach (var std in studentsInDescOrder)
            //    Console.WriteLine(std.StudentName);
            //Console.WriteLine();


            //ThenBy
            //Console.WriteLine("ThenBy example : ");

            //var studThenBy = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
            //foreach (var std in studThenBy)
            //    Console.WriteLine(std.StudentName);
            //Console.WriteLine();

            //ThenByDesc
            //Console.WriteLine("ThenByDescending example : ");
            //var studThenByDes = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
            //foreach (var std in studThenBy)
            //    Console.WriteLine(std.StudentName);
            //Console.WriteLine();

            //Contains
            //Console.WriteLine("Contains example : ");
            //bool check = number.Contains(10);

            //Console.WriteLine(check);

            //First and FirstOrDefault

            //List<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            //List<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            //List<string> emptyList = new List<string>();

            //Console.WriteLine("1st Element in intList: {0}", intList.First());
            //Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));

            //Console.WriteLine("1st Element in strList: {0}", strList.First());


            //Console.WriteLine("Default value : " + emptyList.FirstOrDefault());

            //Last and LastOrDefault

            //Console.WriteLine("1st Element in intList: {0}", intList.LastOrDefault(i=> i==37));
            //Console.WriteLine("1st Even Element in intList: {0}", intList.Last(i => i % 2 == 0));

            //Console.WriteLine("1st Element in strList: {0}", strList.Last());


            //Console.WriteLine("Default value : " + emptyList.LastOrDefault());

            //Single and SingleOrDefault

            // List<int> singleElementList = new List<int>() { 12 };
            //Console.WriteLine("Single Element : " + singleElementList.Single());

            // Console.WriteLine("SingleOrDefault Element " + singleElementList.SingleOrDefault());

            //Skip and SkipWhile
            // var skpList = intList.Skip(2);

            //foreach(var i in skpList)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Skip while list ");
            //var skpWhileList = intList.SkipWhile(i => i < 10);

            //foreach(var i in skpWhileList)
            //{
            //    Console.WriteLine(i);
            //}

            // Console.WriteLine();

            //Take and TakeWhile

            //var takeList = intList.Take(4);

            //foreach (var i in takeList)
            //    Console.WriteLine("Top four element of integer list : " + i);


            //Console.WriteLine();

            //var takeWhileList = intList.TakeWhile(n => n < 20);

            //foreach (var i in takeWhileList)
            //    Console.WriteLine( i);

            //SELECT 

            //var result = studentList.Select(s => s.StudentName);
            //foreach (var i in result)
            //    Console.WriteLine(i);
            //Console.WriteLine();

            //All

            //bool studentAge = studentList.All(s => s.Age > 13 && s.Age < 19);
            //Console.WriteLine("The age of student is between 13 and 19 : " + studentAge);

            //Any
            //bool checkAny = studentList.Any(s => s.Age > 13 && s.Age < 20);
            //Console.WriteLine("Check the age is bw 13 and 20 : {0}", checkAny);

            //Concat

            //List<int> integer1List = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            //List<int> integer2List = new List<int>() { 7,8, 9, 10 };

            //var concatList = integer1List.Concat(integer2List);

            //foreach (var i in concatList)
            //{
            //    Console.WriteLine(i);
            //}

            //Distinct

            //List<int> duplicateList = new List<int>() { 1, 2, 3, 2, 4, 3, 5, 6, 6 };
            //var distinctList = duplicateList.Distinct();

            //foreach (var i in distinctList)
            //{
            //    Console.WriteLine(i);
            //}

            //Except

            //List<string> list1 = new List<string>() {"one","two","three","four"};
            //List<string> list2 = new List<string>() {"two","three"};

            //var exceptList = list1.Except(list2).Aggregate((s1, s2) => s1 + "," + s2);

            //foreach (var i in exceptList)
            //    Console.Write( i);


            //List<Student> studentList1 = new List<Student>() {   new Student() { StudentID = 1, StudentName = "Ajay", Age = 18 } ,
            //                                                     new Student() { StudentID = 2, StudentName = "Akshsy",  Age = 15 } ,
            //                                                     new Student() { StudentID = 5, StudentName = "Prince" , Age = 25 },

            //                                                     new Student() { StudentID = 3, StudentName = "Govind",  Age = 25 } ,
            //                                                     new Student() { StudentID = 4, StudentName = "Utkarsh" , Age = 20 } ,
            //                                                     new Student() { StudentID = 5, StudentName = "Prince" , Age = 19 }
            //                                                  };


            //List<Student> studentList2 = new List<Student>()
            //{
            //     new Student() { StudentID = 5, StudentName = "Prince" , Age = 19 },
            //      new Student() { StudentID = 3, StudentName = "Govind",  Age = 25 } ,
            //      new Student() { StudentID = 4, StudentName = "Utkarsh" , Age = 20 } 
            //};

            //var exceptResult = studentList1.Except(studentList2, new StudentComparer());

            //foreach (var i in exceptResult)
            //    Console.WriteLine(i.StudentName);

            //Intersect
            //List<int> intersectList1 = new List<int>{ 1, 2, 3, 4, 5 };
            //List<int> intersectList2 = new List<int> { 2, 3, 4 };

            //var intersecList = intersectList1.Intersect(intersectList2);

            //foreach(var i in intersecList)
            //{
            //    Console.WriteLine(i);
            //}

            //Union

            //List<int> unionList1 = new List<int> { 1, 2, 3, 4, 5 };

            //List<int> unionList2 = new List<int> { 2, 3, 4 };

            //var unionList = unionList1.Union(unionList2);

            //foreach (var i in unionList)
            //{
            //    Console.WriteLine(i);
            //}

            //Join

            //List<Student> stud = new List<Student>()
            //{
            //    new Student() { StudentID = 1, StudentName = "Ajay", Age = 18,courseId=101 } ,
            //    new Student() { StudentID = 2, StudentName = "Akshsy",  Age = 15,courseId=102 } ,
            //    new Student() { StudentID = 5, StudentName = "Prince" , Age = 25,courseId=103 },

            //    new Student() { StudentID = 3, StudentName = "Govind",  Age = 25 ,courseId=104} ,
            //    new Student() { StudentID = 4, StudentName = "Utkarsh" , Age = 20,courseId=105 } ,
            //    new Student() { StudentID = 5, StudentName = "Prince" , Age = 19,courseId=106 }
            //};

            //List<Course> course = new List<Course>()
            //{
            //    new Course(){courseId=101,courseName="MCA"},
            //    new Course(){courseId=102,courseName="Btech"}
            //};

            //var joinResult = stud.Join(course,
            //                            student=>student.courseId,c=>c.courseId,
            //                            (student, c) => new
            //                            {
            //                                studentName=student.StudentName,
            //                                course=c.courseName
            //                            }


            //    );

            //foreach(var i in joinResult)
            //{
            //    Console.WriteLine("Student Name : {0} Course Name : {1}", i.studentName, i.course);
            //}

            //Deferred

            //List<Student> stud = new List<Student>()
            //{
            //    new Student() { StudentID = 1, StudentName = "Ajay", Age = 18,courseId=101 } ,
            //    new Student() { StudentID = 2, StudentName = "Akshsy",  Age = 15,courseId=102 } ,
            //    new Student() { StudentID = 5, StudentName = "Prince" , Age = 25,courseId=103 },

            //    new Student() { StudentID = 3, StudentName = "Govind",  Age = 25 ,courseId=104} ,
            //    new Student() { StudentID = 4, StudentName = "Utkarsh" , Age = 20,courseId=105 } ,
            //    new Student() { StudentID = 5, StudentName = "Prince" , Age = 19,courseId=106 }
            //};

            //var checkAge = stud.Where(s => s.Age < 20);

            //stud.Add(new Student() { StudentID = 6, StudentName = "Ram", Age = 10, courseId = 107 });

            //foreach(var i in checkAge)
            //Console.WriteLine(i.StudentName);

            //Immediate

            //List<Student> stud = new List<Student>()
            //{
            //    new Student() { StudentID = 1, StudentName = "Ajay", Age = 18,courseId=101 } ,
            //    new Student() { StudentID = 2, StudentName = "Akshsy",  Age = 15,courseId=102 } ,
            //    new Student() { StudentID = 5, StudentName = "Prince" , Age = 25,courseId=103 },

            //    new Student() { StudentID = 3, StudentName = "Govind",  Age = 25 ,courseId=104} ,
            //    new Student() { StudentID = 4, StudentName = "Utkarsh" , Age = 20,courseId=105 } ,
            //    new Student() { StudentID = 5, StudentName = "Prince" , Age = 19,courseId=106 }
            //};

            //var checkAge = stud.Where(s => s.Age < 20).ToList();

            //stud.Add(new Student() { StudentID = 6, StudentName = "Ram", Age = 10, courseId = 107 });

            //foreach (var i in checkAge)
            //    Console.WriteLine(i.StudentName);

            //Groupby

            List<Student> stud = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "Ajay", Age = 18,courseId=101 } ,
                new Student() { StudentID = 2, StudentName = "Akshsy",  Age = 15,courseId=102 } ,
                new Student() { StudentID = 5, StudentName = "Prince" , Age = 18,courseId=103 },

                new Student() { StudentID = 3, StudentName = "Govind",  Age = 15 ,courseId=104} ,
                new Student() { StudentID = 4, StudentName = "Utkarsh" , Age = 20,courseId=105 } ,
                new Student() { StudentID = 5, StudentName = "Prince" , Age = 20,courseId=106 }
            };

            //var groupedResult = stud.GroupBy(s=>s.Age);
       
            //foreach (var ageGroup in groupedResult)
            //{
            //    Console.WriteLine("Age Group: {0}", ageGroup.Key); 

            //    foreach (Student s in ageGroup) 
            //        Console.WriteLine("Student Name: {0}", s.StudentName);
            //}

            //Lookup

            //var lookUpResult = stud.ToLookup(s => s.Age);

            //foreach (var ageGroup in lookUpResult)
            //{
            //    Console.WriteLine("Age Group: {0}", ageGroup.Key);

            //    foreach (Student s in ageGroup)
            //        Console.WriteLine("Student Name: {0}", s.StudentName);
            //}

            //ElementAt and ElementAtOrDefault

            List<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            List<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };

            Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
            Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

            Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
            Console.WriteLine("2nd Element in strList: {0}", strList.ElementAt(1));

            Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(10));
            Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));
















            Console.ReadKey();

        

        }
        class StudentComparer : IEqualityComparer<Student>
        {
            public bool Equals(Student x, Student y)
            {
                if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
                    return true;

                return false;
            }

            public int GetHashCode(Student obj)
            {
                return obj.StudentID.GetHashCode();
            }
        }
    }
}
