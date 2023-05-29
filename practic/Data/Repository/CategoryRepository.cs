using practic.Data.Interfaces;
using practic.Data.Models;

namespace practic.Data.Repository
{
    public class CategoryRepository : IRealtorsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
