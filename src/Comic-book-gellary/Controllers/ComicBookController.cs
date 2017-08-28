using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comic_book_gellary.Controllers
{
    public class ComicBookController : Controller
    {
       public ActionResult Detail ()
        {
           ViewBag.SeriesTitle = "The Amazing Spiderman";
           ViewBag.IssueNumber = 700;
           ViewBag.Description = "<p>The quick brown fox jumps right over the lazy dog.The quick brown fox jumps right over the lazy dog.The quick brown fox jumps right over the lazy dog.The quick brown fox jumps right over the lazy dog.The quick brown fox jumps right over the lazy dog.The quick brown fox jumps right over the lazy dog.The quick brown fox jumps right over the lazy dog.</p>";
           ViewBag.Artists = new string[]
           {
               "Script: Dan Slott",
               "Pencils: Humberto Ramos",
               "Inks: Victor Olazaba",
               "Colors: Edgar Delgado",
               "Letters: Chris Eliopoulos"
           };

            return View();
        }
    }
}