using FirstWebApi.Models;

namespace FirstWebApi.Data
{
    public class StudentStore
    {
        public static List<Student> studentList = new List<Student>()
        {
            new Student() { studentId=1,studentName="Ajay Bohra",studentAge=22 ,password="Successive"},
            new Student() { studentId=2,studentName="Prince",studentAge=21,confirmPassword="Successive"}
        };
    }
}
