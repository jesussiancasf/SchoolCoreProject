using SchoolsCore.Models;
using static SchoolsCore.Util.Printer;
using System;
using System.Collections.Generic;
using static System.Console;

namespace SchoolsCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var sEngine = new SchoolEngine();

            sEngine.Inicializer();
            WriteTitle("Bienvenidos");
            printSchoolSubjects(sEngine.School);


            //lambdas
            //sc.SchoolSujects.RemoveAll((subject) => subject.Name == "103");


        }


        private static void printSchoolSubjects(School sc)
        {
            WriteTitle($"{sc.Name} school Subjets:");

            if (sc?.SchoolSujects != null)
            {
                foreach (var cursos in sc.SchoolSujects)
                {
                    WriteLine($"{cursos.Name} - {cursos.ID}");
                }
            }

        }


    }
}
