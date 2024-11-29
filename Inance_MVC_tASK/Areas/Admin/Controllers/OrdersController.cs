using Microsoft.AspNetCore.Mvc;

namespace Inance_MVC_tASK.Areas.Admin.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
