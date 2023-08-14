using Microsoft.AspNetCore.Mvc;
using Razor_PartialView.Models;
using Razor_PartialView.Services;

namespace Razor_PartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetListsUserInfo _listsUserInfo;

        public HomeController(IGetListsUserInfo listsUserInfo)
        {
            _listsUserInfo = listsUserInfo;
        }
        public IActionResult MyData()
        {
            ViewBag.Hobbies = _listsUserInfo.GetListHobbies();
            ViewBag.Cities = _listsUserInfo.GetSelectedCity(); 
            return View();
        }

        public IActionResult MyDataView(PersonInfo personInfo)
        { 
            return View(personInfo);
        }
    }
}