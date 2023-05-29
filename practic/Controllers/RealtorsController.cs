using Microsoft.AspNetCore.Mvc;
using practic.Data.Interfaces;
using practic.Data.Models;
using practic.ViewModels;

namespace practic.Controllers
{
    public class RealtorsController : Controller
    {
        private readonly IAllRealtors _allRealtors;
        private readonly IRealtorsCategory _allCategories;

        public RealtorsController(IAllRealtors iallRealtors, IRealtorsCategory iallCategories)
        {
            _allCategories = iallCategories;
            _allRealtors = iallRealtors;
        }
        [Route("Realtors/List")]
        [Route("Realtors/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Realtor> realtors = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(_category))
            {
                realtors = _allRealtors.Realtors.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("premium", category, StringComparison.OrdinalIgnoreCase))
                {
                    realtors = _allRealtors.Realtors.Where(i => i.Category.categoryname.Equals("Премиум")).OrderBy(i => i.id);
                    currCategory = "Премиум сегмент";
                }
                else if (string.Equals("standart", category, StringComparison.OrdinalIgnoreCase))
                {
                    realtors = _allRealtors.Realtors.Where(i => i.Category.categoryname.Equals("Стандарт")).OrderBy(i => i.id);
                    currCategory = "Стандартный сегмент";
                }
            }
            var realObj = new RealtorsListViewModel
            {
                AllRealtors = realtors,
                currCategory = currCategory,
            };
            return View(realObj);
        }
        [Route("Realtors/Item/{id}")]
        [Route("Realtors/Item/{category}/{id}")]
        public ViewResult Item(int id)
        {

            var realObj = new RealtorItemViewModel
            {
                realtor = _allRealtors.Realtors.Where(p => p.id == id).ToList(),
                id = id
            };
            return View(realObj);
        }
    }
}
