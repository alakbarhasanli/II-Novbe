using Microsoft.AspNetCore.Mvc;
using Uniqlo_MVC.Contexts;
using Uniqlo_MVC.Models;

namespace Uniqlo_MVC.Areas.admin.Controllers
{
    [Area("admin")]
    public class SliderItemController : Controller
    {
        private readonly UniqloDbContext _context;

        public SliderItemController(UniqloDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var sliderItems = _context.SliderItems.ToList();


            return View(sliderItems);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SliderItem sliderItem)
        {
            _context.SliderItems.Add(sliderItem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(SliderItem sliderItem)
        {
            if (ModelState.IsValid)
            {
                SliderItem? UpdatedService = _context.SliderItems.Find(sliderItem.Id);
                if (UpdatedService == null) { return NotFound(); }
                UpdatedService.Title = sliderItem.Title;
                UpdatedService.MainImageUrl = sliderItem.MainImageUrl;
                UpdatedService.ButtonUrl = sliderItem.ButtonUrl;
                _context.SliderItems.Update(UpdatedService);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));

            }


            return View(sliderItem);
        }
        public IActionResult Delete(int Id)
        {
            SliderItem? deletedService = _context.SliderItems.Find(Id);
            if (deletedService == null) { return NotFound(); }
            else
            {
                _context.SliderItems.Remove(deletedService);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Info(int id)
        {
            var InfosliderItem = _context.SliderItems.Find(id);
            if (InfosliderItem == null)
            {
                return NotFound();
            }
            return View(InfosliderItem);



        }
    }
}
