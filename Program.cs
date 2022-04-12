using SchoolsCore.Models;
using System;
using System.Collections.Generic;
using static System.Console;

namespace SchoolsCore
{
    class Program
    {
        static void Main(string[] args)
        {
            School sc = new School("Exitus", 1985, SchoolTypes.KINDER_GARDEN, city: "Sullana", country: "Perú");


            sc.SchoolSujects = new List<Subject>(){
                new Subject() {Name="101"},
                new Subject() {Name="102"},
                new Subject() {Name="103"}
            };


            printSchoolSubjects(sc);
            //Manera Larga
            sc.SchoolSujects.RemoveAll(Predicates);

            //manera simplificada
            sc.SchoolSujects.RemoveAll(delegate (Subject subject)
            {
                return subject.Name=="102";
            });


            //lambdas
            sc.SchoolSujects.RemoveAll((subject) => subject.Name == "103");


            printSchoolSubjects(sc);

        }

        private static bool Predicates(Subject obj)
        {
            return obj.Name == "101";
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
