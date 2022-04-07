using SchoolsCore.Models;
using System;

namespace SchoolsCore
{
    class Program
    {
        static void Main(string[] args)
        {
            School sc = new School("Exitus",1985,SchoolTypes.KINDER_GARDEN,city:"Sullana");
     
            Console.WriteLine(sc );
        }
    }
}
