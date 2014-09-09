using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialWebApp.Controllers
{   
    public class AuthController : Controller
    {

        //
        // GET: /dang-ki

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /dang-ki

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                //return RedirectToAction("Index");
                return View();
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /dang-nhap
        public ActionResult Login()
        {
            return View();
        }

        //
        // POST: /dang-ki
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            try
            {
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /kich-hoa-tai-khoan
        public ActionResult Active()
        {
            try
            {
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET:
        public ActionResult ForgotPassword()
        {
            return View();
        }

        //
        // POST:
        [HttpPost]
        public ActionResult ForgotPassword(FormCollection collection)
        {
            return View();
        }

        //
        // GET:
        public ActionResult ForgotPasswordConfirm()
        {
            return View();
        }

        //
        // POST:
        [HttpPost]
        public ActionResult ForgotPasswordConfirm(FormCollection collection)
        {
            return View();
        }

        //
        // GET:
        public ActionResult Logout()
        {
            return RedirectToAction("");
        }
    }
}
