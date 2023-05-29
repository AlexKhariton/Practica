using Microsoft.AspNetCore.Mvc;
using practic.Data.Interfaces;
using practic.ViewModels;

namespace practic.Controllers
{
    public class HomeController : Controller
    {
        private IAllRealtors _realRep;
        private readonly Service service;
        public HomeController(IAllRealtors realRep, Service service)
        {
            _realRep = realRep;
            this.service = service;
        }

        public ViewResult Index()
        {
            var homeRealtors = new HomeViewModel
            {
                realtors = _realRep.Realtors
            };
            return View(homeRealtors);
        }
        public ViewResult Mail()
        {
            return View();
        }
        public IActionResult SendEmail(string name, string longDesc, string email)
        {
            service.SendEmail(name, longDesc, email);
            return RedirectToAction("Mail");
        }
        public ViewResult agree()
        {
            return View();
        }
    }
}
