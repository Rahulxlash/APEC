using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APEC.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewRegistration()
        {
            return View();
        }

        public ActionResult MakePayment()
        {
            return View();
        }

        public ActionResult rePrintForm()
        {
            return View();
        }

    }
}