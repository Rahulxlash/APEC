using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APEC.Areas.Admin.Controllers
{
     [Authorize]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}