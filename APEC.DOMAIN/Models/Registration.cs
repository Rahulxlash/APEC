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
        [Key,  Column("Application Number")]
        public string ApplicationNumber { get; set; }
        public string Prefix { get; set; }
        public int Suffix { get; set; }

        [Display(Name = "District One")]
        [Required]
        public int? DistrictId1 { get; set; }
        [Required]
        public int? DistrictId2 { get; set; }
        [Required]
        public int? DistrictId3 { get; set; }
        [Required]
        public int? DistrictId4 { get; set; }
        [Required]
        public int? DistrictId5 { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Column("Father Name")]
        [Display(Name = "Father's Name")]
        [Required(ErrorMessage = "Father's Name is required.")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }
        
        [Required]
        public string Sex { get; set; }
        
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date of Birth is required.")]
        public string Dob { get; set; }
        
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }
        
        [Required]
        public int? DistrictId { get; set; }
        
        [Required]
        public int? BlockId { get; set; }
        
        [Display(Name = "Mobile 1")]
        [Required(ErrorMessage = "Mobile number is required.")]
        public string Mobile1 { get; set; }
        
        [Display(Name = "Mobile 2")]
        public string Mobile2 { get; set; }
        
        [EmailAddress(ErrorMessage = "Invalid Email.")]
        public string Email { get; set; }
        
        public string Viii { get; set; }
        
        public string ViiiSubject { get; set; }
        
        [DataType(DataType.Currency, ErrorMessage = "Invalid value.")]
        [Range(0, 1000)]
        public decimal? ViiiMm { get; set; }
        
        [DataType(DataType.Currency, ErrorMessage = "Invalid value.")]
        [Range(0, 1000)]
        public decimal? ViiiMo { get; set; }

        public decimal? ViiiPer { get; set; }
        
        public string ViiiYear { get; set; }
        
        public string Hs { get; set; }
        
        public string HsSubject { get; set; }
        
        [DataType(DataType.Currency, ErrorMessage = "Invalid value.")]
        [Range(0, 1000)]
        public decimal? Hsmm { get; set; }
        
        [DataType(DataType.Currency, ErrorMessage = "Invalid value.")]
        [Range(0, 1000)]
        public decimal? Hsmo { get; set; }

        public decimal? Hsper { get; set; }
        
        public string Hsyear { get; set; }
        
        public string Im { get; set; }
        
        public string ImSubject { get; set; }
        
        [DataType(DataType.Currency, ErrorMessage = "Invalid value.")]
        [Range(0, 1000)]
        public decimal? Immm { get; set; }
        
        [DataType(DataType.Currency, ErrorMessage = "Invalid value.")]
        [Range(0, 1000)]
        public decimal? Immo { get; set; }

        public decimal? ImPer { get; set; }
        
        public string ImYear { get; set; }
        
        public string Gr { get; set; }
        
        public string GrSubject { get; set; }
        
        [DataType(DataType.Currency, ErrorMessage = "Invalid value.")]
        [Range(0, 1000)]
        public decimal? GrMm { get; set; }
        
        [DataType(DataType.Currency, ErrorMessage = "Invalid value.")]
        [Range(0, 1000)]
        public decimal? GrMo { get; set; }

        public decimal? GrPer { get; set; }
        
        public string GrYear { get; set; }
        
        public string Pg { get; set; }
        
        public string PgSubject { get; set; }
        
        [DataType(DataType.Currency, ErrorMessage = "Invalid value.")]
        [Range(0, 1000)]
        public decimal? PgMm { get; set; }
        
        [DataType(DataType.Currency, ErrorMessage = "Invalid value.")]
        [Range(0, 1000)]
        public decimal? PgMo { get; set; }

        public decimal? PgPer { get; set; }
        
        public string PgYear { get; set; }
        
        public string Other { get; set; }
        
        public string OtherSubject { get; set; }
        
        [DataType(DataType.Currency, ErrorMessage = "Invalid value.")]
        [Range(0, 1000)]
        public decimal? OtherMm { get; set; }
        
        [DataType(DataType.Currency, ErrorMessage = "Invalid value.")]
        [Range(0, 1000)]
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
        
        [Column("REG DATE")]
        public DateTime RegDate { get; set; }
        
        public Int64? Otp { get; set; }
        
        [Display(Name = "Post")]
        public int PostId { get; set; }
        
        public string Title { get; set; }
        
        [ForeignKey("DistrictId")]
        public virtual District District { get; set; }
        [ForeignKey("DistrictId1")]
        public virtual District District1 { get; set; }
        [ForeignKey("DistrictId2")]
        public virtual District District2 { get; set; }
        [ForeignKey("DistrictId3")]
        public virtual District District3 { get; set; }
        [ForeignKey("DistrictId4")]
        public virtual District District4 { get; set; }
        [ForeignKey("DistrictId5")]
        public virtual District District5 { get; set; }
        [ForeignKey("BlockId")]
        public virtual Block Block { get; set; }
        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }

    }


}
