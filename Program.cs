using SchoolsCore.Models;
using System;
using static System.Console;

namespace SchoolsCore
{
    class Program
    {
        static void Main(string[] args)
        {
            School sc = new School("Exitus",1985,SchoolTypes.KINDER_GARDEN,city:"Sullana", country:"Perú");

            sc.SchoolSujects =new Subject[]{
                new Subject() {Name="101"},
                new Subject() {Name="102"},
                new Subject() {Name="103"}
        };

            int a = 3;
            int b = 5;
            int c = 4;

            int v = a > b ? a : c;

            WriteLine(v);
           // printSchoolSubjects(sc);

        }

        private static void printSchoolSubjects(School sc)
        {
            WriteLine("-----------");
            WriteLine($"{sc.Name} school Subjets:");
            WriteLine("-----------");

            if (sc?.SchoolSujects != null) { 
            foreach (var cursos in sc.SchoolSujects)
            {
                WriteLine($"{cursos.Name} - {cursos.ID}");
            }
            }

        }

        private static void printSubjectForEach(Subject[] subjectsAray)
        {
            foreach (var item in subjectsAray)
            {
                WriteLine($"{item.Name} - {item.ID}");
            }
        }
    }
}
