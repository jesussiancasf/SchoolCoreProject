using System;
using System.Collections.Generic;

namespace SchoolsCore.Models
{
    public class ClassRoom
    {
        public string Name { get; set; }
        public string ID { get; private set; } 
        public Schedule Schedule  { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }
        public ClassRoom() =>ID = Guid.NewGuid().ToString();

        
        
    }
}
