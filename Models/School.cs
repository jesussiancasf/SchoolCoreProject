namespace SchoolsCore.Models
{
    class School
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }
        public int CreationYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolTypes SchoolTypes { get; set; }


        public School(string name, int creationYear)
            => (this.name, CreationYear) = (name, creationYear);

        public override string ToString()
        {
            return $"Nombre: {Name}\nTipo de Escuela: {SchoolTypes}\nAño de Creadción: {CreationYear}\nPais: {Country}\nCiudad: {City}";
        }
    }
}