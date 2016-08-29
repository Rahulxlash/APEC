using APEC.DOMAIN;
using APEC.DOMAIN.Repository;
using APEC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APEC.Controllers
{
    public class HomeController : Controller
    {
        private IJobRepository _jobRepository;

        public HomeController(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Jobs()
        {
            VacanciesViewModel model = new VacanciesViewModel();

            var jobs = _jobRepository.GetMany(j => j.ApplicationLastDate >= DateTime.Now);
            var expiredJobs = _jobRepository.GetMany(j => j.ApplicationLastDate < DateTime.Now);
            model.CurrentJobs = jobs.ToList();
            model.ExpiredJobs = expiredJobs.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}