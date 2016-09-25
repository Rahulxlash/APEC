using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace APEC.Models
{
    public class RegistrationViewModel
    {
        public string ApplicationNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Category { get; set; }

        public bool TechCat1 { get; set; }
        public bool TechCat2 { get; set; }
        public bool TechCat3 { get; set; }
        public bool TechCat4 { get; set; }
        public bool NonTechCat1 { get; set; }
        public bool NonTechCat2 { get; set; }
        public bool NonTechCat3 { get; set; }
        public bool NonTechCat4 { get; set; }

        public int  RegistrationFee { get; set; }
        public decimal ServiceTax { get; set; }
        public decimal  Total { get; set; }

        public string Trax { get; set; }
    }
}