﻿using Microsoft.AspNetCore.Mvc;

namespace Uniqlo_MVC.Areas.admin.Controllers
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
