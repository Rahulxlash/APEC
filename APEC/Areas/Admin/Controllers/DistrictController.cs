﻿using APEC.DOMAIN.Infrastructure;
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
    public class DistrictController : Controller
    {
        private IDistrictRepository _districtRepo;
        private IBlockRepository _blockRepository;
        private IUnitofWork UnitOfWork;

        public DistrictController(IDistrictRepository districtRepo, IBlockRepository blockRepository, IUnitofWork unitOfWork)
        {
            _districtRepo = districtRepo;
            _blockRepository = blockRepository;
            UnitOfWork = unitOfWork;
        }

        // GET: Admin/District
        public ActionResult Index()
        {
            var districts = _districtRepo.GetAll();
            return View(districts);
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/District/Create
        [HttpPost]
        public ActionResult Create(District district)
        {
            try
            {
                // TODO: Add insert logic here
                _districtRepo.Add(district);
                UnitOfWork.SaveChanges();
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
            var obj = _districtRepo.GetByID(id);
            return View(obj);
        }

        // POST: Admin/District/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                District district = new District();
                TryUpdateModel(district);
                _districtRepo.Update(district);
                UnitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Admin/District/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                
                var obj = _districtRepo.GetByID(id);
                _districtRepo.Delete(obj);
                UnitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
