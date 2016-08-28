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
    public class ClientController : Controller
    {
        // GET: Admin/Client_
        private IClientRepository _iClientRepository;
        private IDistrictRepository _districtRepository;

        private IUnitofWork _unitOfWork;

        public ClientController(IClientRepository iClientRepository, IUnitofWork iUnitofWork ,IDistrictRepository districtRepository)
        {
            _iClientRepository = iClientRepository;
            _unitOfWork = iUnitofWork;
            _districtRepository = districtRepository;
        }
        public ActionResult Index()
        {
            var Client = _iClientRepository.GetAll();
            return View(Client);
        }

        // GET: Admin/Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Client/Create
        public ActionResult Create()
        {
            var _list = _districtRepository.GetAll();
            ViewBag.DistrictId = new SelectList(_list, "DistrictId", "Name");
            return View();
        }

        // POST: Admin/Client/Create
        [HttpPost]
        public ActionResult Create(Client client )
        {
            try
            {
                // TODO: Add insert logic here
                _iClientRepository.Add(client);
                _unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Client/Edit/5
        public ActionResult Edit(int id)
        {
             var client=_iClientRepository.GetByID(id);
             var _list = _districtRepository.GetAll();
             ViewBag.DistrictId = new SelectList(_list, "DistrictId", "Name",client.DistrictId);
            return View(client);
        }

        // POST: Admin/Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Client client= new Client();
                TryUpdateModel(client);
                
                _iClientRepository.Update(client);
                _unitOfWork.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Client/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {

                var obj = _iClientRepository.GetByID(id);
                _iClientRepository.Delete(obj);
                _unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Admin/Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var obj = _iClientRepository.GetByID(id);
                _iClientRepository.Delete(obj);
                _unitOfWork.SaveChanges();
                return RedirectToAction("Index");
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
