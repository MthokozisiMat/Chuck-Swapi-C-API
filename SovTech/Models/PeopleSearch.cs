namespace SovTech.Models
{
    public class PeopleSearch
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public  List<People> Result { get; set; }
    }
}
