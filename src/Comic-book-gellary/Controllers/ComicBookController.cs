using Comic_book_gellary.Models;
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
            var commicBook = new CommicBook() 
            {
                SeriesTitle = "The Amazing Spiderman",
                IssueNumber = 700,
                DescriptionHtml = "<p>The quick brown fox jumps right over the lazy dog.The quick brown fox jumps right over the lazy dog.The quick brown fox jumps right over the lazy dog.The quick brown fox jumps right over the lazy dog.The quick brown fox jumps right over the lazy dog.The quick brown fox jumps right over the lazy dog.The quick brown fox jumps right over the lazy dog.</p>",
                Artists = new Artist[] 
                { 
                    new Artist() {Name = "Dan Slott", Role = "Script"},
                    new Artist() {Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist() {Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() {Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() {Name = "Chris Eliopoulos", Role = "Letters"}
                }
                
            };

           return View(commicBook);

        }
    }
}