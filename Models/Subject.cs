using System;
using System.Collections.Generic;

namespace SchoolsCore.Models
{
    public class Subject
    {
        public string Name { get; set; }
        public string ID { get; private set; }

        public List<Exam> SubjectExams { get; set; } = new List<Exam>();

        public Subject() => ID = Guid.NewGuid().ToString();

    }
}
