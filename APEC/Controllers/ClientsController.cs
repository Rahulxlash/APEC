using APEC.DOMAIN.Infrastructure;
using APEC.DOMAIN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APEC.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Clients
       private IClientRepository _iClientRepository;
        private IDistrictRepository _districtRepository;

        private IUnitofWork _unitOfWork;

        public ClientsController(IClientRepository iClientRepository, IUnitofWork iUnitofWork, IDistrictRepository districtRepository)
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
    }
}