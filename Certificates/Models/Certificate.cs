namespace certificates.Models
{
    public class Certificate
    {
        private long _id;
        private string _name;
        private DateTime _finishDate;
        private string _code;

        public Certificate(string name, DateTime finishDate)
        {
            _name = name;
            _finishDate = finishDate;
        }

        public string Name { get => _name; set => _name = value; }
        public DateTime FinishDate { get => _finishDate; set => _finishDate = value; }
    }
}
