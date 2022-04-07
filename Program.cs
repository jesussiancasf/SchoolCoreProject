using SchoolsCore.Models;
using System;

namespace SchoolsCore
{
    class Program
    {
        static void Main(string[] args)
        {
            School sc = new School("Exitus",1985);
            sc.Country = "Perú";
            sc.City = "Sullana";
            sc.SchoolTypes = SchoolTypes.KINDER_GARDEN;

            Console.WriteLine(sc );
        }
    }
}
