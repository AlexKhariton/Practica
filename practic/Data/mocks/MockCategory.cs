using practic.Data.Interfaces;
using practic.Data.Models;

namespace practic.Data.mocks
{
    public class MockCategory : IRealtorsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryname = "Премиум", desc = "Дорого богато"},
                    new Category {categoryname = "Стандарт", desc = "Цена = качество"},
                };
            }
        }
    }
}
