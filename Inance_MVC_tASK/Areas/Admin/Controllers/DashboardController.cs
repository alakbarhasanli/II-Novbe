using Microsoft.AspNetCore.Mvc;

namespace Inance_MVC_tASK.Areas.Admin.Controllers
{
    [Area("admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
