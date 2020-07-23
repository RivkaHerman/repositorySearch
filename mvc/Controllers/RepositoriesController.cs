using System.Collections.Generic;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net;
using mvc.Models;
using System.Configuration;

namespace mvc.Controllers
{
    public class RepositoriesController : Controller
    {
        //new repository search screen

        [HttpGet]
        public ActionResult GetJsonDataModel()
        {
            return View("SearchForRepository");
        }

        // get and render the repositories which came from GitHub api according to the word the user inserted

        [HttpPost]
        public ActionResult GetJsonDataModel(string searchText)
        {
            if (searchText.Length < 1)
                return View("SearchForRepository");
            else
            {
                var webClient = new WebClient();
                webClient.Headers.Add("user-agent", "repository");
                var json = webClient.DownloadString(ConfigurationManager.AppSettings["API_URL"].ToString() + searchText);
                Models.Repository objJson = JsonConvert.DeserializeObject<Repository>(json);
                return View(objJson);
            }
        }

        //store the bookmarked repositories in session

        [HttpPost]
        public ActionResult SaveToSession(string AvatarURL, string Name)
        {
            List<Models.Bookmark> bookmarks = new List<Bookmark>();
            Models.Bookmark bookmark = new Bookmark();
            bookmark.Avatar_url = AvatarURL;
            bookmark.Name = Name;
            if (Session["SavedBookmarks"] != null)
            {
                bookmarks = (List<Bookmark>)Session["SavedBookmarks"];
            }
            bookmarks.Add(bookmark);
            Session["SavedBookmarks"] = bookmarks;
            return RedirectToAction("GetJsonDataModel", "Repositories");
        }
    }
}