using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MS486_20140115_YouTubeBooksApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Message = hour < 12? "Good morning" : "Good afternoon";
            return View();
        }
        public string SomeAction()
        {
            return "This text is from SomeAction()";
        }
    }
}
