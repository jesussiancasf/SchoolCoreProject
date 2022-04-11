namespace SchoolsCore.Models
{
    class School
    {
        private string name;

        public string Name
        {
            get { return name.ToUpper(); }
            set { name = value.ToUpper(); }
        }
        public int CreationYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolTypes SchoolTypes { get; set; }

        public Subject[] SchoolSujects { get; set; }


        public School(string name, int creationYear)
            => (this.name, CreationYear) = (name, creationYear);

        public School(
            string name,
            int creationYear,
            SchoolTypes schoolTypes,
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