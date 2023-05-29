namespace practic.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryname { get; set; }
        public string desc { get; set; }
        public List<Realtor> realtors { get; set; }

    }
}
