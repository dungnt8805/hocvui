using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialWebApp.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }

        // 
        // POST:
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            return RedirectToAction("");
        }

        //
        // GET:

        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST:
        [HttpPut]
        public ActionResult ChangePassword(FormCollection collection)
        {
            return RedirectToAction("");
        }

        //
        // GET:
        
    }
}
