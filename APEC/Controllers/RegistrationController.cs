using APEC.DOMAIN.Infrastructure;
using APEC.DOMAIN.Models;
using APEC.DOMAIN.Repository;
using APEC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace APEC.Controllers
{
    public class RegistrationController : Controller
    {
        private IBlockRepository _blockRepository;
        private IDistrictRepository _districtRepository;
        private IPostRepository _postRepository;
        private IRegistrationRepository _registrationRepository;
        private IPaymentRepository _paymentRepository;
        private IUnitofWork unitOfWork;

        public RegistrationController(IBlockRepository blockRepository,
            IDistrictRepository districtRepository, IPostRepository postRepository, IUnitofWork unitOfWork, IRegistrationRepository registrationRepo, IPaymentRepository paymentRepository)
        {
            _blockRepository = blockRepository;
            _districtRepository = districtRepository;
            _postRepository = postRepository;
            _registrationRepository = registrationRepo;
            _paymentRepository = paymentRepository;
            this.unitOfWork = unitOfWork;
        }
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult NewRegistration(int districtId = 0)
        {
            var _list = _districtRepository.GetAll();
            ViewBag.DistrictId = new SelectList(_list, "DistrictId", "Name");
            ViewBag.DistrictId1 = new SelectList(_list, "DistrictId", "Name");
            ViewBag.DistrictId2 = new SelectList(_list, "DistrictId", "Name");
            ViewBag.DistrictId3 = new SelectList(_list, "DistrictId", "Name");
            ViewBag.DistrictId4 = new SelectList(_list, "DistrictId", "Name");
            ViewBag.DistrictId5 = new SelectList(_list, "DistrictId", "Name");

            var _blocks = _blockRepository.GetAll();
            if (districtId == 0)
                ViewBag.BlockId = new SelectList(_blocks, "BlockId", "Name");
            else
                ViewBag.BlockId = new SelectList(_blocks.Where(b => b.DistrictId == districtId), "BlockId", "Name");

            var _posts = _postRepository.GetAll().OrderBy(c => c.Code).ThenBy(c => c.Name);
            ViewBag.PostId = new SelectList(_posts, "PostId", "Name");
            var model = new Registration();
            model.ViiiMm = 0;
            model.ViiiMo = 0;
            model.ViiiYear = "N/A";
            model.Hsmm = 0;
            model.Hsmo = 0;
            model.Hsyear = "N/A";
            model.Immm = 0;
            model.Immo = 0;
            model.ImYear = "N/A";
            model.GrMm = 0;
            model.GrMo = 0;
            model.GrYear = "N/A";
            model.GrSubject = "N/A";
            model.PgMm = 0;
            model.PgMo = 0;
            model.PgYear = "N/A";
            model.PgSubject = "N/A";
            model.OtherSubject = "N/A";
            model.OtherMm = 0;
            model.OtherMo = 0;
            model.OtherYear = "N/A";
            return View(model);
        }

        [HttpPost]
        public ActionResult NewRegistration(Registration model)
        {

            if (Convert.ToInt32(model.ViiiMm) > 0 && Convert.ToInt32(model.ViiiMo) == 0)
            {
                ModelState.AddModelError("ViiiMo", "Invalid marks provided.");
            }
            if (Convert.ToInt32(model.ViiiMo) > 0 && Convert.ToInt32(model.ViiiMm) == 0)
            {
                ModelState.AddModelError("ViiiMo", "Invalid marks provided.");
            }
            if (Convert.ToInt32(model.ViiiMm) > 0 && Convert.ToInt32(model.ViiiYear) < 1950)
            {
                ModelState.AddModelError("ViiiMo", "Invalid Year.");
            }

            if (Convert.ToInt32(model.Hsmm) > 0 && Convert.ToInt32(model.Hsmo) == 0)
            {
                ModelState.AddModelError("HsMo", "Invalid marks provided.");
            }
            if (Convert.ToInt32(model.Hsmo) > 0 && Convert.ToInt32(model.Hsmm) == 0)
            {
                ModelState.AddModelError("Hsmo", "Invalid marks provided.");
            }
            if (Convert.ToInt32(model.Hsmm) > 0 && Convert.ToInt32(model.Hsyear) < 1950)
            {
                ModelState.AddModelError("Hsmo", "Invalid Year.");
            }

            if (Convert.ToInt32(model.Immm) > 0 && Convert.ToInt32(model.Immo) == 0)
            {
                ModelState.AddModelError("Immo", "Invalid marks provided.");
            }
            if (Convert.ToInt32(model.ViiiMo) > 0 && Convert.ToInt32(model.ViiiMm) == 0)
            {
                ModelState.AddModelError("Immo", "Invalid marks provided.");
            }
            if (Convert.ToInt32(model.ViiiMm) > 0 && Convert.ToInt32(model.ViiiYear) < 1950)
            {
                ModelState.AddModelError("Immo", "Invalid Year.");
            }

            if (Convert.ToInt32(model.GrMm) > 0 && Convert.ToInt32(model.GrMo) == 0)
            {
                ModelState.AddModelError("GrMo", "Invalid marks provided.");
            }
            if (Convert.ToInt32(model.GrMo) > 0 && Convert.ToInt32(model.GrMm) == 0)
            {
                ModelState.AddModelError("GrMo", "Invalid marks provided.");
            }
            if (Convert.ToInt32(model.GrMm) > 0 && Convert.ToInt32(model.GrYear) < 1950)
            {
                ModelState.AddModelError("GrMo", "Invalid Year.");
            }

            if (Convert.ToInt32(model.PgMm) > 0 && Convert.ToInt32(model.PgMo) == 0)
            {
                ModelState.AddModelError("PgMo", "Invalid marks provided.");
            }
            if (Convert.ToInt32(model.PgMo) > 0 && Convert.ToInt32(model.PgMm) == 0)
            {
                ModelState.AddModelError("PgMo", "Invalid marks provided.");
            }
            if (Convert.ToInt32(model.PgMm) > 0 && Convert.ToInt32(model.PgYear) < 1950)
            {
                ModelState.AddModelError("PgMo", "Invalid Year.");
            }

            if (Convert.ToInt32(model.OtherMm) > 0 && Convert.ToInt32(model.OtherMo) == 0)
            {
                ModelState.AddModelError("OtherMo", "Invalid marks provided.");
            }
            if (Convert.ToInt32(model.OtherMo) > 0 && Convert.ToInt32(model.OtherMm) == 0)
            {
                ModelState.AddModelError("OtherMo", "Invalid marks provided.");
            }
            if (Convert.ToInt32(model.OtherMm) > 0 && Convert.ToInt32(model.OtherYear) < 1950)
            {
                ModelState.AddModelError("OtherMo", "Invalid Year.");
            }

            if (!ModelState.IsValid)
            {
                var _list = _districtRepository.GetAll();
                ViewBag.DistrictId = new SelectList(_list, "DistrictId", "Name");
                ViewBag.DistrictId1 = new SelectList(_list, "DistrictId", "Name");
                ViewBag.DistrictId2 = new SelectList(_list, "DistrictId", "Name");
                ViewBag.DistrictId3 = new SelectList(_list, "DistrictId", "Name");
                ViewBag.DistrictId4 = new SelectList(_list, "DistrictId", "Name");
                ViewBag.DistrictId5 = new SelectList(_list, "DistrictId", "Name");

                var _blocks = _blockRepository.GetAll();
                if (model.DistrictId == 0)
                    ViewBag.BlockId = new SelectList(null, "BlockId", "Name");
                else
                    ViewBag.BlockId = new SelectList(_blocks.Where(b => b.DistrictId == model.DistrictId), "BlockId", "Name");

                var _posts = _postRepository.GetAll().OrderBy(c => c.Code).ThenBy(c => c.Name);
                ViewBag.PostId = new SelectList(_posts, "PostId", "Name");
                return View(model);
            }

            var suffix = _registrationRepository.GetAll().Max(p => p.Suffix) + 1;
            model.Suffix = suffix;
            model.Prefix = "APEC";
            model.ApplicationNumber = "APEC" + suffix.ToString();
            model.RegDate = DateTime.Today.Date;

            if (Convert.ToInt32(model.ViiiMo) > 0 && Convert.ToInt32(model.ViiiMm) > 0)
                model.ViiiPer = Decimal.Round(Convert.ToDecimal((model.ViiiMo / model.ViiiMm) * 100), 2);

            if (Convert.ToInt32(model.Hsmo) > 0 && Convert.ToInt32(model.Hsmm) > 0)
                model.Hsper = Decimal.Round(Convert.ToDecimal((model.Hsmo / model.Hsmm) * 100), 2);

            if (Convert.ToInt32(model.Immo) > 0 && Convert.ToInt32(model.Immm) > 0)
                model.ImPer = Decimal.Round(Convert.ToDecimal((model.Immo / model.Immm) * 100), 2);

            if (Convert.ToInt32(model.GrMo) > 0 && Convert.ToInt32(model.GrMm) > 0)
                model.GrPer = Decimal.Round(Convert.ToDecimal((model.GrMo / model.GrMm) * 100), 2);

            if (Convert.ToInt32(model.PgMo) > 0 && Convert.ToInt32(model.PgMm) > 0)
                model.PgPer = Decimal.Round(Convert.ToDecimal((model.PgMo / model.PgMm) * 100), 2);

            if (Convert.ToInt32(model.OtherMo) > 0 && Convert.ToInt32(model.OtherMm) > 0)
                model.OtherPer = (model.OtherMo / model.OtherMm) * 100;

            _registrationRepository.Add(model);
            unitOfWork.SaveChanges();
            return View();

        }

        [HttpGet]
        public ActionResult RePrintForm()
        {
            ViewBag.Error = "";
            return View();
        }

        [HttpPost]
        public ActionResult RePrintForm(FormCollection collection)
        {
            RegistrationViewModel obj = new RegistrationViewModel();
            TryUpdateModel(obj);

            if (obj.ApplicationNumber != null)
            {
                var model = _registrationRepository.GetMany(r => r.ApplicationNumber.ToLower() == obj.ApplicationNumber.ToLower() && r.Mobile1 == obj.MobileNo).FirstOrDefault();
                if (model == null)
                {
                    ViewBag.Error = "Invalid values provided. Please check and re-enter.";
                    return View();
                }
                else
                {
                    var payment = _paymentRepository.GetMany(p => p.ApplicationNumber == obj.ApplicationNumber).FirstOrDefault();
                    if (payment == null)
                    {
                        ViewBag.Error = "Payment not received for this Application.";
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("printForm", new { ApplicationNumber = obj.ApplicationNumber });
                    }
                }

            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult MakePayment(string applicationNumber)
        {
            if (applicationNumber != "" && applicationNumber != null)
            {
                var obj = _registrationRepository.GetMany(p => p.ApplicationNumber == applicationNumber).FirstOrDefault();
                var model = new RegistrationViewModel
                {
                    ApplicationNumber = obj.ApplicationNumber,
                    Name = obj.Name,
                    Email = obj.Email,
                    MobileNo = obj.Mobile1,
                    Category = obj.Category,
                };
                return View(model);
            }
            else
            {
                var model = new RegistrationViewModel();
                return View(model);
            }

        }

        [HttpPost]
        public ActionResult MakePayment(string applicationNumber, FormCollection data)
        {
            RegistrationViewModel model = new RegistrationViewModel();
            TryUpdateModel(model);
            
            ModelState.Clear();
            var obj = _registrationRepository.GetMany(p => p.ApplicationNumber == applicationNumber).FirstOrDefault();
            if (obj == null)
            {
                return View(new RegistrationViewModel());
            }
            model.ApplicationNumber = obj.ApplicationNumber;
            model.Name = obj.Name;
            model.Email = obj.Email;
            model.MobileNo = obj.Mobile1;
            model.Category = obj.Category;

            model = CalculateRegistrationFees(model);

            return View(model);
        }

        [HttpPost]
        public ActionResult ProceedToPayment(FormCollection data)
        {
            RegistrationViewModel obj = new RegistrationViewModel();
            TryUpdateModel(obj);
            GotoPayment(obj);
            Payment payment = new Payment();
            payment.ApplicationNumber = obj.ApplicationNumber;
            payment.Name = obj.Name;
            payment.Email = obj.Email;
            payment.Mobile1 = obj.MobileNo;
            payment.Category = obj.Category;
            payment.TechCat1 = obj.TechCat1;
            payment.TechCat2 = obj.TechCat2;
            payment.TechCat3 = obj.TechCat3;
            payment.TechCat4 = obj.TechCat4;
            payment.NonTechCat1 = obj.NonTechCat1;
            payment.NonTechCat2 = obj.NonTechCat2;
            payment.NonTechCat3 = obj.NonTechCat3;
            payment.NonTechCat4 = obj.NonTechCat4;
            payment.RegistrationFee = obj.RegistrationFee;
            payment.ServiceTax = obj.ServiceTax;
            payment.Total = obj.Total;
            payment.AmountReceived = 0;
            payment.ReferenceNumber = "";

            _paymentRepository.Add(payment);
            unitOfWork.SaveChanges();

            return View(obj);
        }
        [HttpGet]
        public ActionResult PrintForm(string ApplicationNumber)
        {
            var model = _registrationRepository.GetMany(r=>r.ApplicationNumber == ApplicationNumber).FirstOrDefault();
            var payment = _paymentRepository.GetMany(r => r.ApplicationNumber == ApplicationNumber).FirstOrDefault();


            PrintModel obj = new PrintModel(){
                ApplicationNumber = model.ApplicationNumber,
                Name  = model.Name,
                Email = model.Email,
                MobileNo = model.Mobile1,
                Category = model.Category,
                District1 = _districtRepository.GetByID(model.DistrictId1.Value).Name,
                District2 = _districtRepository.GetByID(model.DistrictId2.Value).Name,
                District3 = _districtRepository.GetByID(model.DistrictId3.Value).Name,
                District4 = _districtRepository.GetByID(model.DistrictId4.Value).Name,
                District5 = _districtRepository.GetByID(model.DistrictId5.Value).Name,
                FatherName  = model.FatherName,
                Sex = model.Sex,
                Dob = model.Dob,
                Address = model.Address,
                District = _districtRepository.GetByID(model.DistrictId.Value).Name,
                Block = _blockRepository.GetByID(model.BlockId.Value).Name,
                Mobile2 = model.Mobile2,
                Viii = model.Viii,
                ViiiSubject = model.ViiiSubject,
                ViiiMm = model.ViiiMm,
                ViiiMo = model.ViiiMo,
                ViiiPer = model.ViiiPer,
                ViiiYear = model.ViiiYear,
                Hs = model.Hs,
                HsSubject = model.HsSubject,
                Hsmm  = model.Hsmm,
                Hsmo = model.Hsmo,
                Hsper = model.Hsper,
                Hsyear = model.Hsyear,
                Im = model.Im,
                ImSubject = model.ImSubject,
                Immm = model.Immm,
                Immo = model.Immo,
                ImPer = model.ImPer,
                ImYear = model.ImYear,
                Gr = model.Gr,
                GrSubject = model.GrSubject,
                GrMm = model.GrMm,
                GrMo  = model.GrMo,
                GrPer = model.GrPer,
                GrYear = model.GrYear,
                Pg= model.Pg,
                PgSubject = model.PgSubject,
                PgMm = model.PgMm,
                PgMo  = model.PgMo,
                PgPer = model.PgPer,
                PgYear = model.PgYear,
                Other = model.Other,
                OtherSubject = model.OtherSubject,
                OtherMm = model.OtherMm,
                OtherMo = model.OtherMo,
                OtherPer = model.OtherPer,
                OtherYear = model.OtherYear,
                ExpComp1  = model.ExpComp1,
                ExpDetail1 = model.ExpDetail1,
                ExpTime1   = model.ExpTime1,
                ExpComp2  =model.ExpComp2,
                ExpDetail2 = model.ExpDetail2,
                ExpTime2  =model.ExpTime2,
                ExpComp3  = model.ExpComp3,
                ExpDetail3 = model.ExpDetail3,
                ExpTime3  = model.ExpTime3,
                TechCat1 = (payment.TechCat1?"YES":"NO"),
                TechCat2 = (payment.TechCat2 ? "YES" : "NO"),
                TechCat3 = (payment.TechCat3 ? "YES" : "NO"),
                TechCat4 = (payment.TechCat4 ? "YES" : "NO"),
                NonTechCat1 = (payment.NonTechCat1 ? "YES" : "NO"),
                NonTechCat2 = (payment.NonTechCat2 ? "YES" : "NO"),
                NonTechCat3 = (payment.NonTechCat3 ? "YES" : "NO"),
                NonTechCat4 = (payment.NonTechCat4 ? "YES" : "NO"),
                RegistrationFee = payment.RegistrationFee,
                ServiceTax = payment.ServiceTax,
                Total = payment.Total,
                AmountReceived = payment.AmountReceived,
                ReferenceNumber = payment.ReferenceNumber,
                Post = _postRepository.GetByID(model.PostId).Name
            };
            
            return View(obj);
        }

        public RegistrationViewModel CalculateRegistrationFees(RegistrationViewModel model)
        {
            double RegFee = 0;
            double STFee = 0;
            int RegCount = 0;
            if (model.TechCat1 == true)
            {
                RegCount = RegCount + 1;
            }
            if (model.TechCat2 == true)
            {
                RegCount = RegCount + 1;
            }
            if (model.TechCat3 == true)
            {
                RegCount = RegCount + 1;
            }
            if (model.TechCat4 == true)
            {
                RegCount = RegCount + 1;
            }
            if (model.NonTechCat1 == true)
            {
                RegCount = RegCount + 1;
            }
            if (model.NonTechCat2 == true)
            {
                RegCount = RegCount + 1;
            }
            if (model.NonTechCat3 == true)
            {
                RegCount = RegCount + 1;
            }
            if (model.NonTechCat4 == true)
            {
                RegCount = RegCount + 1;
            }
            var regCount = RegCount.ToString();

            if (model.Category.Trim() == "GENERAL")
            {
                if (RegCount == 1)
                {
                    RegFee = 500;
                    STFee = 75;
                }
                else if (RegCount == 2)
                {
                    RegFee = 800;
                    STFee = 120;
                }
                else if (RegCount == 3)
                {
                    RegFee = 1100;
                    STFee = 165;
                }
                else if (RegCount == 4)
                {
                    RegFee = 1400;
                    STFee = 210;
                }
                else if (RegCount == 5)
                {
                    RegFee = 1700;
                    STFee = 255;
                }
                else if (RegCount == 6)
                {
                    RegFee = 2000;
                    STFee = 300;
                }
                else if (RegCount == 7)
                {
                    RegFee = 2300;
                    STFee = 345;
                }
                else if (RegCount == 8)
                {
                    RegFee = 2600;
                    STFee = 390;
                }
            }
            else if (model.Category.Trim() == "OBC")
            {
                if (RegCount == 1)
                {
                    RegFee = 500;
                    STFee = 75;
                }
                else if (RegCount == 2)
                {
                    RegFee = 700;
                    STFee = 105;
                }
                else if (RegCount == 3)
                {
                    RegFee = 900;
                    STFee = 135;
                }
                else if (RegCount == 4)
                {
                    RegFee = 1100;
                    STFee = 165;
                }
                else if (RegCount == 5)
                {
                    RegFee = 1300;
                    STFee = 195;
                }
                else if (RegCount == 6)
                {
                    RegFee = 1500;
                    STFee = 225;
                }
                else if (RegCount == 7)
                {
                    RegFee = 1700;
                    STFee = 255;
                }
                else if (RegCount == 8)
                {
                    RegFee = 1900;
                    STFee = 285;
                }
            }
            else if (model.Category.Trim() == "SC")
            {
                if (RegCount == 1)
                {
                    RegFee = 500;
                    STFee = 75;
                }
                else if (RegCount == 2)
                {
                    RegFee = 600;
                    STFee = 90;
                }
                else if (RegCount == 3)
                {
                    RegFee = 700;
                    STFee = 105;
                }
                else if (RegCount == 4)
                {
                    RegFee = 800;
                    STFee = 120;
                }
                else if (RegCount == 5)
                {
                    RegFee = 900;
                    STFee = 135;
                }
                else if (RegCount == 6)
                {
                    RegFee = 1000;
                    STFee = 150;
                }
                else if (RegCount == 7)
                {
                    RegFee = 1100;
                    STFee = 165;
                }
                else if (RegCount == 8)
                {
                    RegFee = 1200;
                    STFee = 180;
                }
            }
            else if (model.Category.Trim() == "ST")
            {
                if (RegCount == 1)
                {
                    RegFee = 500;
                    STFee = 75;
                }
                else if (RegCount == 2)
                {
                    RegFee = 600;
                    STFee = 90;
                }
                else if (RegCount == 3)
                {
                    RegFee = 700;
                    STFee = 105;
                }
                else if (RegCount == 4)
                {
                    RegFee = 800;
                    STFee = 120;
                }
                else if (RegCount == 5)
                {
                    RegFee = 900;
                    STFee = 135;
                }
                else if (RegCount == 6)
                {
                    RegFee = 1000;
                    STFee = 150;
                }
                else if (RegCount == 7)
                {
                    RegFee = 1100;
                    STFee = 165;
                }
                else if (RegCount == 8)
                {
                    RegFee = 1200;
                    STFee = 180;
                }
            }
            model.RegistrationFee = Convert.ToInt32(RegFee);
            model.ServiceTax = Convert.ToDecimal(STFee); //Convert.ToDouble(RegFee * (14.50 / 100)).ToString();
            model.Total = model.RegistrationFee + model.ServiceTax;
            return model;
            //TxtTotalAmount.Text = "50";
        }

        public void GotoPayment(RegistrationViewModel model) //Payment Gateway
        {
            try
            {
                string[] hashVarsSeq;
                string hash_string = string.Empty;
                string txnid1;
                string hash1 = string.Empty;
                string action1 = string.Empty;
                //txnid = TxtRegNo.Text.ToString();
                if (string.IsNullOrEmpty(Request.Form["txnid"])) // generating txnid
                {
                    Random rnd = new Random();
                    string strHash = Generatehash512(rnd.ToString() + DateTime.Now);
                    txnid1 = strHash.ToString().Substring(0, 20);
                }
                else
                {
                    txnid1 = Request.Form["txnid"];
                }
                txnid1 = model.ApplicationNumber;
                if (string.IsNullOrEmpty(Request.Form["hash"])) // generating hash value
                {
                    hashVarsSeq = ConfigurationManager.AppSettings["hashSequence"].Split('|'); // spliting hash sequence from config
                    hash_string = "";
                    foreach (string hash_var in hashVarsSeq)
                    {
                        if (hash_var == "key")
                        {
                            hash_string = hash_string + ConfigurationManager.AppSettings["MERCHANT_KEY"];
                            hash_string = hash_string + '|';
                        }
                        else if (hash_var == "txnid")
                        {
                            hash_string = hash_string + txnid1;/////////////
                            hash_string = hash_string + '|';
                        }
                        else if (hash_var == "TxtTotalAmount")
                        {
                            hash_string = hash_string + Convert.ToDecimal(model.Total).ToString();
                            hash_string = hash_string + '|';
                        }
                        else if (hash_var == "productinfo")
                        {
                            hash_string = hash_string + "None";
                            hash_string = hash_string + '|';
                        }
                        else if (hash_var == "TxtEmail")
                        {
                            hash_string = hash_string + model.Email;/////////////
                            hash_string = hash_string + '|';
                        }
                        else if (hash_var == "TxtRegNo")
                        {
                            hash_string = hash_string + model.ApplicationNumber;/////////////
                            hash_string = hash_string + '|';
                        }
                        else
                        {
                            hash_string = hash_string + "";//(Request.Form[hash_var] != null ? Request.Form[hash_var] : "");// isset if else/////////////
                            hash_string = hash_string + '|';
                        }
                    }
                    hash_string += ConfigurationManager.AppSettings["SALT"];// appending SALT
                    hash1 = Generatehash512(hash_string).ToLower();         //generating hash
                    action1 = ConfigurationManager.AppSettings["PAYU_BASE_URL"] + "/_payment";// setting URL
                }
                else if (!string.IsNullOrEmpty(Request.Form["hash"]))
                {
                    hash1 = Request.Form["hash"];
                    action1 = ConfigurationManager.AppSettings["PAYU_BASE_URL"] + "/_payment";
                }
                if (!string.IsNullOrEmpty(hash1))
                {
                    //hash.Value = hash1;
                    //txnid.Value = txnid1;
                    var key = ConfigurationManager.AppSettings["MERCHANT_KEY"];
                    System.Collections.Hashtable data = new System.Collections.Hashtable(); // adding values in gash table for data post
                    data.Add("hash", hash1);
                    data.Add("txnid", txnid1);/////////////
                    data.Add("key", key);
                    data.Add("hashhhSeq", hash_string);/////////////
                    string AmountForm = model.Total.ToString("g29");// eliminating trailing zeros
                    //TxtTotalAmount.Text = AmountForm;
                    data.Add("amount", AmountForm);
                    data.Add("firstname", model.ApplicationNumber);
                    data.Add("email", model.Email);
                    data.Add("phone", model.MobileNo);
                    data.Add("productinfo", "None");
                    data.Add("surl", "http://www.avaniparidhi.com/Registration/PaymentSuccess");
                    data.Add("furl", "http://www.avaniparidhi.com/Registration/PaymentFailed");
                    data.Add("lastname", "");
                    data.Add("curl", "");
                    data.Add("address1", "");
                    data.Add("address2", "");
                    data.Add("city", "");
                    data.Add("state", "");
                    data.Add("country", "");
                    data.Add("zipcode", "");
                    data.Add("udf1", "");
                    data.Add("udf2", "");
                    data.Add("udf3", "");
                    data.Add("udf4", "");
                    data.Add("udf5", "");
                    data.Add("pg", "");
                    data.Add("service_provider", "payu_paisa");
                    string strForm = PreparePOSTForm(action1, data);
                    model.Trax = strForm;
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                Response.Write("<span style='color:red'>" + ex.Message + "</span>");
            }
        }

        private string PreparePOSTForm(string url, System.Collections.Hashtable data)      // post form  //Payment Gateway
        {
            //Set a name for the form
            string formID = "PostForm";
            //Build the form using the specified data to be posted.
            StringBuilder strForm = new StringBuilder();
            strForm.Append("<form id=\"" + formID + "\" name=\"" +
                           formID + "\" action=\"" + url +
                           "\" method=\"POST\">");
            foreach (System.Collections.DictionaryEntry key in data)
            {
                strForm.Append("<input type=\"hidden\" name=\"" + key.Key +
                               "\" value=\"" + key.Value + "\">");
            }
            strForm.Append("</form>");
            //Build the JavaScript which will do the Posting operation.
            StringBuilder strScript = new StringBuilder();
            strScript.Append("<script language='javascript'>");
            strScript.Append("var v" + formID + " = document." +
                             formID + ";");
            strScript.Append("v" + formID + ".submit();");
            strScript.Append("</script>");
            //Return the form and the script concatenated.
            //(The order is important, Form then JavaScript)
            return strForm.ToString() + strScript.ToString();
        }

        public ActionResult PaymentSuccess(FormCollection collection)
        {

            if (Request.Form["status"] == "success")
            {
                string ApplicationNumber = Request.Form["firstname"].ToString();
                string RefernceNumber = Request.Form["txnid"].ToString();
                decimal Amount = Convert.ToDecimal(Request.Form["amount"].ToString());

                var payment = _paymentRepository.GetMany(p => p.ApplicationNumber == ApplicationNumber).FirstOrDefault();
                payment.ReferenceNumber = RefernceNumber;
                payment.AmountReceived = Amount;


                _paymentRepository.Update(payment);
                unitOfWork.SaveChanges();
                return View(payment);
            }
            return View();

        }
        public ActionResult PaymentFailed(FormCollection collection)
        {

            if (Request.Form["status"] == "success")
            {
                string ApplicationNumber = Request.Form["firstname"].ToString();

                var payment = _paymentRepository.GetMany(p => p.ApplicationNumber == ApplicationNumber).FirstOrDefault();

                _paymentRepository.Delete(payment);
                unitOfWork.SaveChanges();
            }
            return View();

        }
        public string Generatehash512(string text)  //Payment Gateway
        {

            byte[] message = Encoding.UTF8.GetBytes(text);

            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            SHA512Managed hashString = new SHA512Managed();
            string hex = "";
            hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }

    }
}