using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                // return new RedirectResult("/");
                return Redirect("/");
                
            }

            //return new ContentResult()
            //{
            //    Content = "This is a test."
            //};
            return Content("This is a test.");
        }
    }
}