using System.Collections.Generic;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class BookmarksController : Controller
    {
        //retrieve the stored bookmarks from session into a list

        [HttpGet]
        public ActionResult DisplayBookmarks()
        {
            List<Models.Bookmark> bookmarks = (List<Models.Bookmark>)Session["SavedBookmarks"];
            return View(bookmarks);
        }
    }
}