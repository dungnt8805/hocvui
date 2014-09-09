using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialWebApp.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Admin/Users/

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
        // POST
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
            return RedirectToAction("");
        }
        //
        //
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(FormCollection collection)
        {
            return RedirectToAction("");
        }
        //
        // GET:
        [ValidateAntiForgeryToken]
        public ActionResult Restore()
        {
            return RedirectToAction("");
        }
        //
        // POST:
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Restore(FormCollection collection)
        {
            return RedirectToAction("");
        }

    }
}
