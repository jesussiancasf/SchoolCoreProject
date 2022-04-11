using System;

namespace SchoolsCore.Models
{
    class Subject
    {
        public string Name { get; set; }
        public string ID { get; private set; } 
        public Schedule Schedule  { get; set; }

        public Subject() =>ID = Guid.NewGuid().ToString();

        
        
    }
}
