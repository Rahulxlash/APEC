using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
    public class Payment
    {
        [Key, Column("Apllication Number")]
        public string ApplicationNumber { get; set; }

        public string  Name { get; set; }

        public string  Category { get; set; }

        public string Mobile1 { get; set; }

        public string Email { get; set; }

        public Boolean TechCat1 { get; set; }
        public Boolean TechCat2 { get; set; }
        public Boolean TechCat3 { get; set; }
        public Boolean TechCat4 { get; set; }

        public Boolean NonTechCat1 { get; set; }
        public Boolean NonTechCat2 { get; set; }
        public Boolean NonTechCat3 { get; set; }
        public Boolean NonTechCat4 { get; set; }

        [Column("REG AMOUNT")]
        public decimal RegistrationFee { get; set; }

        [Column("SERVICE TAX")]
        public decimal ServiceTax { get; set; }

        [Column("TOTAL AMOUNT")]
        public decimal  Total { get; set; }

        [Column("AMOUNT RECEIVED")]
        public decimal AmountReceived { get; set; }

        [Column("REFERENCE NUMBER")]
        public string ReferenceNumber { get; set; }

    }
}
