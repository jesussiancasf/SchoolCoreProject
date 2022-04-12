using System;
using System.Collections.Generic;

namespace SchoolsCore.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string ID { get; private set; }
        public List<Exam> ExamList { get; set; } = new List<Exam>();


        public Student() => ID = Guid.NewGuid().ToString();

    }
    
}
