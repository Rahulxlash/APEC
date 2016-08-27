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
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int AutoID { get; set; }
      public string PREFIX {get; set; }
      public string SUFFIX {get; set; }
      public string DISTRICT1 {get; set; }
      public string DISTRICT2 {get; set; }
      public string DISTRICT3 {get; set; }
      public string DISTRICT4 {get; set; }
      public string DISTRICT5 {get; set; }
      public string NAME {get; set; }
      public string FATHERNAME {get; set; }
      public string CATEGORY {get; set; }
      public string SEX {get; set; }
      public string DOB {get; set; }
      public string ADDRESS {get; set; }
      public string DISTRICT {get; set; }
      public string BLOCK {get; set; }
      public string MOBILE1 {get; set; }
      public string MOBILE2 {get; set; }
      public string EMAIL {get; set; }
      public string VIII {get; set; }
      public string VIIISUBJECT {get; set; }
      public string VIIIMM {get; set; }
      public string VIIIMO {get; set; }
      public string VIIIPER {get; set; }
      public string VIIIYEAR {get; set; }
      public string HS {get; set; }
      public string HSSUBJECT {get; set; }
      public string HSMM {get; set; }
      public string HSMO {get; set; }
      public string HSPER {get; set; }
      public string HSYEAR {get; set; }
      public string IM {get; set; }
      public string IMSUBJECT {get; set; }
      public string IMMM {get; set; }
      public string IMMO {get; set; }
      public string IMPER {get; set; }
      public string IMYEAR {get; set; }
      public string GR {get; set; }
      public string GRSUBJECT {get; set; }
      public string GRMM {get; set; }
      public string GRMO {get; set; }
      public string GRPER {get; set; }
      public string GRYEAR {get; set; }
      public string PG {get; set; }
      public string PGSUBJECT {get; set; }
      public string PGMM {get; set; }
      public string PGMO {get; set; }
      public string PGPER {get; set; }
      public string PGYEAR {get; set; }
      public string OTHER {get; set; }
      public string OTHERSUBJECT {get; set; }
      public string OTHERMM {get; set; }
      public string OTHERMO {get; set; }
      public string OTHERPER {get; set; }
      public string OTHERYEAR {get; set; }
      public string EXPCOMP1 {get; set; }
      public string EXPDETAIL1 {get; set; }
      public string EXPTIME1 {get; set; }
      public string EXPCOMP2 {get; set; }
      public string EXPDETAIL2 {get; set; }
      public string EXPTIME2 {get; set; }
      public string EXPCOMP3 {get; set; }
      public string EXPDETAIL3 {get; set; }
      public string EXPTIME3 {get; set; }
      public string REGDATE {get; set; }
      public string OTP {get; set; }
      public string POSTNAME {get; set; }
      public string TITLE {get; set; }
    }
}
