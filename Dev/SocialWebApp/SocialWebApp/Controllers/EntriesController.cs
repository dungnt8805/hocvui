using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialWebApp.Controllers
{
    public class EntriesController : Controller
    {
        //
        // GET: /Entries/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int entryId)
        {
            ViewBag.entryId = entryId;
            return View();
        }

    }
}
