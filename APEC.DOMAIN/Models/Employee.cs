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
        public int employeeID { get; set; }

        public string registrationNumber { get; set; }

        public int clientID { get; set; }

        public double salary { get; set; }

        public double PFAmount { get; set; }

        public string UAN { get; set; }

        public string PANNumber { get; set; }

        public string aadhaarID{ get; set; }

    }
}
