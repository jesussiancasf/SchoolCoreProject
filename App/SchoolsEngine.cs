using SchoolsCore.Models;
using System.Collections.Generic;

namespace SchoolsCore
{
    class SchoolEngine
    {
        public School School { get; set; }

        public SchoolEngine()
        {
            School = new School
                ("Exitus", 
                1985, 
                SchoolTypes.KINDER_GARDEN, 
                city: "Sullana", 
                country: "Perú");
        }

        public void Inicializer()
        {
            School.SchoolSujects= new List<Subject>(){
                new Subject {Name="101",Schedule=Schedule.MORNING},
                new Subject {Name="201",Schedule=Schedule.MORNING},
                new Subject {Name="301",Schedule=Schedule.MORNING},
                new Subject {Name="401",Schedule=Schedule.AFTERNOON},
                new Subject {Name="501",Schedule=Schedule.AFTERNOON},
                new Subject {Name="601",Schedule=Schedule.NIGHT},
            };
        }

    }
}