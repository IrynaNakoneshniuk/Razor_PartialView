using Microsoft.AspNetCore.Mvc;
using Razor_PartialView.Models;

namespace Razor_PartialView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult MyData()
        {
            return View();
        }

        public IActionResult MyDataView(PersonInfo personInfo)
        { 
            return View(personInfo);
        }
    }
}