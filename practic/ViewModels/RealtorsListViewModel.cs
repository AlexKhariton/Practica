using practic.Data.Models;

namespace practic.ViewModels
{
    public class RealtorsListViewModel
    {
        public IEnumerable<Realtor> AllRealtors {  get; set; }
        public string currCategory { get; set; }
        public int id { get; set; }
    }
}
