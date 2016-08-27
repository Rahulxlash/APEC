using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
    [Table("Registration")]
    public class Registration
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoId { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string District1 { get; set; }
        public string District2 { get; set; }
        public string District3 { get; set; }
        public string District4 { get; set; }
        public string District5 { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Category { get; set; }
        public string Sex { get; set; }
        public string Dob { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Block { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Email { get; set; }
        public string Viii { get; set; }
        public string ViiiSubject { get; set; }
        public string ViiiMm { get; set; }
        public string ViiiMo { get; set; }
        public string ViiiPer { get; set; }
        public string ViiiYear { get; set; }
        public string Hs { get; set; }
        public string HsSubject { get; set; }
        public string Hsmm { get; set; }
        public string Hsmo { get; set; }
        public string Hsper { get; set; }
        public string Hsyear { get; set; }
        public string Im { get; set; }
        public string ImSubject { get; set; }
        public string Immm { get; set; }
        public string Immo { get; set; }
        public string ImPer { get; set; }
        public string ImYear { get; set; }
        public string Gr { get; set; }
        public string GrSubject { get; set; }
        public string GrMm { get; set; }
        public string GrMo { get; set; }
        public string GrPer { get; set; }
        public string GrYear { get; set; }
        public string Pg { get; set; }
        public string PgSubject { get; set; }
        public string PgMm { get; set; }
        public string PgMo { get; set; }
        public string PgPer { get; set; }
        public string PgYear { get; set; }
        public string Other { get; set; }
        public string OtherSubject { get; set; }
        public string OtherMm { get; set; }
        public string OtherMo { get; set; }
        public string OtherPer { get; set; }
        public string OtherYear { get; set; }
        public string ExpcOmp1 { get; set; }
        public string ExpDetail1 { get; set; }
        public string ExpTime1 { get; set; }
        public string ExpComp2 { get; set; }
        public string ExpDetail2 { get; set; }
        public string ExpTime2 { get; set; }
        public string ExpComp3 { get; set; }
        public string ExpDetail3 { get; set; }
        public string Exptime3 { get; set; }
        public string RegDate { get; set; }
        public string Otp { get; set; }
        public string PostName { get; set; }
        public string Title { get; set; }

    }
}
