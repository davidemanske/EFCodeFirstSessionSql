using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionStateSql.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Session()
        {
            HttpContext.Session["RandomGuid"] = Guid.NewGuid();
            return View();
        }

        public ActionResult SessionCheck()
        {
            return View(HttpContext.Session["RandomGuid"]);
        }
    }
}