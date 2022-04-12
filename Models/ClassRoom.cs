using System;

namespace SchoolsCore.Models
{
    class ClassRoom
    {
        public string Name { get; set; }
        public string ID { get; private set; } 
        public Schedule Schedule  { get; set; }

        public ClassRoom() =>ID = Guid.NewGuid().ToString();

        
        
    }
}
