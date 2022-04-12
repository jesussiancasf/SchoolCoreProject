using System;
using System.Collections.Generic;

namespace SchoolsCore.Models
{
    class School
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        private string name;

        public string Name
        {
            get { return name.ToUpper(); }
            set { name = value.ToUpper(); }
        }
        public int CreationYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolType SchoolTypes { get; set; }

        public List<ClassRoom> ClassRooms { get; set; }


        public School(string name, int creationYear)
            => (this.name, CreationYear) = (name, creationYear);

        public School(
            string name,
            int creationYear,
            SchoolType schoolTypes,
            string country="",
            string city="")

            => (this.name, CreationYear,this.SchoolTypes,Country,City) 
            = (name, creationYear,schoolTypes,country,city);

        public override string ToString()
        {
            return $"Nombre: {Name}\nTipo de Escuela: {SchoolTypes}\nAño de Creadción: {CreationYear}\nPais: {Country}\nCiudad: {City}";
        }
    }
}