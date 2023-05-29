using practic.Data.Models;

namespace practic.ViewModels
{
    public class RealtorItemViewModel
    {
        public IEnumerable<Realtor> realtor { get; set; }
        public string currCategory { get; set; }
        public int id { get; set; }
    }
}
