using SchoolsCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolsCore.Util
{
    public static class Generators
    {
        public static int RandomGenerator(int rangeX = 10, int rangeY = 20)
        {
            Random rnd = new Random();
            return rnd.Next(rangeX, rangeY);

        }

        public static double RandomGeneratorD(int range=20)
        {
            Random rnd = new Random();
            return rnd.NextDouble()*20;

        }



        public static List<Student> GenerateRandomlyStudents(int quantity)
        {
            string[] firstName = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] lastName = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] middleName = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var studentsList = from fn in firstName
                               from mn in middleName
                               from ln in lastName
                               select new Student { Name = $"{fn} {mn} {ln}" };

            return studentsList.OrderBy((student) => student.ID).Take(quantity).ToList();


        }

  
    }
}
