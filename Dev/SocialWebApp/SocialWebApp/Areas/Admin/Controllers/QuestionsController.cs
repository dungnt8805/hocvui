using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialWebApp.Areas.Admin.Controllers
{
    public class QuestionsController : Controller
    {
        //
        // GET: /Admin/Questions/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET:
        public ActionResult Edit()
        {
            return View();
        }

        //
        // PUT
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormCollection collection)
        {
            return RedirectToAction("");
        }

        //
        // GET
        public ActionResult Delete()
        {
            return View();
        }

        //
        // PUT
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(FormCollection collection)
        {
            return RedirectToAction("");
        }

    }
}
