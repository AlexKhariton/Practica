namespace practic.Data.Models
{
    public class Realtor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
