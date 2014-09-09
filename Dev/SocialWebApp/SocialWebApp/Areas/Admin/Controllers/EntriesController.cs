using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using SocialWebApp.Models;

namespace SocialWebApp.Areas.Admin.Controllers
{
    public class EntriesController : Controller
    {
        //
        // GET: /Admin/Entries/

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET:
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST:
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection collection)
        {
            return RedirectToAction("");
        }

        //
        // GET:
        public ActionResult Edit()
        {
            return View();
        }

        //
        // POST:
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormCollection collection)
        {
            return RedirectToAction("");
        }

        //
        // GET:
        public ActionResult Delete()
        {
            return RedirectToAction("");
        }
    }
}
