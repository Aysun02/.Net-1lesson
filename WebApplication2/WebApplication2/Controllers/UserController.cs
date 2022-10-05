using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
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
