using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialWebApp.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        //
        // GET: /Admin/Categories/

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
        // PUT:
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormCollection collection)
        {
            return RedirectToAction("");
        }


    }
}
