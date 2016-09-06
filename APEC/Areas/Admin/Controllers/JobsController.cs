using APEC.DOMAIN.Infrastructure;
using APEC.DOMAIN.Models;
using APEC.DOMAIN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APEC.Areas.Admin.Controllers
{
     [Authorize]
    public class JobsController : Controller
    {
        private IJobRepository _jobRepository;
        private IDistrictRepository _districtRepository;
        private IClientRepository _clientRepository;
        private IUnitofWork _unitOfWork;

        public JobsController(IJobRepository jobRepository, IDistrictRepository districtRepository, IClientRepository clientRepository, IUnitofWork unitOfWork)
        {
            _jobRepository = jobRepository;
            _districtRepository = districtRepository;
            _clientRepository = clientRepository;
            _unitOfWork = unitOfWork;
        }

        // GET: Admin/Jobs
        public ActionResult Index()
        {
            var jobs = _jobRepository.GetAll();
            return View(jobs);
        }

        // GET: Admin/Jobs/Create
        public ActionResult Create()
        {
            var _districts = _districtRepository.GetAll();
            ViewBag.DistrictId = new SelectList(_districts, "DistrictId", "Name");
            var _clients = _clientRepository.GetAll();
            ViewBag.ClientId = new SelectList(_clients, "CLientId", "Name");

            return View();
        }

        // POST: Admin/Jobs/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Job job = new Job();
                TryUpdateModel(job);
                _jobRepository.Add(job);
                _unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Jobs/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = _jobRepository.GetByID(id);

            var _districts = _districtRepository.GetAll();
            ViewBag.Districts = new SelectList(_districts, "DistrictId", "Name", obj.DistrictId);
            var _clients = _clientRepository.GetAll();
            ViewBag.Clients = new SelectList(_clients, "ClientId", "Name",obj.ClientId);
            

            return View(obj);
        }

        // POST: Admin/Jobs/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Job obj = new Job();
                TryUpdateModel(obj);
                _jobRepository.Update(obj);
                _unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Admin/Jobs/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var obj = _jobRepository.GetByID(id);
                _jobRepository.Delete(obj);
                _unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
