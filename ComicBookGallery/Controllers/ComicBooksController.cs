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
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.issueNumber = 700;
            ViewBag.description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
            return View();  // will automatically look in the views folder
        }

        public ActionResult Detail2()
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