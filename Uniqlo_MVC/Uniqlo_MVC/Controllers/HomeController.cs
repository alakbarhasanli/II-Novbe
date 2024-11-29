using Microsoft.AspNetCore.Mvc;
using Uniqlo_MVC.Contexts;

namespace Uniqlo_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly UniqloDbContext _context;

        public HomeController(UniqloDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var sliderItems = _context.SliderItems.ToList();


            return View(sliderItems);
        }

    }
}

