using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
    [Table("SkilledEmployeeSalary")]
    public class SkilledEmployeeSalary
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Type { get; set; }

        public int Salary { get; set; }

        public DateTime EffectiveDate { get; set; }

        public DateTime EffectiveFrom { get; set; }

    }

    [Table("PayRoll")]
    public class Payroll
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PayRollID { get; set; }

        public int EmployeeID { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public int TotalDays { get; set; }

        public int PayableDays { get; set; }

        public int AbsentDays { get; set; }

        public double GrossSalary { get; set; }

        public double NetSalary { get; set; }

        public double Deduction { get; set; }

        public double credited { get; set; }

        public long TransID { get; set; }

        public string ApprovedBy { get; set; }

    }
    [Table("Deduction")]
    public class Deduction
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PayRollID { get; set; }

        public int EmployeeID { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public int TotalDays { get; set; }

        public int PayableDays { get; set; }

        public int AbsentDays { get; set; }

        public double GrossSalary { get; set; }

        public double NetSalary { get; set; }

        public double DeductionAmount { get; set; }

        public double Credited { get; set; }

        public long PFTransID { get; set; }

        public long ESTransID { get; set; }

        public string ApprovedBy { get; set; }

    }
}
