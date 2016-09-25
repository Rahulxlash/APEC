using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APEC.Models
{
    public class PrintModel
    {
        [Key]
        public string ApplicationNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Category { get; set; }

        public string Prefix { get; set; }
        public int Suffix { get; set; }

        public string District1 { get; set; }
        public string District2 { get; set; }
        public string District3 { get; set; }
        public string District4 { get; set; }
        public string District5 { get; set; }

        public string FatherName { get; set; }

        public string Sex { get; set; }

        public string Dob { get; set; }
        public string Address { get; set; }

        public string District { get; set; }

        public string Block { get; set; }
        public string Mobile1 { get; set; }

        public string Mobile2 { get; set; }


        public string Viii { get; set; }
        public string ViiiSubject { get; set; }
        public decimal? ViiiMm { get; set; }
        public decimal? ViiiMo { get; set; }
        public decimal? ViiiPer { get; set; }
        public string ViiiYear { get; set; }

        public string Hs { get; set; }
        public string HsSubject { get; set; }
        public decimal? Hsmm { get; set; }
        public decimal? Hsmo { get; set; }
        public decimal? Hsper { get; set; }
        public string Hsyear { get; set; }

        public string Im { get; set; }
        public string ImSubject { get; set; }
        public decimal? Immm { get; set; }
        public decimal? Immo { get; set; }
        public decimal? ImPer { get; set; }
        public string ImYear { get; set; }

        public string Gr { get; set; }
        public string GrSubject { get; set; }
        public decimal? GrMm { get; set; }
        public decimal? GrMo { get; set; }
        public decimal? GrPer { get; set; }
        public string GrYear { get; set; }

        public string Pg { get; set; }
        public string PgSubject { get; set; }
        public decimal? PgMm { get; set; }
        public decimal? PgMo { get; set; }
        public decimal? PgPer { get; set; }
        public string PgYear { get; set; }

        public string Other { get; set; }
        public string OtherSubject { get; set; }
        public decimal? OtherMm { get; set; }
        public decimal? OtherMo { get; set; }
        public decimal? OtherPer { get; set; }
        public string OtherYear { get; set; }

        public string ExpComp1 { get; set; }
        public string ExpDetail1 { get; set; }
        public string ExpTime1 { get; set; }
        public string ExpComp2 { get; set; }
        public string ExpDetail2 { get; set; }
        public string ExpTime2 { get; set; }
        public string ExpComp3 { get; set; }
        public string ExpDetail3 { get; set; }
        public string ExpTime3 { get; set; }

        public DateTime RegDate { get; set; }
        public Int64? Otp { get; set; }
        public string Post { get; set; }
        public string Title { get; set; }

        public string  TechCat1 { get; set; }
        public string  TechCat2 { get; set; }
        public string  TechCat3 { get; set; }
        public string  TechCat4 { get; set; }
        public string  NonTechCat1 { get; set; }
        public string  NonTechCat2 { get; set; }
        public string  NonTechCat3 { get; set; }
        public string  NonTechCat4 { get; set; }

        public decimal RegistrationFee { get; set; }
        public decimal ServiceTax { get; set; }
        public decimal Total { get; set; }
        public decimal AmountReceived { get; set; }
        public string  ReferenceNumber { get; set; }

        public string Trax { get; set; }
    }
}