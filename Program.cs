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
            PrintStudentsSubjectAndExams(sEngine.School);


            //lambdas
            //sc.SchoolSujects.RemoveAll((subject) => subject.Name == "103");


        }


        private static void printClassRoomsSubjectsAndExams(School sc)
        {
            WriteTitle($"{sc.Name} school Subjets:");

            if (sc?.ClassRooms != null)
            {
                foreach (var classRoom in sc.ClassRooms)
                {
                    WriteTitle($"ClassRoom {classRoom.Name}");

                    foreach (var subject in classRoom.Subjects)
                    {
                        WriteLine();

                        WriteTitle($"{classRoom.Subjects.IndexOf(subject) + 1})  {subject.Name} - {subject.ID}");


                        foreach (var exams in subject.SubjectExams)
                        {
                            WriteLine($"Eval {subject.SubjectExams.IndexOf(exams) + 1})  {exams.Name} - {exams.ID}");
                        }
                    }

                    WriteLine();
                }
            }

        }


        private static void PrintStudentsSubjectAndExams(School sc)
        {
            WriteTitle($"{sc.Name} school Subjets:");

            if (sc?.ClassRooms != null)
            {
                foreach (var classRoom in sc.ClassRooms)
                {
                    WriteTitle($"ClassRoom {classRoom.Name}");

                    foreach (var student in classRoom.Students)
                    {
                        WriteLine();

                        WriteLine($"{classRoom.Students.IndexOf(student) + 1})  {student.Name} - {student.ID}");

                        

                        foreach (var exam in student.ExamList)
                        {
                            WriteLine($" {exam.Name} - NOTA: {exam.Score}");
                        }


                    }

                    WriteLine();

                }


            }
        }
    }
}
