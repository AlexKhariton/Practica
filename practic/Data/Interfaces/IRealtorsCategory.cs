using practic.Data.Models;

namespace practic.Data.Interfaces
{
    public interface IRealtorsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
