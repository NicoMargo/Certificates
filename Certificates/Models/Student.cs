namespace certificates.Models
{
    public class Student
    {
        private long _id;
        private string _name;
        private string _surname;
        private string _code;
        private List<Certificate> _certificates;
        private Certificate _certificate;



        public Student(string name, string surname, Certificate certificate)
        {
            _name = name;
            _surname = surname;
            _certificate = certificate;
        }

        public long Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public List<Certificate> Certificates { get => _certificates; set => _certificates = value; }
        public string Code { get => _code; set => _code = value; }
        public Certificate Certificate { get => _certificate; set => _certificate = value; }
    }
}
