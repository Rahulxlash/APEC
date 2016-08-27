using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        public string RegistrationNumber { get; set; }

        public int ClientID { get; set; }

        public double Salary { get; set; }

        public double PFAmount { get; set; }

        public string UAN { get; set; }

        public string PANNumber { get; set; }

        public string AadhaarID { get; set; }

    }
}
