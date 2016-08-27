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
    public class BlockController : Controller
    {
        private IBlockRepository _blockRepository;
        private IDistrictRepository _districtRepository;
        private IUnitofWork unitOfWork;

        public BlockController(IBlockRepository blockRepository, IDistrictRepository districtRepository, IUnitofWork unitOfWork)
        {
            _blockRepository = blockRepository;
            _districtRepository = districtRepository;
            this.unitOfWork = unitOfWork;
        }

        // GET: Admin/Block
        public ActionResult Index(int? districtId)
        {
            var _list = _districtRepository.GetAll();
            ViewBag.DistrictId = new SelectList(_list, "DistrictId", "Name");
            IEnumerable<Block> blocks;
            if (districtId == null)
                districtId = _list.FirstOrDefault().DistrictId;

            blocks = _blockRepository.GetAll().Where(b => b.DistrictId == districtId);
            return View(blocks);
        }

        // GET: Admin/Block/Create
        public ActionResult Create()
        {
            var _list = _districtRepository.GetAll();
            ViewBag.DistrictId = new SelectList(_list, "DistrictId", "Name");
            return View();
        }

        // POST: Admin/Block/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Block obj = new Block();
                TryUpdateModel(obj);
                _blockRepository.Add(obj);
                unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Block/Edit/5
        public ActionResult Edit(int id)
        {
            var _list = _districtRepository.GetAll();
            ViewBag.DistrictId = new SelectList(_list, "DistrictId", "Name");
            var block = _blockRepository.GetByID(id);

            return View(block);
        }

        // POST: Admin/Block/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Block obj = new Block();
                TryUpdateModel(obj);
                _blockRepository.Update(obj);
                unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Admin/Block/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var obj = _blockRepository.GetByID(id);
                _blockRepository.Delete(obj);
                unitOfWork.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
