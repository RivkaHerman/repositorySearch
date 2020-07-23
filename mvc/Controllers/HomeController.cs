using System.Collections.Generic;
using System.Web.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        //home screen

        [HttpGet]
        public ActionResult ShowHomePage()
        {
            return View("MyHome");
        }
    }
}