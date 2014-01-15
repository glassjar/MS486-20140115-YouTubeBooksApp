using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MS486_20140115_YouTubeBooksApp.Models;

namespace MS486_20140115_YouTubeBooksApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var booksCollection = new List<Book>();
            if (Session["BooksCollection"] != null)
            {
                booksCollection = (List<Book>) Session["BooksCollection"];
            }
            return View(booksCollection);
        }

        [HttpGet]
        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(Book newBook)
        {
            var booksCollection = new List<Book>();

            if (Session["BooksCollection"] != null)
            {
                booksCollection.AddRange( (List<Book>) Session["BooksCollection"] );
            }
            booksCollection.Add(newBook);

            Session["BooksCollection"] = booksCollection;

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
