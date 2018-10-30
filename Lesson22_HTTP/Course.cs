using System.Collections.Generic;

namespace Lesson22_HTTP
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Student> Students { get; set; }
    }


    public class Student
    {
        public int Id { get; set; }
        Course Course { get; set; }
    }
}