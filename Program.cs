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
            var sEngine = new SchoolEngine();

            sEngine.Inicializer();
            printSchoolSubjects(sEngine.School);
       

            //lambdas
            //sc.SchoolSujects.RemoveAll((subject) => subject.Name == "103");



        }



        private static void printSchoolSubjects (School sc)
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

        
    }
}
