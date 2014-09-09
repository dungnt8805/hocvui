using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialWebApp.Areas.Admin.Controllers
{
    public class AlertsController : Controller
    {
        //
        // GET: /Admin/Alerts/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET
        public ActionResult Details()
        {
            return View();
        }
        //
        // PUT
        public ActionResult Delete()
        {
            return RedirectToAction("");
        }

    }
}
