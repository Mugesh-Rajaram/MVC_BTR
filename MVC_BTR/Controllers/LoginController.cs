using MVC_BTR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace MVC_BTR.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login LoginDetails)
        {
            try
            {
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index", "BTR", new { Area = "BTR" });
        }
    }
}
