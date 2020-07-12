using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        public int Repository { get; private set; }

        public ActionResult ShowHomePage()
        {
            return View("MyHome");
        }


        public ActionResult GetJsonDataModel(string searchText)
        {
            string val = searchText;
            var searchText1 = "WordSearch"; //searchText;
            var webClient = new WebClient();
            webClient.Headers.Add("user-agent", "Only a test!");
            var json = webClient.DownloadString(@"https://api.github.com/search/repositories?q=" + searchText1);
            Models.Repository objJson = JsonConvert.DeserializeObject<Repository>(json);
            return View(objJson);
        }
    }
}