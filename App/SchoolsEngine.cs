using SchoolsCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static SchoolsCore.Util.Generators;

namespace SchoolsCore
{
    class SchoolEngine
    {
        public School School { get; set; }

        public SchoolEngine()
        {

        }

        public void Inicializer()
        {
            School = new School
                ("Exitus",
                1985,
                SchoolType.KINDER_GARDEN,
                city: "Sullana",
                country: "Perú");

            LoadClassRooms();
            LoadSubjects();
            LoadExams();
            AssignExamsToStudents();
           // AssignScoreToStudentExams();

        }



        private void LoadSubjects()
        {
            foreach (var classRoon in School.ClassRooms)
            {
                List<Subject> SubjectList = new List<Subject>()
                {
                        new Subject{Name="Matemáticas"} ,
                        new Subject{Name="Educación Física"},
                        new Subject{Name="Castellano"},
                        new Subject{Name="Ciencias Naturales"}
                };

                classRoon.Subjects = SubjectList;
            }
        }


        private void LoadClassRooms()
        {
            School.ClassRooms = new List<ClassRoom>(){
                new ClassRoom {Name="101",Schedule=Schedule.MORNING},
                new ClassRoom {Name="201",Schedule=Schedule.MORNING},
                new ClassRoom {Name="301",Schedule=Schedule.MORNING},
                new ClassRoom {Name="401",Schedule=Schedule.AFTERNOON},
                new ClassRoom {Name="501",Schedule=Schedule.AFTERNOON},
                new ClassRoom {Name="601",Schedule=Schedule.NIGHT},
            };


            foreach (var classRoom in School.ClassRooms)
            {
                classRoom.Students = GenerateRandomlyStudents(RandomGenerator());
            }
        }

        private void LoadExams()
        {
            string[] exams = { "PC1", "PC2", "EP", "EF", "TE" };
            foreach (var classRoom in School.ClassRooms)
            {
                foreach (var subject in classRoom.Subjects)
                {
                    foreach (var examName in exams)
                    {
                        subject.SubjectExams.Add(new Exam { Name = examName, Subject = subject });
                    }

                }
            }

        }
        private void AssignExamsToStudents()
        {
            var arrTemp = new List<Exam>();
            foreach (var classRoom in School.ClassRooms)
            {
                foreach (var subject in classRoom.Subjects)
                {
                    arrTemp.AddRange(subject.SubjectExams);
                }
                foreach (var student in classRoom.Students)
                {
                    student.ExamList.AddRange(arrTemp);

                    foreach (var exam in student.ExamList)
                    {
                        exam.Score = (float)RandomGeneratorD();

                    }
                }
                arrTemp.Clear();

            }
        }

       /* private void AssignScoreToStudentExams()
        {

            foreach (var classRoom in School.ClassRooms)
            {

                foreach (var student in classRoom.Students)
                {
                    foreach (var exam in student.ExamList)
                    {
                        exam.Score = (float)RandomGeneratorD();

                    }

                }


            }
        }*/


    }
}