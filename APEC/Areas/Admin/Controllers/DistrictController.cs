using APEC.DOMAIN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APEC.Areas.Admin.Controllers
{
    public class DistrictController : Controller
    {
        private IDistrictRepository _districtRepo;

        public DistrictController(IDistrictRepository districtRepo)
        {
            _districtRepo = districtRepo;
        }
        // GET: Admin/District
        public ActionResult Index()
        {
            var districts = _districtRepo.GetAll();
            return View(districts);
        }

        // GET: Admin/District/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/District/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/District/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/District/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/District/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/District/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/District/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
