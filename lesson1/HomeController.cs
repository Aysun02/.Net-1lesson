using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Aysun";
            ViewBag.Surname = "Huseynli";
            ViewBag.Age = "19";
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = "+994506143502";
            return View();
        }
    }
}
