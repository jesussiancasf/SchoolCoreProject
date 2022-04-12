using System;
using System.Collections.Generic;


namespace SchoolsCore.Models
{
    public class Exam
    {
        public string Name { get; set; }
        public string ID { get; private set; }


        public Subject Subject { get; set; }
        public float Score { get; set; } = 0.0f;
        public Exam() => ID = Guid.NewGuid().ToString();
    }
}
